using BestOil_v2.Models;
using BestOil_v2.Presenter.Digits;
using BestOil_v2.Views.Digits;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil_v2.Views.Main
{
    public partial class MainView : Form, IMainView
    {
        public EventHandler<EventArgs> OilPriceEventHandler { get; set; }

        public EventHandler<EventArgs> ProductAmountChangeEventHandler { get; set; }

        public EventHandler<EventArgs> OilLitreEventHandler { get; set; }

        public EventHandler<EventArgs> OilSelectChangedEventHandler { get; set; }

        public EventHandler<EventArgs> PayBtnPressedEventHandler { get; set; }
        
        public string OilPrice { get => Lbl_SumOilPrice.Text; set => Lbl_SumOilPrice.Text = value; }
       
        public string OilLitre { get => Lbl_SumOilLitre.Text; set => Lbl_SumOilLitre.Text = value; }
        
        public string ProductSumPrice { get => Lbl_ProdPrice.Text; set => Lbl_ProdPrice.Text = value; }
       
        public string SumPrice { get => Lbl_AllPrice.Text; set => Lbl_AllPrice.Text = value; }
       
        public Color OilPriceColor { set => Txtb_OilPrice.BackColor = value; }
       
        public Color OilLitreColor { set => Txtb_Litre.BackColor = value; }
       
        public List<OilUC.OilUC> Oils { get;  set; }
       
        public List<ProductUC.ProductUC> Products { get; set; }

        public MainView()
        {
            InitializeComponent();
            Oils = new List<OilUC.OilUC>()
            {
                new OilUC.OilUC(new Oil("AI-95", 1.85f)){Dock = DockStyle.Top },
                new OilUC.OilUC(new Oil("AI-92", 1.1f)){Dock = DockStyle.Top },
                new OilUC.OilUC(new Oil("Premium",2.1f)){Dock = DockStyle.Top }
            };
            Oils.ForEach(o => o.MouseClickOil += OilSelected);
            Pnl_Oil.Controls.AddRange(Oils.ToArray());
            Products = new List<ProductUC.ProductUC>
            {
                new ProductUC.ProductUC(new Product("Doner",1.2f)){Dock = DockStyle.Top},
                new ProductUC.ProductUC(new Product("Lahmacun", 2.5f)){Dock = DockStyle.Top}
            };
            Products.ForEach(p => p.NUD_Changed += ProductValueChanged);
            Pnl_Product.Controls.AddRange(Products.ToArray());
            RB_Cash.Checked = true;
        }

        private void ProductValueChanged(object sender, EventArgs e)
        {
            ProductAmountChangeEventHandler.Invoke(sender, e);
        }

        private void OilSelected(object sender, EventArgs e)
        {
            OilSelectChangedEventHandler.Invoke(sender, e);
        }

        private void MainView_Paint(object sender, PaintEventArgs e)
        {
            using (var g = e.Graphics)
            {
                Pen pen = new Pen(Color.White, 2);
                g.DrawLine(pen, this.Width / 2, 0, this.Width / 2, this.Height);
                g.DrawLine(pen, this.Width / 2, (this.Height * 2) / 3 - 30, this.Width, (this.Height * 2) / 3 - 30);
               
            }
        }

        private void Txtb_OilPrice_MouseClick(object sender, MouseEventArgs e)
        {
            OilPriceEventHandler.Invoke(sender, e);
            Txtb_OilPrice.Text = OilPrice;
            Txtb_Litre.Text = string.Empty;
        }

        private void Txtb_Litre_MouseClick(object sender, MouseEventArgs e)
        {
            OilLitreEventHandler.Invoke(sender, e);
            Txtb_Litre.Text = OilLitre;
            Txtb_OilPrice.Text = string.Empty;
        }

        private void Btn_Pay_Click(object sender, EventArgs e)
        {
            if (Lbl_AllPrice.Text != "0")
            {
                Txtb_Litre.Text = string.Empty;
                Txtb_OilPrice.Text = string.Empty;
                PayBtnPressedEventHandler.Invoke(sender, e);
                RB_Cash.Checked = true;
            }
        }
    }
}
