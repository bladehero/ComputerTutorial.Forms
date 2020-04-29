using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using PocketComputerTutorial.Forms.Modals;
using ComputerHardwareGuide.API;
using ComputerHardwareGuide.Models;

namespace PocketComputerTutorial.Forms.Controls.Assemblies
{
    public partial class AssemblyList : UserControl
    {
        public AssemblyList()
        {
            InitializeComponent();

            AddButton.Click += AddButton_Click;

            BaseApiResponse<IEnumerable<Assembly>> assemblies = null;
            Task.Run(async () =>
            {
                assemblies = await APIContext.Assemblies.Get();
            }).Wait();
            foreach (var assembly in assemblies.Data)
            {
                var assemblyView = new AssemblyView(assembly);
                assemblyView.Deleted += AssemblyView_Deleted;
                AssemblyPanel.Controls.Add(assemblyView);
            }
        }

        private async void AssemblyView_Deleted(object sender, EventArgs e)
        {
            var assemblyView = sender as AssemblyView;
            var id = assemblyView.Assembly.Id;
            var result = await APIContext.Assemblies.Delete(id);
            if (result.Success)
            {
                AssemblyPanel.Controls.Remove(assemblyView);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var modal = new UpdateAssemblyModal();
            modal.ShowDialog(this);
        }
    }
}
