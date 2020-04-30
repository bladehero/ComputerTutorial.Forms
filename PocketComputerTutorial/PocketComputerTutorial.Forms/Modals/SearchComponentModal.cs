using ComputerHardwareGuide.Models;
using ComputerHardwareGuide.Models.Components;
using ComputerHardwareGuide.Models.ViewModels;
using PocketComputerTutorial.Forms.Controls.SearchComponents;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PocketComputerTutorial.Forms.Modals
{
    public partial class SearchComponentModal : Form
    {
        public SearchComponentModal(Assembly assembly,
                                    ComponentTypeEnumeration type,
                                    IEnumerable<Firm> firms,
                                    IEnumerable<Lookup> lookups,
                                    GetUnitVM unitModel)
        {
            InitializeComponent();
            DialogResult = DialogResult.None;
            var searchList = new SearchComponentList(assembly, type, firms, lookups, unitModel);
            Controls.Add(searchList);
        }
    }
}
