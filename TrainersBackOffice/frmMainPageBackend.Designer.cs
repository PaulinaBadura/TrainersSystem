namespace TrainersBackOffice
{
    partial class frmMainPageBackend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPageBackend));
            this.btnManageCustomers = new System.Windows.Forms.Button();
            this.btnManageOrders = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOrderLine = new System.Windows.Forms.Button();
            this.btnTrainers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageCustomers
            // 
            this.btnManageCustomers.Location = new System.Drawing.Point(161, 119);
            this.btnManageCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new System.Drawing.Size(178, 35);
            this.btnManageCustomers.TabIndex = 0;
            this.btnManageCustomers.Text = "Manage Customers";
            this.btnManageCustomers.UseVisualStyleBackColor = true;
            this.btnManageCustomers.Click += new System.EventHandler(this.btnManageCustomers_Click);
            // 
            // btnManageOrders
            // 
            this.btnManageOrders.Location = new System.Drawing.Point(161, 164);
            this.btnManageOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageOrders.Name = "btnManageOrders";
            this.btnManageOrders.Size = new System.Drawing.Size(178, 37);
            this.btnManageOrders.TabIndex = 1;
            this.btnManageOrders.Text = "Manage Orders";
            this.btnManageOrders.UseVisualStyleBackColor = true;
            this.btnManageOrders.Click += new System.EventHandler(this.btnManageOrders_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 93);
            this.panel1.TabIndex = 2;
            // 
            // btnOrderLine
            // 
            this.btnOrderLine.Location = new System.Drawing.Point(161, 214);
            this.btnOrderLine.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderLine.Name = "btnOrderLine";
            this.btnOrderLine.Size = new System.Drawing.Size(178, 37);
            this.btnOrderLine.TabIndex = 3;
            this.btnOrderLine.Text = "Manage OrderLine";
            this.btnOrderLine.UseVisualStyleBackColor = true;
            this.btnOrderLine.Click += new System.EventHandler(this.btnOrderLine_Click);
            // 
            // btnTrainers
            // 
            this.btnTrainers.Location = new System.Drawing.Point(161, 268);
            this.btnTrainers.Name = "btnTrainers";
            this.btnTrainers.Size = new System.Drawing.Size(178, 38);
            this.btnTrainers.TabIndex = 4;
            this.btnTrainers.Text = "Manage Trainers";
            this.btnTrainers.UseVisualStyleBackColor = true;
            this.btnTrainers.Click += new System.EventHandler(this.btnTrainers_Click);
            // 
            // frmMainPageBackend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 343);
            this.Controls.Add(this.btnTrainers);
            this.Controls.Add(this.btnOrderLine);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnManageOrders);
            this.Controls.Add(this.btnManageCustomers);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMainPageBackend";
            this.Text = "frmMainPageBackend";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageCustomers;
        private System.Windows.Forms.Button btnManageOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOrderLine;
        private System.Windows.Forms.Button btnTrainers;
    }
}