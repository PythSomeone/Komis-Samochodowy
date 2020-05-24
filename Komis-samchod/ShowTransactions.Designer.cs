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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transdatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // transdatagrid
            // 
            this.transdatagrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.transdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transdatagrid.Location = new System.Drawing.Point(24, 30);
            this.transdatagrid.Name = "transdatagrid";
            this.transdatagrid.Size = new System.Drawing.Size(750, 241);
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
            this.cardatagrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.cardatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cardatagrid.Location = new System.Drawing.Point(24, 292);
            this.cardatagrid.Name = "cardatagrid";
            this.cardatagrid.Size = new System.Drawing.Size(750, 88);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(21, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "pojazd:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "transakcje:";
            // 
            // ShowTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView transdatagrid;
        private System.Windows.Forms.Button backtbn;
        private System.Windows.Forms.DataGridView cardatagrid;
        private System.Windows.Forms.Button showcarsbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}