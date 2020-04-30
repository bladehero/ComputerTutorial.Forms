using ComputerHardwareGuide.API;
using ComputerHardwareGuide.Models;
using System;
using System.Windows.Forms;

namespace PocketComputerTutorial.Forms.Modals
{
    public partial class UpdateAssemblyModal : Form
    {
        public Assembly Assembly { get; set; }

        public UpdateAssemblyModal()
        {
            InitializeComponent();
            Assembly = new Assembly();
            SaveButton.Click += SaveButton_Click;
            CancelButton.Click += CancelButton_Click;
            DialogResult = DialogResult.None;
        }
        public UpdateAssemblyModal(Assembly assembly) : this()
        {
            Assembly = assembly;
            NameBox.Text = assembly.Name;
            PriceBox.Value = assembly.ToPrice;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            bool success = false;
            try
            {
                if (Assembly.Id == 0)
                {
                    var result = await APIContext.Assemblies.Post(new Assembly
                    {
                        Name = NameBox.Text,
                        ToPrice = (int)PriceBox.Value
                    });
                    success = result.Success;
                }
                else
                {
                    var result = await APIContext.Assemblies.Put(new ComputerHardwareGuide.Models.ViewModels.UpdateAssemblyVM
                    {
                        AssemblyId = Assembly.Id,
                        ToPrice = (int)PriceBox.Value,
                        Name = NameBox.Text
                    });
                    success = result.Success;
                }
            }
            catch (Exception ex)
            {
                success = false;
            }
            finally
            {
                if (success)
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("An unexpected error was occured!");
                }
            }
        }
    }
}
