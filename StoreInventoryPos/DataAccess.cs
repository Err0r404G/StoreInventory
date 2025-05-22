using System.Data;
using System.Data.SqlClient;

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

        public DataAccess()
        {
            this.Sqlcon = new SqlConnection(@"Data Source=VICTUS-20H5\SQLEXPRESS;Initial Catalog=ShoeStorePOS;Persist Security Info=True;User ID=sa;Password=@1812;");
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
        public int InsertUser(string username, string password, string fullname, string role)
        {
            string sql = "INSERT INTO [dbo].[Users] (Username, Password,Fullname,Role) VALUES (@username, @password,@fullname,@role)";
            SqlCommand cmd = new SqlCommand(sql, this.Sqlcon);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@fullname", fullname);
            cmd.Parameters.AddWithValue("@role", role);

            Console.WriteLine(username + " " + password + " " + fullname + " " + role); 
            return cmd.ExecuteNonQuery();
        }

        public bool ValidateUser(string username, string password, out string role)
        {
            role = string.Empty;
            string sql = "SELECT Role FROM [dbo].[Users] WHERE Username = @username AND Password = @password";
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



    }
}
