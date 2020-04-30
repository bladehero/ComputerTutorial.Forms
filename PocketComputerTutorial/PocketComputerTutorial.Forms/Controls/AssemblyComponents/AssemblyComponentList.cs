using System;
using System.Linq;
using System.Windows.Forms;
using ComputerHardwareGuide.Models;
using ComputerHardwareGuide.Models.Components;
using ComputerHardwareGuide.API;
using PocketComputerTutorial.Forms.Modals;
using PocketComputerTutorial.Forms.Controls.Components;

namespace PocketComputerTutorial.Forms.Controls.AssemblyComponents
{
    public partial class AssemblyComponentList : UserControl
    {
        public Assembly Assembly { get; set; }

        public event EventHandler BackClicked;
        public event EventHandler RefreshClicked;

        public AssemblyComponentList(Assembly assembly, int total)
        {
            Assembly = assembly;
            InitializeComponent();
            SetVisibility();

            NameLabel.Text = assembly.Name;
            CurrentLabel.Text = total.ToString();
            TotalLabel.Text = assembly.ToPrice.ToString();
            ProgressLabel.Text = GetReadyPercentage().ToString();
            ProgressBar.Value = GetReadyPercentage();

            BackButton.Click += BackButton_Click;
            RefreshButton.Click += RefreshButton_Click;


            CPUButton.Click += CPUButton_Clicked;
            RAMButton.Click += RAMButton_Clicked;
            GPUButton.Click += GPUButton_Clicked;
            PowerUnitButton.Click += PowerUnitButton_Clicked;
            MotherboardButton.Click += MotherboardButton_Clicked;
            HDDButton.Click += HDDButton_Clicked;
            SSDButton.Click += SSDButton_Clicked;

            foreach (var assemblyComponent in assembly.AssemblyComponents)
            {
                var componentView = new ComponentView(assembly, assemblyComponent.BaseComponent, assemblyComponent.Quantity);
                componentView.Deleted += (o, a) =>
                {
                    RefreshClicked?.Invoke(this, a);
                };
                AssemblyComponentPanel.Controls.Add(componentView);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshClicked?.Invoke(this, e);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            BackClicked?.Invoke(this, e);
        }

        private int GetReadyPercentage()
        {
            int count = 0;

            count += Assembly.AssemblyComponents
                .Any(x => x.ComponentType.ComponentTypeEnumeration == ComponentTypeEnumeration.CPU) ? 1 : 0;
            count += Assembly.AssemblyComponents
                .Any(x => x.ComponentType.ComponentTypeEnumeration == ComponentTypeEnumeration.RAM) ? 1 : 0;
            count += Assembly.AssemblyComponents
                .Any(x => x.ComponentType.ComponentTypeEnumeration == ComponentTypeEnumeration.GPU) ? 1 : 0;
            count += Assembly.AssemblyComponents
                .Any(x => x.ComponentType.ComponentTypeEnumeration == ComponentTypeEnumeration.Motherboard) ? 1 : 0;
            count += Assembly.AssemblyComponents
                .Any(x => x.ComponentType.ComponentTypeEnumeration == ComponentTypeEnumeration.PowerUnit) ? 1 : 0;
            count += Assembly.AssemblyComponents
                .Any(x => x.ComponentType.ComponentTypeEnumeration == ComponentTypeEnumeration.SSD ||
                x.ComponentType.ComponentTypeEnumeration == ComponentTypeEnumeration.HDD) ? 1 : 0;

            return (int)(((double)count / 6) * 100);
        }



        private void SSDButton_Clicked(object sender, EventArgs e)
        {
            GoToSearchPage(ComponentTypeEnumeration.SSD);
        }

        private void HDDButton_Clicked(object sender, EventArgs e)
        {
            GoToSearchPage(ComponentTypeEnumeration.HDD);
        }

        private void MotherboardButton_Clicked(object sender, EventArgs e)
        {
            GoToSearchPage(ComponentTypeEnumeration.Motherboard);
        }

        private void PowerUnitButton_Clicked(object sender, EventArgs e)
        {
            GoToSearchPage(ComponentTypeEnumeration.PowerUnit);
        }

        private void GPUButton_Clicked(object sender, EventArgs e)
        {
            GoToSearchPage(ComponentTypeEnumeration.GPU);
        }

        private void RAMButton_Clicked(object sender, EventArgs e)
        {
            GoToSearchPage(ComponentTypeEnumeration.RAM);
        }

        private void CPUButton_Clicked(object sender, EventArgs e)
        {
            GoToSearchPage(ComponentTypeEnumeration.CPU);
        }

        private async void GoToSearchPage(ComponentTypeEnumeration type)
        {
            var resultFirms = await APIContext.Options.GetFirms(type);
            var resultLookups = await APIContext.Options.GetLookups(type);
            var resultUnits = await APIContext.Options.GetUnits(type);
            if (resultFirms.Success && resultLookups.Success && resultUnits.Success)
            {
                var searchModal = new SearchComponentModal(Assembly, type, resultFirms.Data, resultLookups.Data, resultUnits.Data);
                var result = searchModal.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    RefreshClicked?.Invoke(this, new EventArgs());
                }
            }
        }

        private void SetVisibility()
        {
            if (!Assembly.AssemblyComponents
                .Any(x => x.ComponentType.ComponentTypeEnumeration == ComponentTypeEnumeration.CPU))
            {
                CPUButton.Visible = true;
                return;
            }
            if (!Assembly.AssemblyComponents
                .Any(x => x.ComponentType.ComponentTypeEnumeration == ComponentTypeEnumeration.RAM))
            {
                RAMButton.Visible = true;
                return;
            }
            if (!Assembly.AssemblyComponents
                .Any(x => x.ComponentType.ComponentTypeEnumeration == ComponentTypeEnumeration.GPU))
            {
                GPUButton.Visible = true;
                return;
            }
            if (!Assembly.AssemblyComponents
                .Any(x => x.ComponentType.ComponentTypeEnumeration == ComponentTypeEnumeration.PowerUnit))
            {
                PowerUnitButton.Visible = true;
                return;
            }
            if (!Assembly.AssemblyComponents
                .Any(x => x.ComponentType.ComponentTypeEnumeration == ComponentTypeEnumeration.Motherboard))
            {
                MotherboardButton.Visible = true;
                return;
            }

            if (!Assembly.AssemblyComponents
                .Any(x => x.ComponentType.ComponentTypeEnumeration == ComponentTypeEnumeration.HDD))
            {
                HDDButton.Visible = true;
            }
            if (!Assembly.AssemblyComponents
                .Any(x => x.ComponentType.ComponentTypeEnumeration == ComponentTypeEnumeration.SSD))
            {
                SSDButton.Visible = true;
            }
        }
    }
}
