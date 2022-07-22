using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil_v2.Models
{
    public class Oil
    {
        public string OilType { get; set; }

        public float OilPrice { get; set; }

        public Oil(string oilType, float oilPrice)
        {
            OilType = oilType;
            OilPrice = oilPrice;
        }

        public Oil()
        {

        }

        public override string ToString()
        {
            return $"{OilType} {OilPrice}";
        }
    }
}
