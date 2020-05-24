namespace Komis_samchod
{
    partial class AccountDetails
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.savebtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.clientgrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.clientgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(145, 280);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(412, 23);
            this.savebtn.TabIndex = 2;
            this.savebtn.Text = "zapisz zmiany";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(688, 280);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(233, 23);
            this.backbtn.TabIndex = 3;
            this.backbtn.Text = "wróć";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // clientgrid
            // 
            this.clientgrid.AllowUserToAddRows = false;
            this.clientgrid.Location = new System.Drawing.Point(145, 45);
            this.clientgrid.Name = "clientgrid";
            this.clientgrid.Size = new System.Drawing.Size(776, 179);
            this.clientgrid.TabIndex = 1;
            // 
            // AccountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1066, 360);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.clientgrid);
            this.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AccountDetails";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AccountDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.DataGridView clientgrid;
    }
}

