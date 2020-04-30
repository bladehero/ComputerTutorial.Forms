using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ComputerHardwareGuide.Models.ViewModels;

namespace PocketComputerTutorial.Forms.Options
{
    public partial class RadiobuttonOption : UserControl, IBaseOption
    {
        public Unit Unit { get; set; }

        public UnitType UnitType => UnitType.RadiobuttonGroup;

        public IEnumerable<(string, object)> Dictionary
        {
            get
            {
                var radioButtons = GroupBox.Controls.Cast<RadioButton>().ToList();
                var selected = radioButtons.FirstOrDefault(x => x.Checked);
                if (selected == null)
                {
                    return new (string, object)[] { };
                }
                return new (string, object)[] { (Unit.Key, Unit.Options.ToList()[radioButtons.IndexOf(selected)].Value) };
            }
        }

        public RadiobuttonOption(Unit unit)
        {
            InitializeComponent();
            Unit = unit;

            TitleLabel.Text = unit.Name;
            var radioButtons = unit.Options.Select(x => new RadioButton()
            {
                Text = x.Text
            }).ToArray();
            int top = 10, left = 10;
            foreach (var radioButton in radioButtons)
            {
                radioButton.Top = top;
                top += radioButton.Height + 5;
                radioButton.Left = left;
            }
            GroupBox.Controls.AddRange(radioButtons);
            GroupBox.Height = top + 10;
            this.Height = GroupBox.Height + 50;
        }
    }
}
