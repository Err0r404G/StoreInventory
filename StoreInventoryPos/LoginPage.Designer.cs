namespace StoreInventoryPos
{
    partial class LoginPage
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
            label1 = new Label();
            userName = new Label();
            userNameField = new TextBox();
            passWord = new Label();
            passWordField = new TextBox();
            loginutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(278, 59);
            label1.Name = "label1";
            label1.Size = new Size(171, 42);
            label1.TabIndex = 7;
            label1.Text = "USER LOGIN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.BackColor = SystemColors.ActiveCaption;
            userName.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userName.Location = new Point(81, 126);
            userName.Name = "userName";
            userName.Size = new Size(172, 42);
            userName.TabIndex = 8;
            userName.Text = " USERNAME ";
            userName.TextAlign = ContentAlignment.TopCenter;
            // 
            // userNameField
            // 
            userNameField.BackColor = SystemColors.ControlLightLight;
            userNameField.BorderStyle = BorderStyle.FixedSingle;
            userNameField.Cursor = Cursors.IBeam;
            userNameField.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameField.Location = new Point(250, 126);
            userNameField.Multiline = true;
            userNameField.Name = "userNameField";
            userNameField.Size = new Size(313, 42);
            userNameField.TabIndex = 9;
            userNameField.UseWaitCursor = true;
            userNameField.TextChanged += userNameField_TextChanged;
            // 
            // passWord
            // 
            passWord.AutoSize = true;
            passWord.BackColor = SystemColors.ActiveCaption;
            passWord.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passWord.Location = new Point(81, 243);
            passWord.Name = "passWord";
            passWord.Size = new Size(170, 42);
            passWord.TabIndex = 10;
            passWord.Text = "PASSWORD";
            passWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passWordField
            // 
            passWordField.BackColor = SystemColors.ControlLightLight;
            passWordField.BorderStyle = BorderStyle.FixedSingle;
            passWordField.Cursor = Cursors.IBeam;
            passWordField.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passWordField.Location = new Point(250, 243);
            passWordField.Multiline = true;
            passWordField.Name = "passWordField";
            passWordField.Size = new Size(313, 42);
            passWordField.TabIndex = 9;
            passWordField.UseWaitCursor = true;
            passWordField.TextChanged += passWordField_TextChanged;
            // 
            // loginutton
            // 
            loginutton.BackColor = Color.White;
            loginutton.Cursor = Cursors.Hand;
            loginutton.FlatStyle = FlatStyle.Popup;
            loginutton.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginutton.ForeColor = Color.Crimson;
            loginutton.Location = new Point(278, 314);
            loginutton.Name = "loginutton";
            loginutton.Size = new Size(171, 51);
            loginutton.TabIndex = 12;
            loginutton.Text = "LOGIN";
            loginutton.UseVisualStyleBackColor = false;
            loginutton.Click += loginutton_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 446);
            Controls.Add(loginutton);
            Controls.Add(passWordField);
            Controls.Add(passWord);
            Controls.Add(userNameField);
            Controls.Add(userName);
            Controls.Add(label1);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label userName;
        private TextBox userNameField;
        private Label passWord;
        private TextBox passWordField;
        private Button loginutton;
    }
}