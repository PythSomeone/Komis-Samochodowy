namespace Komis_samchod
{
    partial class MainUserPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUserPage));
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.logout = new System.Windows.Forms.Button();
            this.browsecars = new System.Windows.Forms.Button();
            this.sell = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.welcomemessage = new System.Windows.Forms.Label();
            this.showtrans = new System.Windows.Forms.Button();
            this.sendoffer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.sendoffer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.showtrans, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.browsecars, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sell, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.logout, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 129);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1068, 388);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // logout
            // 
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logout.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(715, 198);
            this.logout.Margin = new System.Windows.Forms.Padding(4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(348, 186);
            this.logout.TabIndex = 2;
            this.logout.Text = "wyloguj";
            this.logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // browsecars
            // 
            this.browsecars.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.browsecars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browsecars.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browsecars.Image = ((System.Drawing.Image)(resources.GetObject("browsecars.Image")));
            this.browsecars.Location = new System.Drawing.Point(4, 4);
            this.browsecars.Margin = new System.Windows.Forms.Padding(4);
            this.browsecars.Name = "browsecars";
            this.browsecars.Size = new System.Drawing.Size(327, 186);
            this.browsecars.TabIndex = 0;
            this.browsecars.Text = "znajdź pojazd";
            this.browsecars.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.browsecars.UseVisualStyleBackColor = true;
            this.browsecars.Click += new System.EventHandler(this.browsecars_Click);
            // 
            // sell
            // 
            this.sell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sell.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.sell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sell.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sell.ForeColor = System.Drawing.Color.Black;
            this.sell.Image = ((System.Drawing.Image)(resources.GetObject("sell.Image")));
            this.sell.Location = new System.Drawing.Point(359, 4);
            this.sell.Margin = new System.Windows.Forms.Padding(4);
            this.sell.Name = "sell";
            this.sell.Size = new System.Drawing.Size(347, 186);
            this.sell.TabIndex = 1;
            this.sell.Text = "sprzedaj pojazd";
            this.sell.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sell.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.welcomemessage, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1068, 100);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // welcomemessage
            // 
            this.welcomemessage.Font = new System.Drawing.Font("Unispace", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomemessage.Location = new System.Drawing.Point(3, 0);
            this.welcomemessage.Name = "welcomemessage";
            this.welcomemessage.Size = new System.Drawing.Size(1062, 83);
            this.welcomemessage.TabIndex = 4;
            this.welcomemessage.Text = "Witaj";
            this.welcomemessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcomemessage.Click += new System.EventHandler(this.welcomemessage_Click);
            // 
            // showtrans
            // 
            this.showtrans.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.showtrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showtrans.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtrans.Image = ((System.Drawing.Image)(resources.GetObject("showtrans.Image")));
            this.showtrans.Location = new System.Drawing.Point(715, 4);
            this.showtrans.Margin = new System.Windows.Forms.Padding(4);
            this.showtrans.Name = "showtrans";
            this.showtrans.Size = new System.Drawing.Size(327, 186);
            this.showtrans.TabIndex = 3;
            this.showtrans.Text = "pokaż transakcje";
            this.showtrans.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.showtrans.UseVisualStyleBackColor = true;
            // 
            // sendoffer
            // 
            this.sendoffer.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.sendoffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendoffer.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendoffer.Image = ((System.Drawing.Image)(resources.GetObject("sendoffer.Image")));
            this.sendoffer.Location = new System.Drawing.Point(4, 198);
            this.sendoffer.Margin = new System.Windows.Forms.Padding(4);
            this.sendoffer.Name = "sendoffer";
            this.sendoffer.Size = new System.Drawing.Size(327, 186);
            this.sendoffer.TabIndex = 4;
            this.sendoffer.Text = "złóż ofertę";
            this.sendoffer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sendoffer.UseVisualStyleBackColor = true;
            this.sendoffer.Click += new System.EventHandler(this.sendoffer_Click);
            // 
            // MainUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1066, 519);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainUserPage";
            this.Text = "MainUserPage";
            this.Load += new System.EventHandler(this.MainUserPage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button browsecars;
        private System.Windows.Forms.Button sell;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label welcomemessage;
        private System.Windows.Forms.Button sendoffer;
        private System.Windows.Forms.Button showtrans;
    }
}