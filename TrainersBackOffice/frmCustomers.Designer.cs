namespace TrainersBackOffice
{
	partial class frmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomers));
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblHouseNo = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.txtHouseNo = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblError2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            resources.ApplyResources(this.lstCustomers, "lstCustomers");
            this.lstCustomers.Name = "lstCustomers";
            // 
            // btnPopulate
            // 
            resources.ApplyResources(this.btnPopulate, "btnPopulate");
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // lblError
            // 
            resources.ApplyResources(this.lblError, "lblError");
            this.lblError.Name = "lblError";
            // 
            // lblFirstName
            // 
            resources.ApplyResources(this.lblFirstName, "lblFirstName");
            this.lblFirstName.Name = "lblFirstName";
            // 
            // lblLastName
            // 
            resources.ApplyResources(this.lblLastName, "lblLastName");
            this.lblLastName.Name = "lblLastName";
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.Name = "lblPassword";
            // 
            // lblDateOfBirth
            // 
            resources.ApplyResources(this.lblDateOfBirth, "lblDateOfBirth");
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            // 
            // lblHouseNo
            // 
            resources.ApplyResources(this.lblHouseNo, "lblHouseNo");
            this.lblHouseNo.Name = "lblHouseNo";
            // 
            // lblStreet
            // 
            resources.ApplyResources(this.lblStreet, "lblStreet");
            this.lblStreet.Name = "lblStreet";
            // 
            // lblTown
            // 
            resources.ApplyResources(this.lblTown, "lblTown");
            this.lblTown.Name = "lblTown";
            // 
            // lblPostCode
            // 
            resources.ApplyResources(this.lblPostCode, "lblPostCode");
            this.lblPostCode.Name = "lblPostCode";
            // 
            // txtFirstName
            // 
            resources.ApplyResources(this.txtFirstName, "txtFirstName");
            this.txtFirstName.Name = "txtFirstName";
            // 
            // txtLastName
            // 
            resources.ApplyResources(this.txtLastName, "txtLastName");
            this.txtLastName.Name = "txtLastName";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            // 
            // txtDateOfBirth
            // 
            resources.ApplyResources(this.txtDateOfBirth, "txtDateOfBirth");
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            // 
            // txtHouseNo
            // 
            resources.ApplyResources(this.txtHouseNo, "txtHouseNo");
            this.txtHouseNo.Name = "txtHouseNo";
            // 
            // txtStreet
            // 
            resources.ApplyResources(this.txtStreet, "txtStreet");
            this.txtStreet.Name = "txtStreet";
            // 
            // txtTown
            // 
            resources.ApplyResources(this.txtTown, "txtTown");
            this.txtTown.Name = "txtTown";
            // 
            // txtPostCode
            // 
            resources.ApplyResources(this.txtPostCode, "txtPostCode");
            this.txtPostCode.Name = "txtPostCode";
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblError2
            // 
            resources.ApplyResources(this.lblError2, "lblError2");
            this.lblError2.Name = "lblError2";
            // 
            // frmCustomers
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblError2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPostCode);
            this.Controls.Add(this.txtTown);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtHouseNo);
            this.Controls.Add(this.txtDateOfBirth);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblPostCode);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblHouseNo);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.lstCustomers);
            this.Name = "frmCustomers";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblHouseNo;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.TextBox txtHouseNo;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblError2;
    }
}

