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

namespace BestOil_v2.Views.Main.OilUC
{
    public partial class OilUC : UserControl
    {

        public event EventHandler MouseClickOil;

        public Oil Oil { get; set; }
        public OilUC()
        {
            InitializeComponent();
            this.Tag = "off";
        }

        public OilUC(Oil oil)
        {
            InitializeComponent();
            this.Tag = "off";
            Oil = oil;
            Lbl_Price.Click += Lbl_Click;
            Lbl_OilType.Click += Lbl_Click;
        }

        private void Lbl_Click(object sender, EventArgs e)
        {
            this.Tag = "on";
            if(MouseClickOil != null)
                MouseClickOil.Invoke(sender, e);
        }

        private void OilUC_Paint(object sender, PaintEventArgs e)
        {
            if (Oil != null)
            {
                Lbl_OilType.Text = Oil.OilType;
                Lbl_Price.Text = Oil.OilPrice.ToString();
            }
        }

        public void ChageColor()
        {
            if (Tag == "on")
            {
                Lbl_OilType.BackColor = Color.FromArgb(209, 232, 228);
                Lbl_Price.BackColor = Color.FromArgb(209, 232, 228);
            }
            else
            {
                Lbl_Price.BackColor = Color.FromArgb(249, 249, 249);
                Lbl_OilType.BackColor = Color.FromArgb(249, 249, 249);
            }
        }
    }
}
