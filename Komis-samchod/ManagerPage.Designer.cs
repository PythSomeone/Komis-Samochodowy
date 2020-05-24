namespace Komis_samchod
{
    partial class ManagerPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerPage));
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.browsecars = new System.Windows.Forms.Button();
            this.addcarbtn = new System.Windows.Forms.Button();
            this.acceptcarsbtn = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.welcomemessage = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.browsecars, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.addcarbtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.acceptcarsbtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.logout, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 147);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1065, 370);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // browsecars
            // 
            this.browsecars.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.browsecars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browsecars.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browsecars.Image = ((System.Drawing.Image)(resources.GetObject("browsecars.Image")));
            this.browsecars.Location = new System.Drawing.Point(4, 189);
            this.browsecars.Margin = new System.Windows.Forms.Padding(4);
            this.browsecars.Name = "browsecars";
            this.browsecars.Size = new System.Drawing.Size(327, 177);
            this.browsecars.TabIndex = 3;
            this.browsecars.Text = "znajdź pojazd";
            this.browsecars.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.browsecars.UseVisualStyleBackColor = true;
            this.browsecars.Click += new System.EventHandler(this.browsecars_Click);
            // 
            // addcarbtn
            // 
            this.addcarbtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.addcarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addcarbtn.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcarbtn.Image = ((System.Drawing.Image)(resources.GetObject("addcarbtn.Image")));
            this.addcarbtn.Location = new System.Drawing.Point(4, 4);
            this.addcarbtn.Margin = new System.Windows.Forms.Padding(4);
            this.addcarbtn.Name = "addcarbtn";
            this.addcarbtn.Size = new System.Drawing.Size(327, 177);
            this.addcarbtn.TabIndex = 0;
            this.addcarbtn.Text = "dodaj pojazd";
            this.addcarbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addcarbtn.UseVisualStyleBackColor = true;
            // 
            // acceptcarsbtn
            // 
            this.acceptcarsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.acceptcarsbtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.acceptcarsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptcarsbtn.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptcarsbtn.ForeColor = System.Drawing.Color.Black;
            this.acceptcarsbtn.Image = ((System.Drawing.Image)(resources.GetObject("acceptcarsbtn.Image")));
            this.acceptcarsbtn.Location = new System.Drawing.Point(359, 4);
            this.acceptcarsbtn.Margin = new System.Windows.Forms.Padding(4);
            this.acceptcarsbtn.Name = "acceptcarsbtn";
            this.acceptcarsbtn.Size = new System.Drawing.Size(347, 177);
            this.acceptcarsbtn.TabIndex = 1;
            this.acceptcarsbtn.Text = "zarządzaj ofertami";
            this.acceptcarsbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.acceptcarsbtn.UseVisualStyleBackColor = true;
            this.acceptcarsbtn.Click += new System.EventHandler(this.acceptcarsbtn_Click);
            // 
            // logout
            // 
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logout.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(714, 189);
            this.logout.Margin = new System.Windows.Forms.Padding(4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(347, 177);
            this.logout.TabIndex = 2;
            this.logout.Text = "wyloguj";
            this.logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
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
            // ManagerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1066, 519);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagerPage";
            this.Text = "ManagerPage";
            this.Load += new System.EventHandler(this.ManagerPage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button addcarbtn;
        private System.Windows.Forms.Button acceptcarsbtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label welcomemessage;
        private System.Windows.Forms.Button browsecars;
    }
}