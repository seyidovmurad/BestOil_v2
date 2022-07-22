using BestOil_v2.Views.Digits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil_v2.Presenter.Digits
{
    class DigitPresenter
    {

        private readonly IDigitView digit;

        public DigitPresenter(IDigitView digitView)
        {
            digit = digitView;
            digit.DigitEventHandeler += DigitBtnClick;
            digit.DelEventHandeler += DeletBtnClick;
        }

        private void DigitBtnClick(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if(btn.Text == ".")
            {
                if(!digit.NumberOnScreen.Contains(".") && digit.IsDecimal)
                    digit.NumberOnScreen += btn.Text;
            }
            else
            {
                if (digit.NumberOnScreen == "0")
                    digit.NumberOnScreen = btn.Text;
                else
                {
                    if (digit.NumberOnScreen.Contains("."))
                    {
                        if(digit.NumberOnScreen.Split('.')[1].Length < 2)
                            digit.NumberOnScreen += btn.Text;
                    }
                    else if(digit.NumberOnScreen.Length < 3)
                        digit.NumberOnScreen += btn.Text;
                }
            }
        }

        private void DeletBtnClick(object sender,EventArgs e)
        {
            if(digit.NumberOnScreen != "0" && digit.NumberOnScreen.Length != 1)
            {
                digit.NumberOnScreen = digit.NumberOnScreen.Remove(digit.NumberOnScreen.Length - 1);
            }
            else
            {
                digit.NumberOnScreen = "0";
            }
        }
    }
}
