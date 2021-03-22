namespace TrainersBackOffice
{
    partial class frmOrders
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.lblManage = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.btnPopulate);
            this.panel1.Controls.Add(this.lstOrders);
            this.panel1.Location = new System.Drawing.Point(381, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 380);
            this.panel1.TabIndex = 0;
            // 
            // lstOrders
            // 
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.ItemHeight = 16;
            this.lstOrders.Location = new System.Drawing.Point(21, 44);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(324, 276);
            this.lstOrders.TabIndex = 1;
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(21, 326);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(324, 42);
            this.btnPopulate.TabIndex = 2;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // lblManage
            // 
            this.lblManage.AutoSize = true;
            this.lblManage.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManage.Location = new System.Drawing.Point(46, 48);
            this.lblManage.Name = "lblManage";
            this.lblManage.Size = new System.Drawing.Size(230, 35);
            this.lblManage.TabIndex = 1;
            this.lblManage.Text = "Manage Orders";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(18, 10);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 3;
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblManage);
            this.Controls.Add(this.panel1);
            this.Name = "frmOrders";
            this.Text = "frmOrders";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.Label lblManage;
        private System.Windows.Forms.Label lblError;
    }
}