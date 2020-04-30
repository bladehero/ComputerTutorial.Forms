using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                // TODO: Open content with assembly components
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Deleted?.Invoke(this, e);
        }
    }
}
