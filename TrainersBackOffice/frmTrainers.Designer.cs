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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrainers));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblManage = new System.Windows.Forms.Label();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            
            
            
            
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
           
            
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
            this.lblManage.Location = new System.Drawing.Point(11, 132);
            this.lblManage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManage.Name = "lblManage";
            this.lblManage.Size = new System.Drawing.Size(195, 28);
            this.lblManage.TabIndex = 41;
            this.lblManage.Text = "Manage Trainers";
            // 
            // lblDateAdded
            // 
            this.lblDateAdded.AutoSize = true;
            this.lblDateAdded.Location = new System.Drawing.Point(17, 307);
            this.lblDateAdded.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateAdded.Name = "lblDateAdded";
            this.lblDateAdded.Size = new System.Drawing.Size(70, 13);
            this.lblDateAdded.TabIndex = 53;
            this.lblDateAdded.Text = "Date Added: ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(17, 281);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 52;
            this.lblPrice.Text = "Price:";
            // 
            // txtDateAdded
            // 
            this.txtDateAdded.Location = new System.Drawing.Point(110, 304);
            this.txtDateAdded.Margin = new System.Windows.Forms.Padding(2);
            this.txtDateAdded.Name = "txtDateAdded";
            this.txtDateAdded.Size = new System.Drawing.Size(100, 20);
            this.txtDateAdded.TabIndex = 51;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(110, 281);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 50;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(17, 257);
            this.lblSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(33, 13);
            this.lblSize.TabIndex = 48;
            this.lblSize.Text = "Size: ";
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(110, 232);
            this.txtColour.Margin = new System.Windows.Forms.Padding(2);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(100, 20);
            this.txtColour.TabIndex = 47;
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(17, 232);
            this.lblColour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(43, 13);
            this.lblColour.TabIndex = 46;
            this.lblColour.Text = "Colour: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 208);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 45;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 208);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 44;
            this.lblName.Text = "Name: ";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(110, 185);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 20);
            this.txtBrand.TabIndex = 43;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(17, 185);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(38, 13);
            this.lblBrand.TabIndex = 42;
            this.lblBrand.Text = "Brand:";
            // 
            // lblInStock
            // 
            this.lblInStock.AutoSize = true;
            this.lblInStock.Location = new System.Drawing.Point(17, 333);
            this.lblInStock.Name = "lblInStock";
            this.lblInStock.Size = new System.Drawing.Size(50, 13);
            this.lblInStock.TabIndex = 54;
            this.lblInStock.Text = "In Stock:";
            // 
            // chkInStock
            // 
            this.chkInStock.AutoSize = true;
            this.chkInStock.Location = new System.Drawing.Point(110, 333);
            this.chkInStock.Name = "chkInStock";
            this.chkInStock.Size = new System.Drawing.Size(15, 14);
            this.chkInStock.TabIndex = 55;
            this.chkInStock.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(11, 381);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 31);
            this.panel2.TabIndex = 56;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(156, 3);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 19);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
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
            
            
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(110, 257);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 20);
            this.txtSize.TabIndex = 58;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(11, 363);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 59;
            // 
            // frmTrainers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 461);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chkInStock);
            this.Controls.Add(this.lblInStock);
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
            this.Text = "Trainers Management ";
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblManage;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        
        private System.Windows.Forms.BindingSource tblTrainersBindingSource;
        
        private System.Windows.Forms.BindingSource tblTrainersBindingSource1;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblError;
    }
}