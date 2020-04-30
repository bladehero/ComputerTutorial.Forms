using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ComputerHardwareGuide.Models.ViewModels;

namespace PocketComputerTutorial.Forms.Options
{
    public partial class RangeOption : UserControl, IBaseOption
    {
        public RangeOption(Unit unit)
        {
            InitializeComponent();
            Unit = unit;

            var first = unit.Options.First();
            var last = unit.Options.Last();
            var min = Convert.ToSingle(first.Value);
            var max = Convert.ToSingle(last.Value);

            TitleLabel.Text = $"{unit.Name}";

            MinNumeric.Minimum = (decimal)min;
            MinNumeric.Maximum = (decimal)max;

            MaxNumeric.Minimum = (decimal)min;
            MaxNumeric.Maximum = (decimal)max;

            MinNumeric.Value = (decimal)min;
            MaxNumeric.Value = (decimal)max;
        }

        public Unit Unit { get; set; }
        public UnitType UnitType => UnitType.Range;
        public IEnumerable<(string, object)> Dictionary
        {
            get
            {
                return new (string, object)[]
                {
                    ($"{Unit.Options.First().Key}", MinNumeric.Value.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)),
                    ($"{Unit.Options.Last().Key}", MaxNumeric.Value.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture))
                };
            }
        }
    }
}
