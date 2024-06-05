namespace NorthwindWinFormsApp.Views
{
    partial class CustomersInvoicesView
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
            PanelCustomersInvoice = new Panel();
            lblTitle = new Label();
            btnExit = new Button();
            CustomerInvoiceDataGridView = new DataGridView();
            PanelCustomersInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerInvoiceDataGridView).BeginInit();
            SuspendLayout();
            // 
            // PanelCustomersInvoice
            // 
            PanelCustomersInvoice.Controls.Add(lblTitle);
            PanelCustomersInvoice.Controls.Add(btnExit);
            PanelCustomersInvoice.Location = new Point(7, 8);
            PanelCustomersInvoice.Margin = new Padding(3, 4, 3, 4);
            PanelCustomersInvoice.Name = "PanelCustomersInvoice";
            PanelCustomersInvoice.Size = new Size(1278, 53);
            PanelCustomersInvoice.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(22, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(222, 25);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Customers'Invoice";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1230, 4);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(39, 31);
            btnExit.TabIndex = 1;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // CustomerInvoiceDataGridView
            // 
            CustomerInvoiceDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerInvoiceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerInvoiceDataGridView.Location = new Point(7, 105);
            CustomerInvoiceDataGridView.Margin = new Padding(3, 4, 3, 4);
            CustomerInvoiceDataGridView.Name = "CustomerInvoiceDataGridView";
            CustomerInvoiceDataGridView.RowHeadersWidth = 51;
            CustomerInvoiceDataGridView.Size = new Size(1269, 556);
            CustomerInvoiceDataGridView.TabIndex = 7;
            CustomerInvoiceDataGridView.RowPrePaint += CustomerInvoiceDataGridView_RowPrePaint;
            // 
            // CustomersInvoicesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 677);
            Controls.Add(CustomerInvoiceDataGridView);
            Controls.Add(PanelCustomersInvoice);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomersInvoicesView";
            Text = "CustomersInvoicesView";
            PanelCustomersInvoice.ResumeLayout(false);
            PanelCustomersInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerInvoiceDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelCustomersInvoice;
        private Label lblTitle;
        private Button btnExit;
        private DataGridView CustomerInvoiceDataGridView;
    }
}