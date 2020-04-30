using System;
using System.Windows.Forms;
using ComputerHardwareGuide.Models;
using ComputerHardwareGuide.API;
using PocketComputerTutorial.Forms.Modals;

namespace PocketComputerTutorial.Forms.Controls.Assemblies
{
    public partial class AssemblyView : UserControl
    {
        public Assembly Assembly { get; set; }

        public event EventHandler Deleted;
        public event EventHandler Updated;
        public event EventHandler Opened;

        public AssemblyView(Assembly assembly)
        {
            Assembly = assembly;
            InitializeComponent();

            AssemblyNameLabel.Text = assembly.Name;

            PriceLabel.Text = assembly.ToPrice.ToString();
            AssemblyNameLabel.Click += Label_Click;
            PriceLabel.Click += Label_Click;

            ChangeButton.Click += ChangeButton_Click;
            DeleteButton.Click += DeleteButton_Click;
        }

        private void Label_Click(object sender, EventArgs e)
        {
            var modal = new UpdateAssemblyModal(Assembly)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            var result = modal.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                Updated?.Invoke(this, e);
            }
        }

        private async void ChangeButton_Click(object sender, EventArgs e)
        {
            var result = await APIContext.Assemblies.Get(Assembly.Id);
            if (result.Success)
            {
                Opened?.Invoke(this, e);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Deleted?.Invoke(this, e);
        }
    }
}
