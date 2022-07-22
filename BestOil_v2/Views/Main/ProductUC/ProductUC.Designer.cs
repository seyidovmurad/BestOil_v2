
namespace BestOil_v2.Views.Main.ProductUC
{
    partial class ProductUC
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
            this.Lbl_ProductName = new System.Windows.Forms.Label();
            this.Lbl_Price = new System.Windows.Forms.Label();
            this.Lbl_Bckgnd = new System.Windows.Forms.Label();
            this.NUD_ProductAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_ProductAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_ProductName
            // 
            this.Lbl_ProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Lbl_ProductName.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ProductName.Location = new System.Drawing.Point(0, 0);
            this.Lbl_ProductName.Name = "Lbl_ProductName";
            this.Lbl_ProductName.Size = new System.Drawing.Size(117, 25);
            this.Lbl_ProductName.TabIndex = 0;
            this.Lbl_ProductName.Text = "Product";
            this.Lbl_ProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Price
            // 
            this.Lbl_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Lbl_Price.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Price.Location = new System.Drawing.Point(119, 0);
            this.Lbl_Price.Name = "Lbl_Price";
            this.Lbl_Price.Size = new System.Drawing.Size(69, 25);
            this.Lbl_Price.TabIndex = 0;
            this.Lbl_Price.Text = "0.00";
            this.Lbl_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Bckgnd
            // 
            this.Lbl_Bckgnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Lbl_Bckgnd.Location = new System.Drawing.Point(190, 0);
            this.Lbl_Bckgnd.Name = "Lbl_Bckgnd";
            this.Lbl_Bckgnd.Size = new System.Drawing.Size(87, 25);
            this.Lbl_Bckgnd.TabIndex = 0;
            this.Lbl_Bckgnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NUD_ProductAmount
            // 
            this.NUD_ProductAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NUD_ProductAmount.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_ProductAmount.Location = new System.Drawing.Point(200, -1);
            this.NUD_ProductAmount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUD_ProductAmount.Name = "NUD_ProductAmount";
            this.NUD_ProductAmount.ReadOnly = true;
            this.NUD_ProductAmount.Size = new System.Drawing.Size(50, 25);
            this.NUD_ProductAmount.TabIndex = 1;
            this.NUD_ProductAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 2);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // ProductUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUD_ProductAmount);
            this.Controls.Add(this.Lbl_Bckgnd);
            this.Controls.Add(this.Lbl_Price);
            this.Controls.Add(this.Lbl_ProductName);
            this.Name = "ProductUC";
            this.Size = new System.Drawing.Size(277, 25);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ProductUC_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_ProductAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ProductName;
        private System.Windows.Forms.Label Lbl_Price;
        private System.Windows.Forms.Label Lbl_Bckgnd;
        private System.Windows.Forms.NumericUpDown NUD_ProductAmount;
        private System.Windows.Forms.Label label1;
    }
}
