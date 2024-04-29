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
            PanelCustomersInvoice.Location = new Point(6, 6);
            PanelCustomersInvoice.Name = "PanelCustomersInvoice";
            PanelCustomersInvoice.Size = new Size(1118, 40);
            PanelCustomersInvoice.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(19, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(171, 18);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Customers'Invoice";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1076, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(34, 23);
            btnExit.TabIndex = 1;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // CustomerInvoiceDataGridView
            // 
            CustomerInvoiceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerInvoiceDataGridView.Location = new Point(6, 79);
            CustomerInvoiceDataGridView.Name = "CustomerInvoiceDataGridView";
            CustomerInvoiceDataGridView.Size = new Size(1110, 417);
            CustomerInvoiceDataGridView.TabIndex = 7;
            CustomerInvoiceDataGridView.RowPrePaint += CustomerInvoiceDataGridView_RowPrePaint;
            // 
            // CustomersInvoicesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 508);
            Controls.Add(CustomerInvoiceDataGridView);
            Controls.Add(PanelCustomersInvoice);
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