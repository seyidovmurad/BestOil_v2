using BestOil_v2.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil_v2.Views.Main
{
    public interface IMainView
    {
        EventHandler<EventArgs> OilPriceEventHandler { get; set; }

        EventHandler<EventArgs> OilLitreEventHandler { get; set; }

        EventHandler<EventArgs> OilSelectChangedEventHandler { get; set; }

        EventHandler<EventArgs> ProductAmountChangeEventHandler { get; set; }

        EventHandler<EventArgs> PayBtnPressedEventHandler { get; set; }

        Color OilPriceColor { set; }

        Color OilLitreColor { set; }

        string OilPrice { get; set; }

        string OilLitre { get; set; }

        string ProductSumPrice { get; set; }

        string SumPrice { get; set; }

        List<ProductUC.ProductUC> Products { get; set; }
        
        List<OilUC.OilUC> Oils { get; set; }
       

    }
}
