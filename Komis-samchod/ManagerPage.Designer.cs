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
            this.logout = new System.Windows.Forms.Button();
            this.addcar = new System.Windows.Forms.Button();
            this.sell = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.logout, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.addcar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sell, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 308);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1068, 209);
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
            this.logout.Location = new System.Drawing.Point(716, 4);
            this.logout.Margin = new System.Windows.Forms.Padding(4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(348, 201);
            this.logout.TabIndex = 2;
            this.logout.Text = "wyloguj";
            this.logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // addcar
            // 
            this.addcar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.addcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addcar.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcar.Image = ((System.Drawing.Image)(resources.GetObject("addcar.Image")));
            this.addcar.Location = new System.Drawing.Point(4, 4);
            this.addcar.Margin = new System.Windows.Forms.Padding(4);
            this.addcar.Name = "addcar";
            this.addcar.Size = new System.Drawing.Size(327, 201);
            this.addcar.TabIndex = 0;
            this.addcar.Text = "dodaj pojazd";
            this.addcar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addcar.UseVisualStyleBackColor = true;
            // 
            // sell
            // 
            this.sell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sell.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.sell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sell.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sell.ForeColor = System.Drawing.Color.Black;
            this.sell.Image = ((System.Drawing.Image)(resources.GetObject("sell.Image")));
            this.sell.Location = new System.Drawing.Point(360, 4);
            this.sell.Margin = new System.Windows.Forms.Padding(4);
            this.sell.Name = "sell";
            this.sell.Size = new System.Drawing.Size(347, 201);
            this.sell.TabIndex = 1;
            this.sell.Text = "zarządzaj ofertami";
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
        private System.Windows.Forms.Button addcar;
        private System.Windows.Forms.Button sell;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label welcomemessage;
    }
}