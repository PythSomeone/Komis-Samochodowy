namespace Komis_samchod
{
    partial class ConfirmPurchase
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
            this.cartobuygrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.yesbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cartobuygrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cartobuygrid
            // 
            this.cartobuygrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.cartobuygrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartobuygrid.Location = new System.Drawing.Point(25, 45);
            this.cartobuygrid.Name = "cartobuygrid";
            this.cartobuygrid.Size = new System.Drawing.Size(751, 86);
            this.cartobuygrid.TabIndex = 0;
            this.cartobuygrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartobuygrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(228, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "czy na pewno chcesz dokonać zakupu?";
            // 
            // yesbtn
            // 
            this.yesbtn.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yesbtn.Location = new System.Drawing.Point(231, 181);
            this.yesbtn.Name = "yesbtn";
            this.yesbtn.Size = new System.Drawing.Size(154, 23);
            this.yesbtn.TabIndex = 2;
            this.yesbtn.Text = "tak";
            this.yesbtn.UseVisualStyleBackColor = true;
            this.yesbtn.Click += new System.EventHandler(this.yesbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backbtn.Location = new System.Drawing.Point(391, 181);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(160, 23);
            this.backbtn.TabIndex = 3;
            this.backbtn.Text = "wróć";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // ConfirmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 239);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.yesbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cartobuygrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmPurchase";
            this.Text = "ConfirmPurchase";
            this.Load += new System.EventHandler(this.ConfirmPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartobuygrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView cartobuygrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yesbtn;
        private System.Windows.Forms.Button backbtn;
    }
}