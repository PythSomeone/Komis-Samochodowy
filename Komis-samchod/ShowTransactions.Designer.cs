namespace Komis_samchod
{
    partial class ShowTransactions
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
            this.transdatagrid = new System.Windows.Forms.DataGridView();
            this.backtbn = new System.Windows.Forms.Button();
            this.cardatagrid = new System.Windows.Forms.DataGridView();
            this.showcarsbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transdatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // transdatagrid
            // 
            this.transdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transdatagrid.Location = new System.Drawing.Point(24, 31);
            this.transdatagrid.Name = "transdatagrid";
            this.transdatagrid.Size = new System.Drawing.Size(750, 160);
            this.transdatagrid.TabIndex = 0;
            // 
            // backtbn
            // 
            this.backtbn.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backtbn.Location = new System.Drawing.Point(616, 398);
            this.backtbn.Name = "backtbn";
            this.backtbn.Size = new System.Drawing.Size(155, 40);
            this.backtbn.TabIndex = 3;
            this.backtbn.Text = "wróć";
            this.backtbn.UseVisualStyleBackColor = true;
            this.backtbn.Click += new System.EventHandler(this.backtbn_Click);
            // 
            // cardatagrid
            // 
            this.cardatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cardatagrid.Location = new System.Drawing.Point(24, 200);
            this.cardatagrid.Name = "cardatagrid";
            this.cardatagrid.Size = new System.Drawing.Size(750, 160);
            this.cardatagrid.TabIndex = 4;
            // 
            // showcarsbtn
            // 
            this.showcarsbtn.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.showcarsbtn.Location = new System.Drawing.Point(24, 398);
            this.showcarsbtn.Name = "showcarsbtn";
            this.showcarsbtn.Size = new System.Drawing.Size(333, 40);
            this.showcarsbtn.TabIndex = 5;
            this.showcarsbtn.Text = "pokaż zaznaczone transakcje";
            this.showcarsbtn.UseVisualStyleBackColor = true;
            this.showcarsbtn.Click += new System.EventHandler(this.showcarsbtn_Click);
            // 
            // ShowTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showcarsbtn);
            this.Controls.Add(this.cardatagrid);
            this.Controls.Add(this.backtbn);
            this.Controls.Add(this.transdatagrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowTransactions";
            this.Text = "ShowTransactions";
            this.Load += new System.EventHandler(this.ShowTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transdatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView transdatagrid;
        private System.Windows.Forms.Button backtbn;
        private System.Windows.Forms.DataGridView cardatagrid;
        private System.Windows.Forms.Button showcarsbtn;
    }
}