using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil_v2.Views.Digits
{
    interface IDigitView
    {
        EventHandler<EventArgs> DigitEventHandeler { get; set; }

        EventHandler<EventArgs> DelEventHandeler { get; set; }

        string NumberOnScreen { get; set; }

        bool IsDecimal { get; set; }

    }
}
