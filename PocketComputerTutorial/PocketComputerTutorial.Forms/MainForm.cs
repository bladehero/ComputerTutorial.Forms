using ComputerHardwareGuide.API;
using PocketComputerTutorial.Forms.Controls.Assemblies;
using PocketComputerTutorial.Forms.Controls.AssemblyComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocketComputerTutorial.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            OpenInitPage();
        }

        private void OpenInitPage()
        {
            Controls.Clear();
            var assemblyList = new AssemblyList();
            assemblyList.Opened += AssemblyList_Opened;
            Controls.Add(assemblyList);
        }

        private async void AssemblyList_Opened(object sender, EventArgs e)
        {
            if (sender is AssemblyView assemblyView)
            {
                Controls.Clear();
                var result = await APIContext.Assemblies.Get(assemblyView.Assembly.Id);
                if (result.Success)
                {
                    var assemblyComponentList = new AssemblyComponentList(result.Data.Assembly,
                        (int)result.Data.Total);
                    assemblyComponentList.BackClicked += AssemblyComponentList_BackClicked;
                    assemblyComponentList.RefreshClicked += (o, a) => AssemblyList_Opened(sender, e);
                    Controls.Add(assemblyComponentList);
                }
            }
        }

        private void AssemblyComponentList_BackClicked(object sender, EventArgs e)
        {
            OpenInitPage();
        }
    }
}
