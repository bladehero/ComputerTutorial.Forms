using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ComputerHardwareGuide.API
{
    /// <summary>
    /// Response with custom type provided
    /// </summary>
    /// <typeparam name="T">Custom type</typeparam>
    public class BaseApiResponse<T> : BaseApiResponse
    {
        /// <summary>
        /// Custom type object
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public T Data { get; set; }
    }

    /// <summary>
    /// Basic response what returns API.
    /// </summary>
    public class BaseApiResponse
    {
        /// <summary>
        /// Flag shows if result of request is successful
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; }
        /// <summary>
        /// A collection of errors if existed
        /// </summary>
        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Error> Errors { get; set; } = new List<Error>();
        /// <summary>
        /// Cookies are returned in reponse
        /// </summary>
        public IEnumerable<Cookie> Cookies { get; set; }
        /// <summary>
        /// String is read from response body stream
        /// </summary>
        public string OriginalDataString { get; set; }
    }

    /// <summary>
    /// Class of error
    /// </summary>
    public class Error
    {
        /// <summary>
        /// Unique error code
        /// </summary>
        public int ErrorCode { get; set; }
        /// <summary>
        /// Error text describes type of error
        /// </summary>
        public string ErrorText { get; set; }
    }

    /// <summary>
    /// Custom application http client for sending requests
    /// </summary>
    public class ApplicationHttpClient
    {
        private readonly HttpClient _httpClient;

        public CookieContainer _cookies = new CookieContainer();

        /// <summary>
        /// Headers what are sent in request
        /// </summary>
        public readonly Dictionary<string, string> _headers = new Dictionary<string, string>();

        internal ApplicationHttpClient(HttpClientHandler httpClientHandler)
        {
            httpClientHandler.CookieContainer = _cookies;
            _httpClient = new HttpClient(httpClientHandler);
        }

        /// <summary>
        /// Core method of sending, parsing and getting response using data
        /// </summary>
        /// <typeparam name="TF">Type of response's result</typeparam>
        /// <param name="uri">Uri on which is sent request</param>
        /// <param name="endPoint">Additional segment of Uri</param>
        /// <param name="data">Data is added to request body</param>
        /// <param name="mediaType">Type of data added to request</param>
        /// <param name="method">HTTP method</param>
        /// <param name="headers">Headers to add into request</param>
        /// <param name="queryParameters">Query params</param>
        /// <param name="useGzip">If gzip's needed use true</param>
        /// <returns>Result of request to the API using custom type</returns>
        public async Task<BaseApiResponse<TF>> HttpSendAsync<TF>(string uri, string endPoint = "", object data = null,
            string mediaType = "application/json", HttpMethod method = null, IDictionary<string, string> headers = null,
            IEnumerable<KeyValuePair<string, object>> queryParameters = null, bool useGzip = false)
        {
            BaseApiResponse<TF> result = new BaseApiResponse<TF>();
            try
            {
                if (useGzip)
                    _httpClient.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));

                if (string.IsNullOrWhiteSpace(uri))
                    throw new FormatException("'Uri' cannot be empty or null.");

                var uriBuilder = new UriBuilder($"{uri.TrimEnd(' ', '/')}/{endPoint}".TrimEnd('/'));
                var queryString = string.Empty;

                if (queryParameters?.Count() > 0)
                    foreach (var keyValue in queryParameters.Where(
                        parameter => !string.IsNullOrWhiteSpace(parameter.Key)))
                        queryString += $"{keyValue.Key}={keyValue.Value}&";

                if (!string.IsNullOrWhiteSpace(queryString))
                {
                    queryString = queryString.TrimEnd('&');
                }

                uriBuilder.Query = queryString;
                var request = new HttpRequestMessage(method ?? HttpMethod.Get, uriBuilder.ToString());

                foreach (var keyValue in _headers)
                    request.Headers.Add(keyValue.Key, keyValue.Value);

                if (headers != null)
                    foreach (var keyValue in headers)
                        request.Headers.Add(keyValue.Key, keyValue.Value);

                if (data != null)
                {
                    var stringContent = JsonConvert.SerializeObject(data);
                    request.Content = new StringContent(stringContent, Encoding.UTF8, mediaType);
                }

                var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);
                
                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    result.OriginalDataString = responseString;
                    result.Cookies = _cookies.GetCookies(request.RequestUri).Cast<Cookie>();
                    result.Success = response.IsSuccessStatusCode;
                    result.Data = JsonConvert.DeserializeObject<TF>(responseString);
                }
                else
                    result.Errors = new[] { new Error { ErrorCode = (int)response.StatusCode, ErrorText = response.ReasonPhrase } };
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Errors = new[] { new Error { ErrorCode = 0, ErrorText = ex.Message } };
            }

            return result;
        }
    }
}
