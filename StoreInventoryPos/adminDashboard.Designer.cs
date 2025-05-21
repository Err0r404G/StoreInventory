namespace StoreInventoryPos
{
    partial class adminDashboard
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
            logOut = new Button();
            CreateUser = new Button();
            viewUser = new Button();
            deleteUser = new Button();
            modifyUser = new Button();
            SuspendLayout();
            // 
            // logOut
            // 
            logOut.BackColor = Color.LightPink;
            logOut.Cursor = Cursors.Hand;
            logOut.FlatStyle = FlatStyle.Popup;
            logOut.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logOut.ForeColor = Color.Crimson;
            logOut.Location = new Point(617, 12);
            logOut.Name = "logOut";
            logOut.Size = new Size(171, 51);
            logOut.TabIndex = 5;
            logOut.Text = "Log Out";
            logOut.UseVisualStyleBackColor = false;
            // 
            // CreateUser
            // 
            CreateUser.BackColor = Color.LightSteelBlue;
            CreateUser.Cursor = Cursors.Hand;
            CreateUser.FlatStyle = FlatStyle.Popup;
            CreateUser.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateUser.ForeColor = Color.Black;
            CreateUser.Location = new Point(37, 124);
            CreateUser.Name = "CreateUser";
            CreateUser.Size = new Size(205, 51);
            CreateUser.TabIndex = 6;
            CreateUser.Text = "Create User";
            CreateUser.UseVisualStyleBackColor = false;
            // 
            // viewUser
            // 
            viewUser.BackColor = Color.LightSteelBlue;
            viewUser.Cursor = Cursors.Hand;
            viewUser.FlatStyle = FlatStyle.Popup;
            viewUser.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewUser.ForeColor = Color.Black;
            viewUser.Location = new Point(37, 31);
            viewUser.Name = "viewUser";
            viewUser.Size = new Size(205, 51);
            viewUser.TabIndex = 7;
            viewUser.Text = "View User";
            viewUser.UseVisualStyleBackColor = false;
            // 
            // deleteUser
            // 
            deleteUser.BackColor = Color.LightSteelBlue;
            deleteUser.Cursor = Cursors.Hand;
            deleteUser.FlatStyle = FlatStyle.Popup;
            deleteUser.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteUser.ForeColor = Color.Black;
            deleteUser.Location = new Point(37, 336);
            deleteUser.Name = "deleteUser";
            deleteUser.Size = new Size(205, 51);
            deleteUser.TabIndex = 9;
            deleteUser.Text = "Delete User";
            deleteUser.UseVisualStyleBackColor = false;
            // 
            // modifyUser
            // 
            modifyUser.BackColor = Color.LightSteelBlue;
            modifyUser.Cursor = Cursors.Hand;
            modifyUser.FlatStyle = FlatStyle.Popup;
            modifyUser.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modifyUser.ForeColor = Color.Black;
            modifyUser.Location = new Point(37, 230);
            modifyUser.Name = "modifyUser";
            modifyUser.Size = new Size(205, 51);
            modifyUser.TabIndex = 8;
            modifyUser.Text = "Modify User";
            modifyUser.UseVisualStyleBackColor = false;
            // 
            // adminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteUser);
            Controls.Add(modifyUser);
            Controls.Add(viewUser);
            Controls.Add(CreateUser);
            Controls.Add(logOut);
            Name = "adminDashboard";
            Text = "Admin Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button logOut;
        private Button CreateUser;
        private Button viewUser;
        private Button deleteUser;
        private Button modifyUser;
    }
}