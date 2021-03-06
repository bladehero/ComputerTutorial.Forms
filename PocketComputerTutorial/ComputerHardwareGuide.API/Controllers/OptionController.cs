﻿using ComputerHardwareGuide.API.Extensions;
using ComputerHardwareGuide.Models;
using ComputerHardwareGuide.Models.Components;
using ComputerHardwareGuide.Models.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComputerHardwareGuide.API.Controllers
{
    /// <summary>
    /// Option controller for component search
    /// </summary>
    public sealed class OptionController : BaseController
    {
        /// <summary>
        /// Method of getting lookups
        /// </summary>
        /// <param name="type">Component type</param>
        /// <returns>Returns lookups for search</returns>
        public async Task<BaseApiResponse<IEnumerable<Lookup>>> GetLookups(ComponentTypeEnumeration type) 
            => await Get<IEnumerable<Lookup>>("lookup", type);

        /// <summary>
        /// Method of getting firms
        /// </summary>
        /// <param name="type">Component type</param>
        /// <returns>Returns firms for search</returns>
        public async Task<BaseApiResponse<IEnumerable<Firm>>> GetFirms(ComponentTypeEnumeration type)
            => await Get<IEnumerable<Firm>>("firm", type);

        /// <summary>
        /// Method of getting units
        /// </summary>
        /// <param name="type">Component type</param>
        /// <returns>Returns units for search</returns>
        public async Task<BaseApiResponse<GetUnitVM>> GetUnits(ComponentTypeEnumeration type)
            => await Get<GetUnitVM>("unit", type);

        private async Task<BaseApiResponse<T>> Get<T>
            (string endpoint, ComponentTypeEnumeration type)
        {
            var dictionary = new Dictionary<string, object>();
            dictionary.Add("type", (int)type);
            return await ApplicationHttpClient.HttpSendAsync<T>(CombineExtension.UrlCombine(BaseUrl, endpoint),
                queryParameters: dictionary);
        }
    }
}
