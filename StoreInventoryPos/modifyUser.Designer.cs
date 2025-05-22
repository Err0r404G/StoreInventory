namespace StoreInventoryPos
{
    partial class modifyUser
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            backButton = new Button();
            searchGrid = new DataGridView();
            SelectButton = new DataGridViewButtonColumn();
            USERNAME = new DataGridViewTextBoxColumn();
            fNAME = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            searchField = new TextBox();
            SearchLabel = new Label();
            fNameLabel = new Label();
            usernamelabel = new Label();
            passLabel = new Label();
            userNameField = new TextBox();
            fullNameField = new TextBox();
            passwordField = new TextBox();
            deleteButton = new Button();
            updateButton = new Button();
            roleBox = new ComboBox();
            roleLabel = new Label();
            searchButton = new Button();
            ((System.ComponentModel.ISupportInitialize)searchGrid).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.BackColor = Color.LightPink;
            backButton.Cursor = Cursors.Hand;
            backButton.FlatStyle = FlatStyle.Popup;
            backButton.Font = new Font("Impact", 19.8F);
            backButton.ForeColor = Color.Crimson;
            backButton.Location = new Point(1090, 31);
            backButton.Name = "backButton";
            backButton.Size = new Size(171, 51);
            backButton.TabIndex = 6;
            backButton.Text = "BACK";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // searchGrid
            // 
            searchGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchGrid.Columns.AddRange(new DataGridViewColumn[] { SelectButton, USERNAME, fNAME, role });
            searchGrid.GridColor = SystemColors.ActiveCaption;
            searchGrid.Location = new Point(53, 79);
            searchGrid.Name = "searchGrid";
            searchGrid.RowHeadersWidth = 51;
            searchGrid.ScrollBars = ScrollBars.Vertical;
            searchGrid.Size = new Size(584, 335);
            searchGrid.TabIndex = 9;
            // 
            // SelectButton
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            SelectButton.DefaultCellStyle = dataGridViewCellStyle1;
            SelectButton.Frozen = true;
            SelectButton.HeaderText = "Select";
            SelectButton.MinimumWidth = 6;
            SelectButton.Name = "SelectButton";
            SelectButton.Resizable = DataGridViewTriState.True;
            SelectButton.SortMode = DataGridViewColumnSortMode.Automatic;
            SelectButton.Text = "Select";
            SelectButton.Width = 60;
            // 
            // USERNAME
            // 
            USERNAME.Frozen = true;
            USERNAME.HeaderText = "USERNAME";
            USERNAME.MinimumWidth = 6;
            USERNAME.Name = "USERNAME";
            USERNAME.ReadOnly = true;
            USERNAME.Resizable = DataGridViewTriState.True;
            USERNAME.Width = 145;
            // 
            // fNAME
            // 
            fNAME.Frozen = true;
            fNAME.HeaderText = "FULL NAME";
            fNAME.MinimumWidth = 6;
            fNAME.Name = "fNAME";
            fNAME.ReadOnly = true;
            fNAME.Width = 200;
            // 
            // role
            // 
            role.Frozen = true;
            role.HeaderText = "ROLE";
            role.MinimumWidth = 6;
            role.Name = "role";
            role.ReadOnly = true;
            role.Width = 125;
            // 
            // searchField
            // 
            searchField.BackColor = SystemColors.ControlLightLight;
            searchField.BorderStyle = BorderStyle.FixedSingle;
            searchField.Font = new Font("Segoe UI", 13.8F);
            searchField.Location = new Point(180, 31);
            searchField.Multiline = true;
            searchField.Name = "searchField";
            searchField.Size = new Size(382, 42);
            searchField.TabIndex = 17;
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.BackColor = SystemColors.ActiveCaption;
            SearchLabel.Font = new Font("Impact", 19.8F);
            SearchLabel.Location = new Point(53, 31);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(127, 41);
            SearchLabel.TabIndex = 16;
            SearchLabel.Text = "Search :";
            // 
            // fNameLabel
            // 
            fNameLabel.AutoSize = true;
            fNameLabel.BackColor = SystemColors.ActiveCaption;
            fNameLabel.Font = new Font("Impact", 19.8F);
            fNameLabel.Location = new Point(709, 173);
            fNameLabel.Name = "fNameLabel";
            fNameLabel.Size = new Size(155, 41);
            fNameLabel.TabIndex = 18;
            fNameLabel.Text = "Full Name ";
            // 
            // usernamelabel
            // 
            usernamelabel.AutoSize = true;
            usernamelabel.BackColor = SystemColors.ActiveCaption;
            usernamelabel.Font = new Font("Impact", 19.8F);
            usernamelabel.Location = new Point(709, 104);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(157, 41);
            usernamelabel.TabIndex = 19;
            usernamelabel.Text = "Username";
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.BackColor = SystemColors.ActiveCaption;
            passLabel.Font = new Font("Impact", 19.8F);
            passLabel.Location = new Point(708, 244);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(158, 41);
            passLabel.TabIndex = 20;
            passLabel.Text = "Password ";
            // 
            // userNameField
            // 
            userNameField.BackColor = SystemColors.ControlLightLight;
            userNameField.BorderStyle = BorderStyle.FixedSingle;
            userNameField.Font = new Font("Segoe UI", 13.8F);
            userNameField.Location = new Point(865, 104);
            userNameField.Multiline = true;
            userNameField.Name = "userNameField";
            userNameField.Size = new Size(229, 42);
            userNameField.TabIndex = 21;
            // 
            // fullNameField
            // 
            fullNameField.BackColor = SystemColors.ControlLightLight;
            fullNameField.BorderStyle = BorderStyle.FixedSingle;
            fullNameField.Font = new Font("Segoe UI", 13.8F);
            fullNameField.Location = new Point(865, 173);
            fullNameField.Multiline = true;
            fullNameField.Name = "fullNameField";
            fullNameField.Size = new Size(229, 42);
            fullNameField.TabIndex = 22;
            // 
            // passwordField
            // 
            passwordField.BackColor = SystemColors.ControlLightLight;
            passwordField.BorderStyle = BorderStyle.FixedSingle;
            passwordField.Font = new Font("Segoe UI", 13.8F);
            passwordField.Location = new Point(865, 244);
            passwordField.Multiline = true;
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(229, 42);
            passwordField.TabIndex = 23;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Red;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Font = new Font("Impact", 19.8F);
            deleteButton.ForeColor = Color.LavenderBlush;
            deleteButton.Location = new Point(921, 380);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(158, 48);
            deleteButton.TabIndex = 24;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.FromArgb(128, 255, 128);
            updateButton.Cursor = Cursors.Hand;
            updateButton.FlatStyle = FlatStyle.Popup;
            updateButton.Font = new Font("Impact", 19.8F);
            updateButton.ForeColor = Color.Black;
            updateButton.Location = new Point(723, 380);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(158, 48);
            updateButton.TabIndex = 25;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            // 
            // roleBox
            // 
            roleBox.FormattingEnabled = true;
            roleBox.Items.AddRange(new object[] { "ADMIN", "MANAGER", "STAFF" });
            roleBox.Location = new Point(865, 310);
            roleBox.Name = "roleBox";
            roleBox.Size = new Size(163, 28);
            roleBox.TabIndex = 27;
            roleBox.SelectedIndexChanged += roleBox_SelectedIndexChanged;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Impact", 13.8F);
            roleLabel.Location = new Point(737, 310);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(122, 28);
            roleLabel.TabIndex = 26;
            roleLabel.Text = "Assign Role";
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Red;
            searchButton.Cursor = Cursors.Hand;
            searchButton.FlatStyle = FlatStyle.Popup;
            searchButton.Font = new Font("Impact", 19.8F);
            searchButton.ForeColor = Color.LavenderBlush;
            searchButton.Location = new Point(568, 31);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(69, 42);
            searchButton.TabIndex = 28;
            searchButton.Text = "GO";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // modifyUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 537);
            Controls.Add(searchButton);
            Controls.Add(roleBox);
            Controls.Add(roleLabel);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(passwordField);
            Controls.Add(fullNameField);
            Controls.Add(userNameField);
            Controls.Add(passLabel);
            Controls.Add(usernamelabel);
            Controls.Add(fNameLabel);
            Controls.Add(searchField);
            Controls.Add(SearchLabel);
            Controls.Add(searchGrid);
            Controls.Add(backButton);
            Name = "modifyUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modify User";
            ((System.ComponentModel.ISupportInitialize)searchGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private DataGridView searchGrid;
        private TextBox searchField;
        private Label SearchLabel;
        private Label fNameLabel;
        private Label usernamelabel;
        private Label passLabel;
        private TextBox userNameField;
        private TextBox fullNameField;
        private TextBox passwordField;
        private Button deleteButton;
        private Button updateButton;
        private ComboBox roleBox;
        private Label roleLabel;
        private Button searchButton;
        private DataGridViewButtonColumn SelectButton;
        private DataGridViewTextBoxColumn USERNAME;
        private DataGridViewTextBoxColumn fNAME;
        private DataGridViewTextBoxColumn role;
    }
}
