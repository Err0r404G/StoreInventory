namespace StoreInventoryPos
{
    partial class staffDashboard
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
            staffProfileButton = new Button();
            salesButton = new Button();
            posButton = new Button();
            inventoryButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // staffProfileButton
            // 
            staffProfileButton.BackColor = Color.Cyan;
            staffProfileButton.Cursor = Cursors.Hand;
            staffProfileButton.FlatStyle = FlatStyle.Popup;
            staffProfileButton.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            staffProfileButton.ForeColor = Color.Black;
            staffProfileButton.Location = new Point(605, 47);
            staffProfileButton.Name = "staffProfileButton";
            staffProfileButton.Size = new Size(171, 51);
            staffProfileButton.TabIndex = 23;
            staffProfileButton.Text = "My Profile";
            staffProfileButton.UseVisualStyleBackColor = false;
            // 
            // salesButton
            // 
            salesButton.BackColor = Color.LightSteelBlue;
            salesButton.Cursor = Cursors.Hand;
            salesButton.FlatStyle = FlatStyle.Popup;
            salesButton.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salesButton.ForeColor = Color.Black;
            salesButton.Location = new Point(25, 290);
            salesButton.Name = "salesButton";
            salesButton.Size = new Size(270, 51);
            salesButton.TabIndex = 20;
            salesButton.Text = "Sales";
            salesButton.UseVisualStyleBackColor = false;
            // 
            // posButton
            // 
            posButton.BackColor = Color.LightSteelBlue;
            posButton.Cursor = Cursors.Hand;
            posButton.FlatStyle = FlatStyle.Popup;
            posButton.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            posButton.ForeColor = Color.Black;
            posButton.Location = new Point(25, 47);
            posButton.Name = "posButton";
            posButton.Size = new Size(270, 51);
            posButton.TabIndex = 19;
            posButton.Text = "POS";
            posButton.UseVisualStyleBackColor = false;
            // 
            // inventoryButton
            // 
            inventoryButton.BackColor = Color.LightSteelBlue;
            inventoryButton.Cursor = Cursors.Hand;
            inventoryButton.FlatStyle = FlatStyle.Popup;
            inventoryButton.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inventoryButton.ForeColor = Color.Black;
            inventoryButton.Location = new Point(25, 161);
            inventoryButton.Name = "inventoryButton";
            inventoryButton.Size = new Size(270, 51);
            inventoryButton.TabIndex = 18;
            inventoryButton.Text = "Inventory";
            inventoryButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightPink;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(605, 140);
            button1.Name = "button1";
            button1.Size = new Size(171, 51);
            button1.TabIndex = 17;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = false;
            // 
            // staffDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(staffProfileButton);
            Controls.Add(salesButton);
            Controls.Add(posButton);
            Controls.Add(inventoryButton);
            Controls.Add(button1);
            Name = "staffDashboard";
            Text = "staffDashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button staffProfileButton;
        private Button salesButton;
        private Button posButton;
        private Button inventoryButton;
        private Button button1;
    }
}