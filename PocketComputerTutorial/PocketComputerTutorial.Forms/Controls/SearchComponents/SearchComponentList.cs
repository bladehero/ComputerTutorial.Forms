using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ComputerHardwareGuide.Models;
using ComputerHardwareGuide.Models.Components;
using ComputerHardwareGuide.Models.ViewModels;
using ComputerHardwareGuide.Models.Helpers;
using ComputerHardwareGuide.API;
using PocketComputerTutorial.Forms.Options;
using System;
using PocketComputerTutorial.Forms.Controls.Components;

namespace PocketComputerTutorial.Forms.Controls.SearchComponents
{
    public partial class SearchComponentList : UserControl
    {
        public ComponentTypeEnumeration ComponentTypeEnumeration { get; set; }
        public Assembly Assembly { get; set; }

        public SearchComponentList(Assembly assembly,
                                   ComponentTypeEnumeration type,
                                   IEnumerable<Firm> firms,
                                   IEnumerable<Lookup> lookups,
                                   GetUnitVM unitModel)
        {
            InitializeComponent();
            Assembly = assembly;

            ComponentTypeEnumeration = type;

            Label.Text = $"Options for {type.GetDescription()}";
            Search.Text = $"Search";
            Search.Click += Search_Click;

            foreach (var unit in unitModel.Units)
            {
                switch (unit.UnitType)
                {
                    case UnitType.CheckboxGroup:
                        var checkboxGroupOption = new CheckboxOption(unit);
                        OptionPanel.Controls.Add(checkboxGroupOption);
                        break;
                    case UnitType.RadiobuttonGroup:
                        var radioButtonOption = new RadiobuttonOption(unit);
                        OptionPanel.Controls.Add(radioButtonOption);
                        break;
                    case UnitType.Range:
                        var rangeOption = new RangeOption(unit);
                        OptionPanel.Controls.Add(rangeOption);
                        break;
                    case UnitType.Text:
                        foreach (var option in unit.Options)
                        {
                            var textInput = new TextOption(unit, option);
                            OptionPanel.Controls.Add(textInput);
                        }
                        break;
                    default:
                        break;
                }
            }

            var firmUnit = new Unit
            {
                Name = "Firms",
                Key = "firms",
                UnitType = UnitType.CheckboxGroup,
                Options = firms.Select(x => new Option
                {
                    Key = "firms",
                    Text = $"{x.Name} ({x.Country})",
                    Value = x.Id
                })
            };
            var firmsOption = new CheckboxOption(firmUnit);
            OptionPanel.Controls.Add(firmsOption);

            foreach (var lookup in lookups)
            {
                var lookupUnit = new Unit
                {
                    Name = lookup.Name,
                    Key = lookup.Key,
                    UnitType = UnitType.CheckboxGroup,
                    Options = lookup.LookupValues.Select(x => new Option
                    {
                        Key = lookup.Key,
                        Text = x.DisplayText,
                        Value = x.Id
                    })
                };
                var lookupOption = new CheckboxOption(lookupUnit);
                OptionPanel.Controls.Add(lookupOption);
            }
        }

        private async void Search_Click(object sender, System.EventArgs e)
        {
            try
            {
                var dictionary = new List<KeyValuePair<string, object>>();
                foreach (var child in OptionPanel.Controls)
                {
                    if (child is IBaseOption option)
                    {
                        dictionary.AddRange(option.Dictionary
                            .Select(x => new KeyValuePair<string, object>(x.Item1, x.Item2)));
                    }
                }

                IEnumerable<BaseComponent> components = null;
                switch (ComponentTypeEnumeration)
                {
                    case ComponentTypeEnumeration.CPU:
                        var resultCPUs = await APIContext.CPUs.Get(dictionary);
                        components = resultCPUs.Data;
                        break;
                    case ComponentTypeEnumeration.RAM:
                        var resultRAMs = await APIContext.RAMs.Get(dictionary);
                        components = resultRAMs.Data;
                        break;
                    case ComponentTypeEnumeration.GPU:
                        var resultGPUs = await APIContext.GPUs.Get(dictionary);
                        components = resultGPUs.Data;
                        break;
                    case ComponentTypeEnumeration.PowerUnit:
                        var resultPowerUnits = await APIContext.PowerUnits.Get(dictionary);
                        components = resultPowerUnits.Data;
                        break;
                    case ComponentTypeEnumeration.Motherboard:
                        var resultMotherboards = await APIContext.Motherboards.Get(dictionary);
                        components = resultMotherboards.Data;
                        break;
                    case ComponentTypeEnumeration.HDD:
                        var resultHDDs = await APIContext.HDDs.Get(dictionary);
                        components = resultHDDs.Data;
                        break;
                    case ComponentTypeEnumeration.SSD:
                        var resultSSDs = await APIContext.SSDs.Get(dictionary);
                        components = resultSSDs.Data;
                        break;
                }
                var componentListPage = new ComponentList(Assembly, components);
                componentListPage.GoBackClicked += (o, a) =>
                {
                    this.ParentForm.Controls.Remove(componentListPage);
                    this.Visible = true;
                };
                this.Visible = false;
                this.ParentForm.Controls.Add(componentListPage);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
