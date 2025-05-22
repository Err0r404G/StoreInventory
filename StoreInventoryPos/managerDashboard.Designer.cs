namespace StoreInventoryPos
{
    partial class managerDashboard
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
            refundProduct = new Button();
            promoCode = new Button();
            viewStaff = new Button();
            editInventory = new Button();
            logoutButton = new Button();
            saleReport = new Button();
            managerProfile = new Button();
            SuspendLayout();
            // 
            // refundProduct
            // 
            refundProduct.BackColor = Color.LightSteelBlue;
            refundProduct.Cursor = Cursors.Hand;
            refundProduct.FlatStyle = FlatStyle.Popup;
            refundProduct.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refundProduct.ForeColor = Color.Black;
            refundProduct.Location = new Point(37, 343);
            refundProduct.Name = "refundProduct";
            refundProduct.Size = new Size(270, 51);
            refundProduct.TabIndex = 14;
            refundProduct.Text = "Refund";
            refundProduct.UseVisualStyleBackColor = false;
            // 
            // promoCode
            // 
            promoCode.BackColor = Color.LightSteelBlue;
            promoCode.Cursor = Cursors.Hand;
            promoCode.FlatStyle = FlatStyle.Popup;
            promoCode.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            promoCode.ForeColor = Color.Black;
            promoCode.Location = new Point(37, 237);
            promoCode.Name = "promoCode";
            promoCode.Size = new Size(270, 51);
            promoCode.TabIndex = 13;
            promoCode.Text = "Promo Code";
            promoCode.UseVisualStyleBackColor = false;
            // 
            // viewStaff
            // 
            viewStaff.BackColor = Color.LightSteelBlue;
            viewStaff.Cursor = Cursors.Hand;
            viewStaff.FlatStyle = FlatStyle.Popup;
            viewStaff.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewStaff.ForeColor = Color.Black;
            viewStaff.Location = new Point(37, 38);
            viewStaff.Name = "viewStaff";
            viewStaff.Size = new Size(270, 51);
            viewStaff.TabIndex = 12;
            viewStaff.Text = "View Staff";
            viewStaff.UseVisualStyleBackColor = false;
            // 
            // editInventory
            // 
            editInventory.BackColor = Color.LightSteelBlue;
            editInventory.Cursor = Cursors.Hand;
            editInventory.FlatStyle = FlatStyle.Popup;
            editInventory.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editInventory.ForeColor = Color.Black;
            editInventory.Location = new Point(37, 131);
            editInventory.Name = "editInventory";
            editInventory.Size = new Size(270, 51);
            editInventory.TabIndex = 11;
            editInventory.Text = "Edit Inventory";
            editInventory.UseVisualStyleBackColor = false;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.LightPink;
            logoutButton.Cursor = Cursors.Hand;
            logoutButton.FlatStyle = FlatStyle.Popup;
            logoutButton.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutButton.ForeColor = Color.Crimson;
            logoutButton.Location = new Point(617, 131);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(171, 51);
            logoutButton.TabIndex = 10;
            logoutButton.Text = "Log Out";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += LogoutButton_Click;

            // 
            // saleReport
            // 
            saleReport.BackColor = Color.LightSteelBlue;
            saleReport.Cursor = Cursors.Hand;
            saleReport.FlatStyle = FlatStyle.Popup;
            saleReport.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saleReport.ForeColor = Color.Black;
            saleReport.Location = new Point(331, 38);
            saleReport.Name = "saleReport";
            saleReport.Size = new Size(189, 51);
            saleReport.TabIndex = 15;
            saleReport.Text = "Sale Report";
            saleReport.UseVisualStyleBackColor = false;
            // 
            // managerProfile
            // 
            managerProfile.BackColor = Color.Cyan;
            managerProfile.Cursor = Cursors.Hand;
            managerProfile.FlatStyle = FlatStyle.Popup;
            managerProfile.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            managerProfile.ForeColor = Color.Black;
            managerProfile.Location = new Point(617, 38);
            managerProfile.Name = "managerProfile";
            managerProfile.Size = new Size(171, 51);
            managerProfile.TabIndex = 16;
            managerProfile.Text = "My Profile";
            managerProfile.UseVisualStyleBackColor = false;
            // 
            // managerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(managerProfile);
            Controls.Add(saleReport);
            Controls.Add(refundProduct);
            Controls.Add(promoCode);
            Controls.Add(viewStaff);
            Controls.Add(editInventory);
            Controls.Add(logoutButton);
            Name = "managerDashboard";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Manager Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button refundProduct;
        private Button promoCode;
        private Button viewStaff;
        private Button editInventory;
        private Button logoutButton;
        private Button saleReport;
        private Button managerProfile;
    }
}