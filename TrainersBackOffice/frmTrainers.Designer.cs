namespace TrainersBackOffice
{
    partial class frmTrainers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrainers));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblManage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDateAdded = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtDateAdded = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.lblColour = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblInStock = new System.Windows.Forms.Label();
            this.chkInStock = new System.Windows.Forms.CheckBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFilterError = new System.Windows.Forms.Label();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnFilterSize = new System.Windows.Forms.Button();
            this.txtFilterSize = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblFilterSize = new System.Windows.Forms.Label();
            this.btnFilterColour = new System.Windows.Forms.Button();
            this.lblFilterColour = new System.Windows.Forms.Label();
            this.txtFilterColour = new System.Windows.Forms.TextBox();
            this.btnFilterBrand = new System.Windows.Forms.Button();
            this.lblFilterBrand = new System.Windows.Forms.Label();
            this.txtFilterBrand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstTrainers = new System.Windows.Forms.ListBox();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.btnHome);
            this.panel4.Location = new System.Drawing.Point(11, 11);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(645, 109);
            this.panel4.TabIndex = 40;
            // 
            // btnHome
            // 
            this.btnHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHome.Location = new System.Drawing.Point(7, 8);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(67, 23);
            this.btnHome.TabIndex = 44;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblManage
            // 
            this.lblManage.AutoSize = true;
            this.lblManage.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManage.Location = new System.Drawing.Point(13, 138);
            this.lblManage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManage.Name = "lblManage";
            this.lblManage.Size = new System.Drawing.Size(195, 28);
            this.lblManage.TabIndex = 41;
            this.lblManage.Text = "Manage Trainers";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(59, 390);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 35);
            this.panel2.TabIndex = 54;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(80, 3);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(61, 19);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 19);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(93, 212);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 22);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblDateAdded
            // 
            this.lblDateAdded.AutoSize = true;
            this.lblDateAdded.Location = new System.Drawing.Point(18, 303);
            this.lblDateAdded.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateAdded.Name = "lblDateAdded";
            this.lblDateAdded.Size = new System.Drawing.Size(67, 13);
            this.lblDateAdded.TabIndex = 53;
            this.lblDateAdded.Text = "DateAdded: ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(18, 277);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(37, 13);
            this.lblPrice.TabIndex = 52;
            this.lblPrice.Text = "Price: ";
            // 
            // txtDateAdded
            // 
            this.txtDateAdded.Location = new System.Drawing.Point(110, 300);
            this.txtDateAdded.Margin = new System.Windows.Forms.Padding(2);
            this.txtDateAdded.Name = "txtDateAdded";
            this.txtDateAdded.Size = new System.Drawing.Size(100, 20);
            this.txtDateAdded.TabIndex = 51;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(110, 277);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 50;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(18, 253);
            this.lblSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(33, 13);
            this.lblSize.TabIndex = 48;
            this.lblSize.Text = "Size: ";
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(110, 228);
            this.txtColour.Margin = new System.Windows.Forms.Padding(2);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(100, 20);
            this.txtColour.TabIndex = 47;
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(17, 231);
            this.lblColour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(43, 13);
            this.lblColour.TabIndex = 46;
            this.lblColour.Text = "Colour: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 204);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 45;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 207);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 44;
            this.lblName.Text = "Name: ";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(110, 181);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 20);
            this.txtBrand.TabIndex = 43;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(17, 184);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(38, 13);
            this.lblBrand.TabIndex = 42;
            this.lblBrand.Text = "Brand:";
            // 
            // lblInStock
            // 
            this.lblInStock.AutoSize = true;
            this.lblInStock.Location = new System.Drawing.Point(18, 333);
            this.lblInStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInStock.Name = "lblInStock";
            this.lblInStock.Size = new System.Drawing.Size(53, 13);
            this.lblInStock.TabIndex = 55;
            this.lblInStock.Text = "In Stock: ";
            // 
            // chkInStock
            // 
            this.chkInStock.AutoSize = true;
            this.chkInStock.Location = new System.Drawing.Point(110, 333);
            this.chkInStock.Name = "chkInStock";
            this.chkInStock.Size = new System.Drawing.Size(15, 14);
            this.chkInStock.TabIndex = 56;
            this.chkInStock.UseVisualStyleBackColor = true;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(110, 253);
            this.txtSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 20);
            this.txtSize.TabIndex = 57;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.lblFilterError);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.lblConfirmation);
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.btnNo);
            this.panel1.Controls.Add(this.btnDisplayAll);
            this.panel1.Controls.Add(this.btnYes);
            this.panel1.Controls.Add(this.btnFilterSize);
            this.panel1.Controls.Add(this.txtFilterSize);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.lblFilterSize);
            this.panel1.Controls.Add(this.btnFilterColour);
            this.panel1.Controls.Add(this.lblFilterColour);
            this.panel1.Controls.Add(this.txtFilterColour);
            this.panel1.Controls.Add(this.btnFilterBrand);
            this.panel1.Controls.Add(this.lblFilterBrand);
            this.panel1.Controls.Add(this.txtFilterBrand);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lstTrainers);
            this.panel1.Location = new System.Drawing.Point(286, 138);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 309);
            this.panel1.TabIndex = 61;
            // 
            // lblFilterError
            // 
            this.lblFilterError.AutoSize = true;
            this.lblFilterError.Location = new System.Drawing.Point(240, 255);
            this.lblFilterError.Name = "lblFilterError";
            this.lblFilterError.Size = new System.Drawing.Size(0, 13);
            this.lblFilterError.TabIndex = 68;
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.AutoSize = true;
            this.lblConfirmation.Location = new System.Drawing.Point(32, 252);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(0, 13);
            this.lblConfirmation.TabIndex = 67;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(29, 194);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 66;
            // 
            // btnNo
            // 
            this.btnNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNo.Location = new System.Drawing.Point(35, 275);
            this.btnNo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(53, 23);
            this.btnNo.TabIndex = 65;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDisplayAll.Location = new System.Drawing.Point(29, 160);
            this.btnDisplayAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(130, 23);
            this.btnDisplayAll.TabIndex = 62;
            this.btnDisplayAll.Text = "Display All Trainers";
            this.btnDisplayAll.UseVisualStyleBackColor = true;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // btnYes
            // 
            this.btnYes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnYes.Location = new System.Drawing.Point(99, 275);
            this.btnYes.Margin = new System.Windows.Forms.Padding(2);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(53, 23);
            this.btnYes.TabIndex = 64;
            this.btnYes.Text = "YES";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnFilterSize
            // 
            this.btnFilterSize.Location = new System.Drawing.Point(264, 212);
            this.btnFilterSize.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilterSize.Name = "btnFilterSize";
            this.btnFilterSize.Size = new System.Drawing.Size(56, 19);
            this.btnFilterSize.TabIndex = 13;
            this.btnFilterSize.Text = "Filter";
            this.btnFilterSize.UseVisualStyleBackColor = true;
            // 
            // txtFilterSize
            // 
            this.txtFilterSize.Location = new System.Drawing.Point(240, 185);
            this.txtFilterSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilterSize.Name = "txtFilterSize";
            this.txtFilterSize.Size = new System.Drawing.Size(122, 20);
            this.txtFilterSize.TabIndex = 12;
            // 
            // btnEdit
            // 
            this.btnEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEdit.Location = new System.Drawing.Point(29, 212);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(60, 22);
            this.btnEdit.TabIndex = 62;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblFilterSize
            // 
            this.lblFilterSize.AutoSize = true;
            this.lblFilterSize.Location = new System.Drawing.Point(238, 163);
            this.lblFilterSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilterSize.Name = "lblFilterSize";
            this.lblFilterSize.Size = new System.Drawing.Size(72, 13);
            this.lblFilterSize.TabIndex = 11;
            this.lblFilterSize.Text = "Filter by Size: ";
            // 
            // btnFilterColour
            // 
            this.btnFilterColour.Location = new System.Drawing.Point(264, 133);
            this.btnFilterColour.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilterColour.Name = "btnFilterColour";
            this.btnFilterColour.Size = new System.Drawing.Size(56, 19);
            this.btnFilterColour.TabIndex = 10;
            this.btnFilterColour.Text = "Filter";
            this.btnFilterColour.UseVisualStyleBackColor = true;
            // 
            // lblFilterColour
            // 
            this.lblFilterColour.AutoSize = true;
            this.lblFilterColour.Location = new System.Drawing.Point(240, 91);
            this.lblFilterColour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilterColour.Name = "lblFilterColour";
            this.lblFilterColour.Size = new System.Drawing.Size(79, 13);
            this.lblFilterColour.TabIndex = 9;
            this.lblFilterColour.Text = "Filter by Colour:";
            // 
            // txtFilterColour
            // 
            this.txtFilterColour.Location = new System.Drawing.Point(240, 110);
            this.txtFilterColour.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilterColour.Name = "txtFilterColour";
            this.txtFilterColour.Size = new System.Drawing.Size(122, 20);
            this.txtFilterColour.TabIndex = 8;
            // 
            // btnFilterBrand
            // 
            this.btnFilterBrand.Location = new System.Drawing.Point(264, 61);
            this.btnFilterBrand.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilterBrand.Name = "btnFilterBrand";
            this.btnFilterBrand.Size = new System.Drawing.Size(56, 19);
            this.btnFilterBrand.TabIndex = 7;
            this.btnFilterBrand.Text = "Filter";
            this.btnFilterBrand.UseVisualStyleBackColor = true;
            this.btnFilterBrand.Click += new System.EventHandler(this.btnFilterBrand_Click);
            // 
            // lblFilterBrand
            // 
            this.lblFilterBrand.AutoSize = true;
            this.lblFilterBrand.Location = new System.Drawing.Point(240, 15);
            this.lblFilterBrand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilterBrand.Name = "lblFilterBrand";
            this.lblFilterBrand.Size = new System.Drawing.Size(77, 13);
            this.lblFilterBrand.TabIndex = 6;
            this.lblFilterBrand.Text = "Filter by Brand:";
            // 
            // txtFilterBrand
            // 
            this.txtFilterBrand.Location = new System.Drawing.Point(240, 37);
            this.txtFilterBrand.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilterBrand.Name = "txtFilterBrand";
            this.txtFilterBrand.Size = new System.Drawing.Size(122, 20);
            this.txtFilterBrand.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // lstTrainers
            // 
            this.lstTrainers.FormattingEnabled = true;
            this.lstTrainers.Location = new System.Drawing.Point(2, 8);
            this.lstTrainers.Margin = new System.Windows.Forms.Padding(2);
            this.lstTrainers.Name = "lstTrainers";
            this.lstTrainers.Size = new System.Drawing.Size(184, 147);
            this.lstTrainers.TabIndex = 1;
            // 
            // frmTrainers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 486);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.chkInStock);
            this.Controls.Add(this.lblInStock);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblDateAdded);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtDateAdded);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.txtColour);
            this.Controls.Add(this.lblColour);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblManage);
            this.Controls.Add(this.panel4);
            this.Name = "frmTrainers";
            this.Text = "Trainers Management";
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblManage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDateAdded;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtDateAdded;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblInStock;
        private System.Windows.Forms.CheckBox chkInStock;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFilterSize;
        private System.Windows.Forms.TextBox txtFilterSize;
        private System.Windows.Forms.Label lblFilterSize;
        private System.Windows.Forms.Button btnFilterColour;
        private System.Windows.Forms.Label lblFilterColour;
        private System.Windows.Forms.TextBox txtFilterColour;
        private System.Windows.Forms.Button btnFilterBrand;
        private System.Windows.Forms.Label lblFilterBrand;
        private System.Windows.Forms.TextBox txtFilterBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstTrainers;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblFilterError;
    }
}