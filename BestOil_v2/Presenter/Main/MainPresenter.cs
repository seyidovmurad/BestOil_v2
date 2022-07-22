using BestOil_v2.Presenter.Digits;
using BestOil_v2.Views.Digits;
using BestOil_v2.Views.Main;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BestOil_v2.Presenter.Main
{
    public class MainPresenter
    {
        private readonly IMainView View;

        private float OilPricePlt = 0;

        private float OilPrice = 0;

        private float ProductPrice = 0;

        private bool isPriceSelected = false;

        public MainPresenter(IMainView mainView)
        {
            View = mainView;
            View.OilLitre = string.Empty;
            View.OilPrice = string.Empty;
            View.OilPriceEventHandler += OilPriceTxtChanged;
            View.OilLitreEventHandler += OilLitreTxtChanged;
            View.OilSelectChangedEventHandler += OilSelected;
            View.ProductAmountChangeEventHandler += ProductAmountChanged;
            View.PayBtnPressedEventHandler += PayBtnPressed;
        }

        private void OilLitreTxtChanged(object sender, EventArgs e)
        {
            DigitView digits = new DigitView();
            digits.IsDecimal = false;
            digits.NumberOnScreen = View.OilLitre != string.Empty ? ((int)Convert.ToDouble(View.OilLitre)).ToString() : "0";
            new DigitPresenter(digits);
            if (OilPricePlt == 0)
                MessageBox.Show("First Choose Oil");
            else
            {
                if (digits.ShowDialog() == System.Windows.Forms.DialogResult.OK && OilPricePlt != 0)
                {
                    View.OilLitre = digits.NumberOnScreen;
                    View.OilLitreColor = Color.FromArgb(249, 249, 249);
                    View.OilPriceColor = Color.FromArgb(207, 203, 203);
                    OilPrice = Convert.ToInt32(View.OilLitre) * OilPricePlt;
                    View.OilPrice = OilPrice.ToString("0.##");
                    isPriceSelected = false;
                }
                else
                {
                    View.OilPriceColor = Color.FromArgb(207, 203, 203);
                    View.OilLitreColor = Color.FromArgb(207, 203, 203);
                    View.OilLitre = string.Empty;
                    View.OilPrice = string.Empty;
                    OilPrice = 0;
                }
                View.SumPrice = (OilPrice + ProductPrice).ToString("0.##");
            }
        }

        private void OilPriceTxtChanged(object sender, EventArgs e)
        {
            DigitView digits = new DigitView();
            digits.NumberOnScreen = View.OilPrice != string.Empty ? View.OilPrice : "0";
            new DigitPresenter(digits);
            if (OilPricePlt == 0)
                MessageBox.Show("First Choose Oil");
            else
            {
                if (digits.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    View.OilPrice = digits.NumberOnScreen;
                    OilPrice = (float)Convert.ToDouble(Convert.ToDouble(View.OilPrice));
                    View.OilPriceColor = Color.FromArgb(249, 249, 249);
                    View.OilLitreColor = Color.FromArgb(207, 203, 203);
                    View.OilLitre = ( OilPrice / OilPricePlt).ToString("0.##");
                    isPriceSelected = true;
                }
                else
                {
                    View.OilPriceColor = Color.FromArgb(207, 203, 203);
                    View.OilLitreColor = Color.FromArgb(207, 203, 203);
                    View.OilLitre = string.Empty;
                    View.OilPrice = string.Empty;
                    OilPrice = 0;
                }
                View.SumPrice = (OilPrice + ProductPrice).ToString("0.##");
            }
        }

        private void OilSelected(object sender, EventArgs e)
        {
            OilPricePlt = View.Oils.Find(o => o.Tag == "on").Oil.OilPrice;
            View.Oils.ForEach(o =>
            {
                o.ChageColor();
                o.Tag = "off";
            });
            if (!string.IsNullOrEmpty(View.OilPrice) && isPriceSelected)
            {
                View.OilLitre = (Convert.ToDouble(View.OilPrice) / OilPricePlt).ToString("0.##");
            }
            if (!string.IsNullOrEmpty(View.OilLitre) && !isPriceSelected)
            {
                OilPrice = ((float)Convert.ToDouble(View.OilLitre) * OilPricePlt);
                View.OilPrice = OilPrice.ToString("0.##");
            }
            View.SumPrice = (OilPrice + ProductPrice).ToString("0.##");
        }

        private void ProductAmountChanged(object sender, EventArgs e)
        {
            ProductPrice = 0;
            View.Products.ForEach(a => ProductPrice += a.Product.ProductPrice * a.Product.ProductCount);
            View.ProductSumPrice = ProductPrice.ToString("0.##");
            View.SumPrice = (OilPrice + ProductPrice).ToString("0.##");
        }

        private void PayBtnPressed(object sender,EventArgs e)
        {
            ProductPrice = 0;
            OilPrice = 0;
            OilPricePlt = 0;
            View.OilPrice = string.Empty;
            View.OilLitre = string.Empty;
            View.ProductSumPrice = "0";
            View.SumPrice = "0";
            View.OilLitreColor = View.OilPriceColor = Color.FromArgb(207, 203, 203);
            View.OilPriceColor = View.OilPriceColor = Color.FromArgb(207, 203, 203);
            View.Oils.ForEach(o => o.ChageColor());
            View.Products.ForEach(p => p.ResetProductCount());
            MessageBox.Show("Thank you for choosing us");
        }
    }
}
