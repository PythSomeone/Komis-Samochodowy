namespace Komis_samchod
{
    partial class AcceptCars
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
            this.cardatagrid = new System.Windows.Forms.DataGridView();
            this.showcarsbtn = new System.Windows.Forms.Button();
            this.backtbn = new System.Windows.Forms.Button();
            this.acceptbtn = new System.Windows.Forms.Button();
            this.declinebtn = new System.Windows.Forms.Button();
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
            this.transdatagrid.TabIndex = 1;
            // 
            // cardatagrid
            // 
            this.cardatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cardatagrid.Location = new System.Drawing.Point(24, 200);
            this.cardatagrid.Name = "cardatagrid";
            this.cardatagrid.Size = new System.Drawing.Size(750, 160);
            this.cardatagrid.TabIndex = 5;
            // 
            // showcarsbtn
            // 
            this.showcarsbtn.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.showcarsbtn.Location = new System.Drawing.Point(24, 398);
            this.showcarsbtn.Name = "showcarsbtn";
            this.showcarsbtn.Size = new System.Drawing.Size(232, 40);
            this.showcarsbtn.TabIndex = 6;
            this.showcarsbtn.Text = "pokaż zaznaczone transakcje";
            this.showcarsbtn.UseVisualStyleBackColor = true;
            this.showcarsbtn.Click += new System.EventHandler(this.showcarsbtn_Click);
            // 
            // backtbn
            // 
            this.backtbn.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backtbn.Location = new System.Drawing.Point(619, 398);
            this.backtbn.Name = "backtbn";
            this.backtbn.Size = new System.Drawing.Size(155, 40);
            this.backtbn.TabIndex = 7;
            this.backtbn.Text = "wróć";
            this.backtbn.UseVisualStyleBackColor = true;
            this.backtbn.Click += new System.EventHandler(this.backtbn_Click);
            // 
            // acceptbtn
            // 
            this.acceptbtn.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.acceptbtn.Location = new System.Drawing.Point(311, 398);
            this.acceptbtn.Name = "acceptbtn";
            this.acceptbtn.Size = new System.Drawing.Size(114, 40);
            this.acceptbtn.TabIndex = 8;
            this.acceptbtn.Text = "akceptuj";
            this.acceptbtn.UseVisualStyleBackColor = true;
            this.acceptbtn.Click += new System.EventHandler(this.acceptbtn_Click);
            // 
            // declinebtn
            // 
            this.declinebtn.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.declinebtn.Location = new System.Drawing.Point(452, 398);
            this.declinebtn.Name = "declinebtn";
            this.declinebtn.Size = new System.Drawing.Size(115, 40);
            this.declinebtn.TabIndex = 9;
            this.declinebtn.Text = "odrzuć";
            this.declinebtn.UseVisualStyleBackColor = true;
            this.declinebtn.Click += new System.EventHandler(this.declinebtn_Click);
            // 
            // AcceptCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.declinebtn);
            this.Controls.Add(this.acceptbtn);
            this.Controls.Add(this.backtbn);
            this.Controls.Add(this.showcarsbtn);
            this.Controls.Add(this.cardatagrid);
            this.Controls.Add(this.transdatagrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AcceptCars";
            this.Text = "AcceptCars";
            this.Load += new System.EventHandler(this.AcceptCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transdatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView transdatagrid;
        private System.Windows.Forms.DataGridView cardatagrid;
        private System.Windows.Forms.Button showcarsbtn;
        private System.Windows.Forms.Button backtbn;
        private System.Windows.Forms.Button acceptbtn;
        private System.Windows.Forms.Button declinebtn;
    }
}