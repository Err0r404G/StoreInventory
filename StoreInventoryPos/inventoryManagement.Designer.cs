namespace StoreInventoryPos
{
    partial class inventoryManagement
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
            addButton = new Button();
            deleteButton = new Button();
            searchButton = new Button();
            backButton = new Button();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.BackColor = Color.LightSteelBlue;
            addButton.Cursor = Cursors.Hand;
            addButton.FlatStyle = FlatStyle.Popup;
            addButton.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addButton.ForeColor = Color.Black;
            addButton.Location = new Point(262, 146);
            addButton.Name = "addButton";
            addButton.Size = new Size(270, 51);
            addButton.TabIndex = 12;
            addButton.Text = "Add Product";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.LightSteelBlue;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = Color.Black;
            deleteButton.Location = new Point(262, 244);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(270, 51);
            deleteButton.TabIndex = 13;
            deleteButton.Text = "Delete Product";
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.LightSteelBlue;
            searchButton.Cursor = Cursors.Hand;
            searchButton.FlatStyle = FlatStyle.Popup;
            searchButton.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.Black;
            searchButton.Location = new Point(262, 46);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(270, 51);
            searchButton.TabIndex = 14;
            searchButton.Text = "Search Product";
            searchButton.UseVisualStyleBackColor = false;
            // 
            // backButton
            // 
            backButton.BackColor = Color.LightPink;
            backButton.Cursor = Cursors.Hand;
            backButton.FlatStyle = FlatStyle.Popup;
            backButton.Font = new Font("Impact", 19.8F);
            backButton.ForeColor = Color.Crimson;
            backButton.Location = new Point(315, 342);
            backButton.Name = "backButton";
            backButton.Size = new Size(171, 51);
            backButton.TabIndex = 15;
            backButton.Text = "BACK";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // inventoryManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(searchButton);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Name = "inventoryManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management";
            ResumeLayout(false);
        }

        #endregion

        private Button addButton;
        private Button deleteButton;
        private Button searchButton;
        private Button backButton;
    }
}