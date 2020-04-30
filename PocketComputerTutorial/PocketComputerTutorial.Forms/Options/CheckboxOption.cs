using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ComputerHardwareGuide.Models.ViewModels;

namespace PocketComputerTutorial.Forms.Options
{
    public partial class CheckboxOption : UserControl, IBaseOption
    {
        public Unit Unit { get; set; }

        public UnitType UnitType => UnitType.CheckboxGroup;

        public IEnumerable<(string, object)> Dictionary
        {
            get
            {
                var selectedIndeces = SelectedIndeces();
                if (selectedIndeces?.Count == 0)
                {
                    return new (string, object)[] { };
                }
                var selectedOptions = new List<Option>();
                var options = Unit.Options.ToList();
                for (int i = 0; i < options.Count; i++)
                {
                    if (selectedIndeces.Any(x => x == i))
                    {
                        selectedOptions.Add(options[i]);
                    }
                }
                return selectedOptions.Select(x => (x.Key, x.Value));
            }
        }

        public CheckboxOption(Unit unit)
        {
            InitializeComponent();
            Unit = unit;

            TitleLabel.Text = unit.Name;
            int top = 10, left = 10;
            var checkboxes = unit.Options.Select(x => new CheckBox()
            {
                Text = x.Text
            }).ToArray();
            foreach (var checkbox in checkboxes)
            {
                checkbox.Top = top;
                top += checkbox.Height + 5;
                checkbox.Left = left;
            }
            GroupBox.Controls.AddRange(checkboxes);
            GroupBox.Height = top + 10;
            this.Height = GroupBox.Height + 50;
        }


        private List<int> SelectedIndeces()
        {
            var children = GroupBox.Controls;
            var indeces = new List<int>();
            foreach (var child in children)
            {
                if (child is CheckBox checkbox)
                {
                    if (checkbox.Checked)
                    {
                        var index = children.IndexOf(checkbox);
                        if (index != -1)
                        {
                            indeces.Add(index);
                        }
                    }
                }
            }
            return indeces;
        }
    }
}
