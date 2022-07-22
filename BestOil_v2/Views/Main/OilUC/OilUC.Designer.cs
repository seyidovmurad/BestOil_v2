
namespace BestOil_v2.Views.Main.OilUC
{
    partial class OilUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_OilType = new System.Windows.Forms.Label();
            this.Lbl_Price = new System.Windows.Forms.Label();
            this.Line = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_OilType
            // 
            this.Lbl_OilType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Lbl_OilType.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_OilType.Location = new System.Drawing.Point(0, 0);
            this.Lbl_OilType.Name = "Lbl_OilType";
            this.Lbl_OilType.Size = new System.Drawing.Size(145, 25);
            this.Lbl_OilType.TabIndex = 1;
            this.Lbl_OilType.Text = "Oil Type";
            this.Lbl_OilType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Price
            // 
            this.Lbl_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Lbl_Price.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Price.Location = new System.Drawing.Point(147, 0);
            this.Lbl_Price.Name = "Lbl_Price";
            this.Lbl_Price.Size = new System.Drawing.Size(89, 25);
            this.Lbl_Price.TabIndex = 1;
            this.Lbl_Price.Text = "0.00";
            this.Lbl_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Line
            // 
            this.Line.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Line.Location = new System.Drawing.Point(0, 23);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(236, 2);
            this.Line.TabIndex = 2;
            this.Line.Text = "label2";
            // 
            // OilUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.Line);
            this.Controls.Add(this.Lbl_Price);
            this.Controls.Add(this.Lbl_OilType);
            this.Name = "OilUC";
            this.Size = new System.Drawing.Size(236, 25);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OilUC_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_OilType;
        private System.Windows.Forms.Label Lbl_Price;
        private System.Windows.Forms.Label Line;
    }
}
