﻿namespace NorthwindWinFormsApp.Views
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
            myTabControl.SuspendLayout();
            tabPageCustomerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).BeginInit();
            tabPageCustomerDetales.SuspendLayout();
            SuspendLayout();
            // 
            // myTabControl
            // 
            myTabControl.Controls.Add(tabPageCustomerList);
            myTabControl.Controls.Add(tabPageCustomerDetales);
            myTabControl.Location = new Point(10, 11);
            myTabControl.Margin = new Padding(2, 3, 2, 3);
            myTabControl.Name = "myTabControl";
            myTabControl.SelectedIndex = 0;
            myTabControl.Size = new Size(664, 466);
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
            tabPageCustomerList.Location = new Point(4, 25);
            tabPageCustomerList.Margin = new Padding(2, 3, 2, 3);
            tabPageCustomerList.Name = "tabPageCustomerList";
            tabPageCustomerList.Padding = new Padding(2, 3, 2, 3);
            tabPageCustomerList.Size = new Size(656, 437);
            tabPageCustomerList.TabIndex = 0;
            tabPageCustomerList.Text = "Customer List";
            tabPageCustomerList.UseVisualStyleBackColor = true;
            // 
            // CustomerDataGridView
            // 
            CustomerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDataGridView.Location = new Point(15, 65);
            CustomerDataGridView.Name = "CustomerDataGridView";
            CustomerDataGridView.Size = new Size(632, 366);
            CustomerDataGridView.TabIndex = 6;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(327, 15);
            btnUpdate.Margin = new Padding(2, 3, 2, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(69, 30);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(400, 15);
            btnDelete.Margin = new Padding(2, 3, 2, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(69, 30);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(473, 15);
            btnAdd.Margin = new Padding(2, 3, 2, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(69, 30);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(254, 15);
            btnSearch.Margin = new Padding(2, 3, 2, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(69, 30);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(112, 13);
            txtCustomerID.Margin = new Padding(2, 3, 2, 3);
            txtCustomerID.MaxLength = 5;
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(126, 23);
            txtCustomerID.TabIndex = 1;
            // 
            // lblCustomerId
            // 
            lblCustomerId.AutoSize = true;
            lblCustomerId.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerId.Location = new Point(15, 14);
            lblCustomerId.Margin = new Padding(2, 0, 2, 0);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(93, 16);
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
            tabPageCustomerDetales.Location = new Point(4, 25);
            tabPageCustomerDetales.Margin = new Padding(2, 3, 2, 3);
            tabPageCustomerDetales.Name = "tabPageCustomerDetales";
            tabPageCustomerDetales.Padding = new Padding(2, 3, 2, 3);
            tabPageCustomerDetales.Size = new Size(656, 437);
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
            txtFax.Size = new Size(455, 23);
            txtFax.TabIndex = 20;
            // 
            // lblFax
            // 
            lblFax.AutoSize = true;
            lblFax.Location = new Point(95, 270);
            lblFax.Name = "lblFax";
            lblFax.Size = new Size(35, 16);
            lblFax.TabIndex = 19;
            lblFax.Text = "Fax:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(146, 241);
            txtPhone.MaxLength = 24;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(455, 23);
            txtPhone.TabIndex = 18;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(146, 211);
            txtCountry.MaxLength = 15;
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(455, 23);
            txtCountry.TabIndex = 17;
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(146, 181);
            txtPostalCode.MaxLength = 10;
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(455, 23);
            txtPostalCode.TabIndex = 16;
            // 
            // txtRegion
            // 
            txtRegion.Location = new Point(146, 152);
            txtRegion.MaxLength = 15;
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(455, 23);
            txtRegion.TabIndex = 15;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(146, 123);
            txtCity.MaxLength = 15;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(455, 23);
            txtCity.TabIndex = 14;
            // 
            // txtContactTitle
            // 
            txtContactTitle.Location = new Point(146, 94);
            txtContactTitle.MaxLength = 30;
            txtContactTitle.Name = "txtContactTitle";
            txtContactTitle.Size = new Size(455, 23);
            txtContactTitle.TabIndex = 13;
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(146, 65);
            txtContactName.MaxLength = 30;
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(455, 23);
            txtContactName.TabIndex = 12;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(146, 36);
            txtCompanyName.MaxLength = 40;
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(455, 23);
            txtCompanyName.TabIndex = 11;
            // 
            // txtCustomerCode
            // 
            txtCustomerCode.Location = new Point(146, 9);
            txtCustomerCode.MaxLength = 5;
            txtCustomerCode.Name = "txtCustomerCode";
            txtCustomerCode.Size = new Size(80, 23);
            txtCustomerCode.TabIndex = 10;
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegion.Location = new Point(74, 152);
            lblRegion.Name = "lblRegion";
            lblRegion.Size = new Size(56, 16);
            lblRegion.TabIndex = 9;
            lblRegion.Text = "Region:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(77, 241);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(53, 16);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "Phone:";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(65, 211);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(65, 16);
            lblCountry.TabIndex = 7;
            lblCountry.Text = "Country:";
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Location = new Point(39, 181);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(91, 16);
            lblPostalCode.TabIndex = 6;
            lblPostalCode.Text = "Postal Code:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(91, 123);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(39, 16);
            lblCity.TabIndex = 5;
            lblCity.Text = "City:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(65, 298);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(65, 16);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address:";
            // 
            // lblContactTitle
            // 
            lblContactTitle.AutoSize = true;
            lblContactTitle.Location = new Point(30, 94);
            lblContactTitle.Name = "lblContactTitle";
            lblContactTitle.Size = new Size(100, 16);
            lblContactTitle.TabIndex = 3;
            lblContactTitle.Text = "Contact Title:";
            // 
            // lblContactName
            // 
            lblContactName.AutoSize = true;
            lblContactName.Location = new Point(23, 65);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(107, 16);
            lblContactName.TabIndex = 2;
            lblContactName.Text = "Contact Name:";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Location = new Point(16, 36);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(114, 16);
            lblCompanyName.TabIndex = 1;
            lblCompanyName.Text = "Company Name:";
            // 
            // lblCustomerCode
            // 
            lblCustomerCode.AutoSize = true;
            lblCustomerCode.Location = new Point(29, 9);
            lblCustomerCode.Name = "lblCustomerCode";
            lblCustomerCode.Size = new Size(94, 16);
            lblCustomerCode.TabIndex = 0;
            lblCustomerCode.Text = "Customer ID:";
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 489);
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
    }
}