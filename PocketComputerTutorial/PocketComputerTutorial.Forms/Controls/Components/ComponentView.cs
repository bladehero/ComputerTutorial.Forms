using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ComputerHardwareGuide.Models.Components;
using ComputerHardwareGuide.Models;
using System.IO;
using ComputerHardwareGuide.API;
using ComputerHardwareGuide.Models.ViewModels;

namespace PocketComputerTutorial.Forms.Controls.Components
{
    public partial class ComponentView : UserControl
    {
        public event EventHandler Deleted;

        public Assembly Assembly { get; set; }
        public BaseComponent Component { get; set; }

        public ComponentView(Assembly assembly, BaseComponent baseComponent, int? quantity = null)
        {
            InitializeComponent();
            Assembly = assembly;
            Component = baseComponent;

            PriceLabel.Text = baseComponent.Price.ToString();
            NameLabel.Text = baseComponent.Name;
            if (quantity.HasValue)
            {
                QunatityLabel.Text = $"{quantity}pcs.";
                DeleteButton.Visible = true;
            }
            else
            {
                AddButton.Visible = true;
            }
            var bytes = baseComponent.ComponentPictures.FirstOrDefault()?.FileStream;
            if (bytes != null)
            {
                Picture.Image = Image.FromStream(new MemoryStream(bytes));
            }

            AddButton.Click += AddButton_Click;
            DeleteButton.Click += DeleteButton_Click;
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            var result = await APIContext.Assemblies.Delete(Assembly.Id, Component.Id, (int)Component.Type);
            if (result.Success)
            {
                Deleted?.Invoke(this, e);
            }
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {

                var result = await APIContext.Assemblies.Post(new AddAssemblyComponentVM
                {
                    AssemblyId = Assembly.Id,
                    ComponentId = Component.Id,
                    Quantity = 1,
                    Type = Component.Type
                });
                if (result.Success)
                {
                    this.ParentForm.DialogResult= DialogResult.OK;
                    this.ParentForm.Close();
                }
        }

    }
}
