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
            this.btnFilterStatus = new System.Windows.Forms.Button();
            this.txtOrderStatusFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFilterCustomerID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerIDFilter = new System.Windows.Forms.TextBox();
            this.btnFiterID = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtFilterID = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.lblManage = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDeliveryTown = new System.Windows.Forms.Label();
            this.txtDeliveryTown = new System.Windows.Forms.TextBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtOrderValue = new System.Windows.Forms.TextBox();
            this.txtOrderStatus = new System.Windows.Forms.TextBox();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.lblOrderValue = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblError1 = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnFilterStatus);
            this.panel1.Controls.Add(this.txtOrderStatusFilter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnFilterCustomerID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCustomerIDFilter);
            this.panel1.Controls.Add(this.btnFiterID);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.txtFilterID);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.btnPopulate);
            this.panel1.Controls.Add(this.lstOrders);
            this.panel1.Location = new System.Drawing.Point(381, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 380);
            this.panel1.TabIndex = 0;
            // 
            // btnFilterStatus
            // 
            this.btnFilterStatus.Location = new System.Drawing.Point(239, 287);
            this.btnFilterStatus.Name = "btnFilterStatus";
            this.btnFilterStatus.Size = new System.Drawing.Size(75, 23);
            this.btnFilterStatus.TabIndex = 13;
            this.btnFilterStatus.Text = "Filter";
            this.btnFilterStatus.UseVisualStyleBackColor = true;
            this.btnFilterStatus.Click += new System.EventHandler(this.btnFilterStatus_Click);
            // 
            // txtOrderStatusFilter
            // 
            this.txtOrderStatusFilter.Location = new System.Drawing.Point(207, 254);
            this.txtOrderStatusFilter.Name = "txtOrderStatusFilter";
            this.txtOrderStatusFilter.Size = new System.Drawing.Size(161, 22);
            this.txtOrderStatusFilter.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Filter by Order Status: ";
            // 
            // btnFilterCustomerID
            // 
            this.btnFilterCustomerID.Location = new System.Drawing.Point(239, 189);
            this.btnFilterCustomerID.Name = "btnFilterCustomerID";
            this.btnFilterCustomerID.Size = new System.Drawing.Size(75, 23);
            this.btnFilterCustomerID.TabIndex = 10;
            this.btnFilterCustomerID.Text = "Filter";
            this.btnFilterCustomerID.UseVisualStyleBackColor = true;
            this.btnFilterCustomerID.Click += new System.EventHandler(this.btnFilterCustomerID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filter by Customer ID:";
            // 
            // txtCustomerIDFilter
            // 
            this.txtCustomerIDFilter.Location = new System.Drawing.Point(207, 161);
            this.txtCustomerIDFilter.Name = "txtCustomerIDFilter";
            this.txtCustomerIDFilter.Size = new System.Drawing.Size(161, 22);
            this.txtCustomerIDFilter.TabIndex = 8;
            // 
            // btnFiterID
            // 
            this.btnFiterID.Location = new System.Drawing.Point(239, 101);
            this.btnFiterID.Name = "btnFiterID";
            this.btnFiterID.Size = new System.Drawing.Size(75, 23);
            this.btnFiterID.TabIndex = 7;
            this.btnFiterID.Text = "Filter";
            this.btnFiterID.UseVisualStyleBackColor = true;
            this.btnFiterID.Click += new System.EventHandler(this.btnFiterID_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(207, 44);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(157, 17);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "Filter by Order Number:";
            // 
            // txtFilterID
            // 
            this.txtFilterID.Location = new System.Drawing.Point(207, 72);
            this.txtFilterID.Name = "txtFilterID";
            this.txtFilterID.Size = new System.Drawing.Size(161, 22);
            this.txtFilterID.TabIndex = 5;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(195, 326);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 42);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(18, 10);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 3;
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(21, 326);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(150, 42);
            this.btnPopulate.TabIndex = 2;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // lstOrders
            // 
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.ItemHeight = 16;
            this.lstOrders.Location = new System.Drawing.Point(3, 44);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(176, 276);
            this.lstOrders.TabIndex = 1;
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
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(52, 97);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(89, 17);
            this.lblCustomerID.TabIndex = 2;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(176, 97);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(132, 22);
            this.txtCustomerID.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(52, 125);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(106, 17);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email Address: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(176, 125);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // lblDeliveryTown
            // 
            this.lblDeliveryTown.AutoSize = true;
            this.lblDeliveryTown.Location = new System.Drawing.Point(52, 155);
            this.lblDeliveryTown.Name = "lblDeliveryTown";
            this.lblDeliveryTown.Size = new System.Drawing.Size(105, 17);
            this.lblDeliveryTown.TabIndex = 6;
            this.lblDeliveryTown.Text = "Delivery Town: ";
            // 
            // txtDeliveryTown
            // 
            this.txtDeliveryTown.Location = new System.Drawing.Point(176, 155);
            this.txtDeliveryTown.Name = "txtDeliveryTown";
            this.txtDeliveryTown.Size = new System.Drawing.Size(132, 22);
            this.txtDeliveryTown.TabIndex = 7;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(49, 186);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(87, 17);
            this.lblOrderDate.TabIndex = 8;
            this.lblOrderDate.Text = "Order Date: ";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(176, 186);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(132, 22);
            this.txtOrderDate.TabIndex = 9;
            // 
            // txtOrderValue
            // 
            this.txtOrderValue.Location = new System.Drawing.Point(176, 215);
            this.txtOrderValue.Name = "txtOrderValue";
            this.txtOrderValue.Size = new System.Drawing.Size(132, 22);
            this.txtOrderValue.TabIndex = 10;
            // 
            // txtOrderStatus
            // 
            this.txtOrderStatus.Location = new System.Drawing.Point(176, 244);
            this.txtOrderStatus.Name = "txtOrderStatus";
            this.txtOrderStatus.Size = new System.Drawing.Size(132, 22);
            this.txtOrderStatus.TabIndex = 11;
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Location = new System.Drawing.Point(49, 215);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(93, 17);
            this.lblOrderStatus.TabIndex = 12;
            this.lblOrderStatus.Text = "Order Value: ";
            // 
            // lblOrderValue
            // 
            this.lblOrderValue.AutoSize = true;
            this.lblOrderValue.Location = new System.Drawing.Point(52, 244);
            this.lblOrderValue.Name = "lblOrderValue";
            this.lblOrderValue.Size = new System.Drawing.Size(97, 17);
            this.lblOrderValue.TabIndex = 13;
            this.lblOrderValue.Text = "Order Status: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(52, 292);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 43);
            this.panel2.TabIndex = 14;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(208, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(107, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblError1
            // 
            this.lblError1.AutoSize = true;
            this.lblError1.Location = new System.Drawing.Point(52, 342);
            this.lblError1.Name = "lblError1";
            this.lblError1.Size = new System.Drawing.Size(0, 17);
            this.lblError1.TabIndex = 15;
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(90, 382);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 16;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(194, 382);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 17;
            this.btnYes.Text = "YES";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 34);
            this.button1.TabIndex = 28;
            this.button1.Text = "Back to main page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.lblError1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblOrderValue);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.txtOrderStatus);
            this.Controls.Add(this.txtOrderValue);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.txtDeliveryTown);
            this.Controls.Add(this.lblDeliveryTown);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblManage);
            this.Controls.Add(this.panel1);
            this.Name = "frmOrders";
            this.Text = "frmOrders";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.Label lblManage;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDeliveryTown;
        private System.Windows.Forms.TextBox txtDeliveryTown;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtOrderValue;
        private System.Windows.Forms.TextBox txtOrderStatus;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.Label lblOrderValue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblError1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnFiterID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtFilterID;
        private System.Windows.Forms.Button btnFilterCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerIDFilter;
        private System.Windows.Forms.Button btnFilterStatus;
        private System.Windows.Forms.TextBox txtOrderStatusFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}