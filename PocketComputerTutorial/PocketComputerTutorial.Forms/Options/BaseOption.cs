using ComputerHardwareGuide.Models.ViewModels;
using System.Collections.Generic;

namespace PocketComputerTutorial.Forms.Options
{
    public interface IBaseOption
    {
        Unit Unit { get; set; }
        UnitType UnitType { get; }
        IEnumerable<(string, object)> Dictionary { get; }
    }
}
