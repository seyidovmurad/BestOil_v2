using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil_v2.Views.Digits
{
    public partial class DigitView : Form, IDigitView
    {
        public EventHandler<EventArgs> DigitEventHandeler { get; set; }

        public EventHandler<EventArgs> DelEventHandeler { get; set; }

        public string NumberOnScreen { get => Lbl_Screen.Text; set => Lbl_Screen.Text = value; }

        public bool IsDecimal { get; set; } = true;

        public DigitView()
        {
            InitializeComponent();
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            DelEventHandeler.Invoke(sender, e);
        }

        private void Btn_Dig_Click(object sender, EventArgs e)
        {
            DigitEventHandeler.Invoke(sender, e);
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            if(!NumberOnScreen.EndsWith(".") && Convert.ToDouble(NumberOnScreen) != 0)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
