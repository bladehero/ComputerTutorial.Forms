using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ComputerHardwareGuide.Models;
using ComputerHardwareGuide.Models.Components;

namespace PocketComputerTutorial.Forms.Controls.Components
{
    public partial class ComponentList : UserControl
    {
        public event EventHandler GoBackClicked;
        public ComponentList(Assembly assembly, IEnumerable<BaseComponent> baseComponents)
        {
            InitializeComponent();

            if (baseComponents?.Count() > 0)
            {
                foreach (var component in baseComponents)
                {
                    var componentView = new ComponentView(assembly, component);
                    ComponentPanel.Controls.Add(componentView);
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            GoBackClicked?.Invoke(this, e);
        }
    }
}
