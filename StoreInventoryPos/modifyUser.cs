using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using WFAManagementPro;

namespace StoreInventoryPos
{
    public partial class modifyUser : Form
    {




        // Constructor to accept current user


        // Default constructor (if you want to allow it)
        public modifyUser()
        {
            InitializeComponent();
            this.Load += ModifyUser_Load;
        }

        // On form load, load users into the grid
        private void ModifyUser_Load(object sender, EventArgs e)
        {
            LoadUsersIntoGrid();
        }

        // Load all users from DB and bind to searchGrid
        private void LoadUsersIntoGrid()
        {
            try
            {
                DataAccess db = new DataAccess();
                DataTable users = db.getUser();

                searchGrid.DataSource = users;

                // Optionally adjust column headers if those columns exist
                if (searchGrid.Columns.Contains("Username"))
                    searchGrid.Columns["Username"].HeaderText = "Username";
                if (searchGrid.Columns.Contains("Fullname"))
                    searchGrid.Columns["Fullname"].HeaderText = "Full Name";
                if (searchGrid.Columns.Contains("Role"))
                    searchGrid.Columns["Role"].HeaderText = "Role";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        // Back button event - go back to adminDashboard
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminDashboard back = new adminDashboard();
            back.Show();
        }

        // You can implement other event handlers as needed, example:
        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchField.Text.Trim();
            LoadUsersIntoGrid(searchTerm);
        }


        // Overload LoadUsersIntoGrid to accept search term
        private void LoadUsersIntoGrid(string searchTerm = "")
        {
            try
            {
                DataAccess db = new DataAccess();
                DataTable users;

                if (string.IsNullOrEmpty(searchTerm))
                {
                    users = db.getUser(); // Get all users
                }
                else
                {
                    users = db.SearchUsersByUsername(searchTerm); // Get filtered users
                }

                searchGrid.DataSource = users;

                if (searchGrid.Columns.Contains("Username"))
                    searchGrid.Columns["Username"].HeaderText = "Username";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }


        private void roleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Implement role filter or other logic here
        }

        private void searchGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: handle user selection or edit here
        }
    }
}
