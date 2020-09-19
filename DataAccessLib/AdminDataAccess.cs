using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOperationlib;

namespace DataAccessLib
{
    public class AdminDataAccess
    {
        DatabaseConnection dbConnection;

        public bool CreateAdmin(Admin admin)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("INSERT INTO Admins(adminfirstname, adminlastname, adminphone, adminemail, adminpass, adminprofileimage) VALUES ('" + admin.AdminFirstName + "','" + admin.AdminLastName + "','" + admin.AdminPhone + "','" + admin.AdminEmail + "','" + admin.AdminPass + "','" + admin.AdminProfileImage + "')");
            if ((dbConnection.DoNoQuery()) < 1)
            {
                dbConnection.Dispose();
                dbConnection = null;
                return false;
            }
            dbConnection.Dispose();
            dbConnection = null;
            return true;
        }

        public Admin GetAdmin(string adminPhone, string adminPass)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("SELECT * FROM Admins WHERE AdminPass='" + adminPass + "' AND AdminPhone='" + adminPhone + "'");
            SqlDataReader reader = dbConnection.DoQuery();
            Admin admin = new Admin();
            while (reader.Read())
            {
                admin.AdminId = reader["AdminId"].ToString();
                admin.AdminFirstName = reader["AdminFirstName"].ToString();
                admin.AdminLastName = reader["AdminLastName"].ToString();
                admin.AdminPhone = reader["AdminPhone"].ToString();
                admin.AdminEmail = reader["AdminEmail"].ToString();
                admin.AdminPass = reader["AdminPass"].ToString();
                admin.AdminProfileImage = reader["AdminProfileImage"].ToString();
            }
            dbConnection.Dispose();
            dbConnection = null;
            return admin;
        }

        public bool IsPhoneEmailTaken(string adminPhone, string adminEmail)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("SELECT AdminPhone, AdminEmail FROM Admins WHERE AdminPhone='" + adminPhone + "' OR AdminEmail='" + adminEmail + "'");
            SqlDataReader reader = dbConnection.DoQuery();
            bool flag = reader.HasRows;
            dbConnection.Dispose();
            dbConnection = null;
            return flag;
        }

        public bool UpdatePassword(string adminPhone, string adminPass)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("UPDATE Admins SET AdminPass='" + adminPass + "' WHERE AdminPhone='" + adminPhone + "'");
            if ((dbConnection.DoNoQuery()) < 1)
            {
                dbConnection.Dispose();
                dbConnection = null;
                return false;
            }
            dbConnection.Dispose();
            dbConnection = null;
            return true;
        }

        public bool DeleteAdmin(string adminId)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("DELETE FROM Admins WHERE AdminId=" + adminId);
            if ((dbConnection.DoNoQuery()) < 1)
            {
                dbConnection.Dispose();
                dbConnection = null;
                return false;
            }
            dbConnection.Dispose();
            dbConnection = null;
            return true;
        }
    }
}
