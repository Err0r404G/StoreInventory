using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WFAManagementPro
{
    class DataAccess
    {
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        private readonly string connectionString = @"Data Source=VICTUS-20H5\SQLEXPRESS;Initial Catalog=ShoeStorePOS;Persist Security Info=True;User ID=sa;Password=@1812;";

        public DataAccess()
        {
            this.Sqlcon = new SqlConnection(connectionString);
            this.Sqlcon.Open();
        }

        /* private void QueryText(string query)
         {
             this.Sqlcom = new SqlCommand(query, this.Sqlcon);
         }

         public DataSet ExecuteQuery(string sql)
         {
             try
             {
                 this.QueryText(sql);
                 this.Sda = new SqlDataAdapter(this.Sqlcom);
                 this.Ds = new DataSet();
                 this.Sda.Fill(this.Ds);
                 return this.Ds;
             }
             catch (Exception exc)
             {
                 return null;
             }
         }

         public int ExecuteUpdateQuery(string sql)
         {
             this.QueryText(sql);
             int u = this.Sqlcom.ExecuteNonQuery();
             return u;
         }
        */
        //Query Function


        // Create User DataBase
        public int InsertUser(string username, string password, string fullname, string role)
        {
            string sql = "INSERT INTO Users (Username, Password,Fullname,Role) VALUES (@username, @password,@fullname,@role)";
            SqlCommand cmd = new SqlCommand(sql, this.Sqlcon);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@fullname", fullname);
            cmd.Parameters.AddWithValue("@role", role);

            Console.WriteLine(username + " " + password + " " + fullname + " " + role);
            return cmd.ExecuteNonQuery();
        }


        // Add Product DataBase
        public int InsertProduct(string productname, double cost, double price, int quantity, string size)
        {
            string sql = "INSERT INTO Product (ProductName, Cost, Price, Quantity, Size) VALUES (@Productname, @Cost, @Price, @Quantity, @Size)";
            SqlCommand cmd = new SqlCommand(sql, this.Sqlcon);

            cmd.Parameters.AddWithValue("@ProductName", productname);
            cmd.Parameters.AddWithValue("@Cost", cost);
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.AddWithValue("@Quantity", quantity);
            cmd.Parameters.AddWithValue("@Size", size);

            Console.WriteLine($"{productname} {cost} {price} {quantity} {size}");
            return cmd.ExecuteNonQuery();
        }


        // Login Validation
        public bool ValidateUser(string username, string password, out string role)
        {
            role = string.Empty;
            string sql = "SELECT Role FROM Users WHERE Username = @username AND Password = @password";
            SqlCommand cmd = new SqlCommand(sql, this.Sqlcon);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    role = reader["Role"].ToString();
                    return true; // Login successful
                }
            }
            return false; // Login failed
        }

        // Get all users from DB
        public DataTable getUser()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT Username, Fullname, Role FROM Users";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public DataTable SearchUsersByUsername(string username)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT Username, Fullname, Role FROM Users WHERE Username LIKE @username";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            {
                cmd.Parameters.AddWithValue("@username", "%" + username + "%"); 

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }



    }
}
