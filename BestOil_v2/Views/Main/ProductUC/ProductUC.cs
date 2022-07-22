using BestOil_v2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil_v2.Views.Main.ProductUC
{
    public partial class ProductUC : UserControl
    {
        public event EventHandler NUD_Changed;
        public Product Product { get; set; }
        public ProductUC()
        {
            InitializeComponent();
            NUD_ProductAmount.ValueChanged += NUD_ValueChanged;
        }

        public ProductUC(Product product)
        {
            InitializeComponent();
            Product = product;
            NUD_ProductAmount.ValueChanged += NUD_ValueChanged;
        }

        private void ProductUC_Paint(object sender, PaintEventArgs e)
        {
            if (Product != null)
            {
                Lbl_Price.Text = Product.ProductPrice.ToString();
                Lbl_ProductName.Text = Product.ProductName;
                NUD_ProductAmount.Value = Product.ProductCount;
            }
        }

        public void ResetProductCount()
        {
            NUD_ProductAmount.Value = 0;
            Product.ProductCount = 0;
        }
        private void NUD_ValueChanged(object sender, EventArgs e)
        {
            Product.ProductCount = (int)NUD_ProductAmount.Value;
            if (NUD_Changed != null)
                NUD_Changed.Invoke(sender, e);
        }
    }
}
