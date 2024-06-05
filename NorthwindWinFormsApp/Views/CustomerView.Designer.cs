namespace NorthwindWinFormsApp.Views
{
    partial class CustomerView
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
            myTabControl = new TabControl();
            tabPageCustomerList = new TabPage();
            CustomerDataGridView = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            txtCustomerID = new TextBox();
            lblCustomerId = new Label();
            tabPageCustomerDetales = new TabPage();
            btnCancel = new Button();
            btnSave = new Button();
            txtAddress = new TextBox();
            txtFax = new TextBox();
            lblFax = new Label();
            txtPhone = new TextBox();
            txtCountry = new TextBox();
            txtPostalCode = new TextBox();
            txtRegion = new TextBox();
            txtCity = new TextBox();
            txtContactTitle = new TextBox();
            txtContactName = new TextBox();
            txtCompanyName = new TextBox();
            txtCustomerCode = new TextBox();
            lblRegion = new Label();
            lblPhone = new Label();
            lblCountry = new Label();
            lblPostalCode = new Label();
            lblCity = new Label();
            lblAddress = new Label();
            lblContactTitle = new Label();
            lblContactName = new Label();
            lblCompanyName = new Label();
            lblCustomerCode = new Label();
            btnExit = new Button();
            panel1 = new Panel();
            lblTitle = new Label();
            myTabControl.SuspendLayout();
            tabPageCustomerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).BeginInit();
            tabPageCustomerDetales.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // myTabControl
            // 
            myTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            myTabControl.Controls.Add(tabPageCustomerList);
            myTabControl.Controls.Add(tabPageCustomerDetales);
            myTabControl.Location = new Point(11, 43);
            myTabControl.Margin = new Padding(2, 3, 2, 3);
            myTabControl.Name = "myTabControl";
            myTabControl.SelectedIndex = 0;
            myTabControl.Size = new Size(1094, 452);
            myTabControl.TabIndex = 0;
            // 
            // tabPageCustomerList
            // 
            tabPageCustomerList.Controls.Add(CustomerDataGridView);
            tabPageCustomerList.Controls.Add(btnUpdate);
            tabPageCustomerList.Controls.Add(btnDelete);
            tabPageCustomerList.Controls.Add(btnAdd);
            tabPageCustomerList.Controls.Add(btnSearch);
            tabPageCustomerList.Controls.Add(txtCustomerID);
            tabPageCustomerList.Controls.Add(lblCustomerId);
            tabPageCustomerList.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageCustomerList.Location = new Point(4, 27);
            tabPageCustomerList.Margin = new Padding(2, 3, 2, 3);
            tabPageCustomerList.Name = "tabPageCustomerList";
            tabPageCustomerList.Padding = new Padding(2, 3, 2, 3);
            tabPageCustomerList.Size = new Size(1086, 421);
            tabPageCustomerList.TabIndex = 0;
            tabPageCustomerList.Text = "Customer List";
            tabPageCustomerList.UseVisualStyleBackColor = true;
            // 
            // CustomerDataGridView
            // 
            CustomerDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDataGridView.Location = new Point(15, 65);
            CustomerDataGridView.Name = "CustomerDataGridView";
            CustomerDataGridView.RowHeadersWidth = 51;
            CustomerDataGridView.Size = new Size(1067, 366);
            CustomerDataGridView.TabIndex = 6;
            CustomerDataGridView.RowPrePaint += CustomerDataGridView_RowPrePaint;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(427, 14);
            btnUpdate.Margin = new Padding(2, 3, 2, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 30);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(530, 14);
            btnDelete.Margin = new Padding(2, 3, 2, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 30);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(642, 14);
            btnAdd.Margin = new Padding(2, 3, 2, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(103, 30);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(308, 14);
            btnSearch.Margin = new Padding(2, 3, 2, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(98, 30);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(144, 13);
            txtCustomerID.Margin = new Padding(2, 3, 2, 3);
            txtCustomerID.MaxLength = 5;
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(120, 27);
            txtCustomerID.TabIndex = 1;
            // 
            // lblCustomerId
            // 
            lblCustomerId.AutoSize = true;
            lblCustomerId.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerId.Location = new Point(15, 14);
            lblCustomerId.Margin = new Padding(2, 0, 2, 0);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(125, 20);
            lblCustomerId.TabIndex = 0;
            lblCustomerId.Text = "Customer Id:";
            // 
            // tabPageCustomerDetales
            // 
            tabPageCustomerDetales.Controls.Add(btnCancel);
            tabPageCustomerDetales.Controls.Add(btnSave);
            tabPageCustomerDetales.Controls.Add(txtAddress);
            tabPageCustomerDetales.Controls.Add(txtFax);
            tabPageCustomerDetales.Controls.Add(lblFax);
            tabPageCustomerDetales.Controls.Add(txtPhone);
            tabPageCustomerDetales.Controls.Add(txtCountry);
            tabPageCustomerDetales.Controls.Add(txtPostalCode);
            tabPageCustomerDetales.Controls.Add(txtRegion);
            tabPageCustomerDetales.Controls.Add(txtCity);
            tabPageCustomerDetales.Controls.Add(txtContactTitle);
            tabPageCustomerDetales.Controls.Add(txtContactName);
            tabPageCustomerDetales.Controls.Add(txtCompanyName);
            tabPageCustomerDetales.Controls.Add(txtCustomerCode);
            tabPageCustomerDetales.Controls.Add(lblRegion);
            tabPageCustomerDetales.Controls.Add(lblPhone);
            tabPageCustomerDetales.Controls.Add(lblCountry);
            tabPageCustomerDetales.Controls.Add(lblPostalCode);
            tabPageCustomerDetales.Controls.Add(lblCity);
            tabPageCustomerDetales.Controls.Add(lblAddress);
            tabPageCustomerDetales.Controls.Add(lblContactTitle);
            tabPageCustomerDetales.Controls.Add(lblContactName);
            tabPageCustomerDetales.Controls.Add(lblCompanyName);
            tabPageCustomerDetales.Controls.Add(lblCustomerCode);
            tabPageCustomerDetales.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageCustomerDetales.Location = new Point(4, 29);
            tabPageCustomerDetales.Margin = new Padding(2, 3, 2, 3);
            tabPageCustomerDetales.Name = "tabPageCustomerDetales";
            tabPageCustomerDetales.Padding = new Padding(2, 3, 2, 3);
            tabPageCustomerDetales.Size = new Size(1086, 419);
            tabPageCustomerDetales.TabIndex = 1;
            tabPageCustomerDetales.Text = "Customer Detales";
            tabPageCustomerDetales.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(526, 381);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(445, 381);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(147, 302);
            txtAddress.MaxLength = 60;
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(454, 51);
            txtAddress.TabIndex = 21;
            // 
            // txtFax
            // 
            txtFax.Location = new Point(146, 270);
            txtFax.MaxLength = 24;
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(455, 27);
            txtFax.TabIndex = 20;
            // 
            // lblFax
            // 
            lblFax.AutoSize = true;
            lblFax.Location = new Point(95, 270);
            lblFax.Name = "lblFax";
            lblFax.Size = new Size(46, 20);
            lblFax.TabIndex = 19;
            lblFax.Text = "Fax:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(146, 241);
            txtPhone.MaxLength = 24;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(455, 27);
            txtPhone.TabIndex = 18;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(146, 211);
            txtCountry.MaxLength = 15;
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(455, 27);
            txtCountry.TabIndex = 17;
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(146, 181);
            txtPostalCode.MaxLength = 10;
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(455, 27);
            txtPostalCode.TabIndex = 16;
            // 
            // txtRegion
            // 
            txtRegion.Location = new Point(146, 152);
            txtRegion.MaxLength = 15;
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(455, 27);
            txtRegion.TabIndex = 15;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(146, 123);
            txtCity.MaxLength = 15;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(455, 27);
            txtCity.TabIndex = 14;
            // 
            // txtContactTitle
            // 
            txtContactTitle.Location = new Point(146, 94);
            txtContactTitle.MaxLength = 30;
            txtContactTitle.Name = "txtContactTitle";
            txtContactTitle.Size = new Size(455, 27);
            txtContactTitle.TabIndex = 13;
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(146, 65);
            txtContactName.MaxLength = 30;
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(455, 27);
            txtContactName.TabIndex = 12;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(146, 36);
            txtCompanyName.MaxLength = 40;
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(455, 27);
            txtCompanyName.TabIndex = 11;
            // 
            // txtCustomerCode
            // 
            txtCustomerCode.Location = new Point(146, 9);
            txtCustomerCode.MaxLength = 5;
            txtCustomerCode.Name = "txtCustomerCode";
            txtCustomerCode.Size = new Size(80, 27);
            txtCustomerCode.TabIndex = 10;
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegion.Location = new Point(74, 152);
            lblRegion.Name = "lblRegion";
            lblRegion.Size = new Size(76, 20);
            lblRegion.TabIndex = 9;
            lblRegion.Text = "Region:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(77, 241);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(69, 20);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "Phone:";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(65, 211);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(85, 20);
            lblCountry.TabIndex = 7;
            lblCountry.Text = "Country:";
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Location = new Point(39, 181);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(117, 20);
            lblPostalCode.TabIndex = 6;
            lblPostalCode.Text = "Postal Code:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(91, 123);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(51, 20);
            lblCity.TabIndex = 5;
            lblCity.Text = "City:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(65, 298);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(86, 20);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address:";
            // 
            // lblContactTitle
            // 
            lblContactTitle.AutoSize = true;
            lblContactTitle.Location = new Point(30, 94);
            lblContactTitle.Name = "lblContactTitle";
            lblContactTitle.Size = new Size(126, 20);
            lblContactTitle.TabIndex = 3;
            lblContactTitle.Text = "Contact Title:";
            // 
            // lblContactName
            // 
            lblContactName.AutoSize = true;
            lblContactName.Location = new Point(23, 65);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(139, 20);
            lblContactName.TabIndex = 2;
            lblContactName.Text = "Contact Name:";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Location = new Point(16, 36);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(154, 20);
            lblCompanyName.TabIndex = 1;
            lblCompanyName.Text = "Company Name:";
            // 
            // lblCustomerCode
            // 
            lblCustomerCode.AutoSize = true;
            lblCustomerCode.Location = new Point(29, 9);
            lblCustomerCode.Name = "lblCustomerCode";
            lblCustomerCode.Size = new Size(127, 20);
            lblCustomerCode.TabIndex = 0;
            lblCustomerCode.Text = "Customer ID:";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1052, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(34, 23);
            btnExit.TabIndex = 1;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnExit);
            panel1.Location = new Point(11, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1090, 34);
            panel1.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(19, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(119, 25);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Customer";
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 507);
            Controls.Add(panel1);
            Controls.Add(myTabControl);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerView";
            Text = "CustomerView";
            myTabControl.ResumeLayout(false);
            tabPageCustomerList.ResumeLayout(false);
            tabPageCustomerList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).EndInit();
            tabPageCustomerDetales.ResumeLayout(false);
            tabPageCustomerDetales.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl myTabControl;
        private TabPage tabPageCustomerList;
        private TabPage tabPageCustomerDetales;
        private TextBox txtCustomerID;
        private Label lblCustomerId;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnSearch;
        private DataGridView CustomerDataGridView;
        private TextBox txtCustomerCode;
        private Label lblRegion;
        private Label lblPhone;
        private Label lblCountry;
        private Label lblPostalCode;
        private Label lblCity;
        private Label lblAddress;
        private Label lblContactTitle;
        private Label lblContactName;
        private Label lblCompanyName;
        private Label lblCustomerCode;
        private TextBox txtCompanyName;
        private TextBox txtContactName;
        private TextBox txtContactTitle;
        private TextBox txtCity;
        private TextBox txtRegion;
        private TextBox txtPostalCode;
        private TextBox txtCountry;
        private TextBox txtPhone;
        private TextBox txtFax;
        private Label lblFax;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtAddress;
        private Button btnExit;
        private Panel panel1;
        private Label lblTitle;
    }
}