using System.Collections.Generic;
using System.Windows.Forms;
using ComputerHardwareGuide.Models.ViewModels;

namespace PocketComputerTutorial.Forms.Options
{
    public partial class TextOption : UserControl, IBaseOption
    {
        public Unit Unit { get; set; }
        public Option Option { get; set; }

        public UnitType UnitType => UnitType.Text;

        public IEnumerable<(string, object)> Dictionary
        {
            get
            {
                if (string.IsNullOrWhiteSpace(ValueInput.Text))
                {
                    return new (string, object)[] { };
                }
                return new (string, object)[] { (Unit.Key, ValueInput.Text) };
            }
        }
        public TextOption(Unit unit, Option option)
        {
            InitializeComponent();
            Unit = unit;
            Option = option;

            TitleLabel.Text = option.Text;
            ValueInput.Text = option.Value.ToString();
        }
    }
}
