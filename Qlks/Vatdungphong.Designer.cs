namespace Qlks
{
    partial class Vatdungphong
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_VatDung = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VatDung)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_VatDung
            // 
            this.dgv_VatDung.AllowUserToAddRows = false;
            this.dgv_VatDung.AllowUserToDeleteRows = false;
            this.dgv_VatDung.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_VatDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VatDung.Location = new System.Drawing.Point(0, 72);
            this.dgv_VatDung.Name = "dgv_VatDung";
            this.dgv_VatDung.Size = new System.Drawing.Size(809, 150);
            this.dgv_VatDung.TabIndex = 0;
            this.dgv_VatDung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_VatDung_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin vật dụng ";
            // 
            // Vatdungphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 223);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_VatDung);
            this.Name = "Vatdungphong";
            this.Text = "Vatdungphong";
            this.Load += new System.EventHandler(this.Vatdungphong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VatDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_VatDung;
        private System.Windows.Forms.Label label1;
    }
}