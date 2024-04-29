namespace NorthwindWinFormsApp.Views
{
    partial class MainView
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
            MainPanel = new Panel();
            btnCustomerView = new Button();
            btnInvoices = new Button();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ControlLightLight;
            MainPanel.Controls.Add(btnInvoices);
            MainPanel.Controls.Add(btnCustomerView);
            MainPanel.Dock = DockStyle.Left;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(229, 480);
            MainPanel.TabIndex = 0;
            // 
            // btnCustomerView
            // 
            btnCustomerView.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCustomerView.Location = new Point(3, 51);
            btnCustomerView.Name = "btnCustomerView";
            btnCustomerView.Size = new Size(222, 36);
            btnCustomerView.TabIndex = 1;
            btnCustomerView.Text = "Customer";
            btnCustomerView.UseVisualStyleBackColor = true;
            // 
            // btnInvoices
            // 
            btnInvoices.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnInvoices.Location = new Point(3, 222);
            btnInvoices.Name = "btnInvoices";
            btnInvoices.Size = new Size(222, 36);
            btnInvoices.TabIndex = 2;
            btnInvoices.Text = "Customer Invoices";
            btnInvoices.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 480);
            Controls.Add(MainPanel);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "MainView";
            WindowState = FormWindowState.Maximized;
            MainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Button btnCustomerView;
        private Button btnInvoices;
    }
}