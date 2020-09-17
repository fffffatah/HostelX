using DatabaseOperationlib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLib
{
    public class TenantDataAccess
    {
        DatabaseConnection dbConnection;

        public bool CreateTenant(Tenant tenant)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("INSERT INTO Tenants(TENANTFIRSTNAME, TENANTLASTNAME, TENANTPHONE, TENANTEMAIL, TENANTADDRESS, TENANTINSTITUTION, TENANTPASS, TENANTPROFILEIMAGE, HOSTELID, TENENATGENDER) VALUES ('"+tenant.TenantFirstName+"','"+tenant.TenantLastName+"','"+tenant.TenantPhone+"','"+tenant.TenantEmail+"','"+tenant.TenantAddress+"','"+tenant.TenantInstitution+"','"+tenant.TenantPass+"','"+tenant.TenantProfileImage+"',"+tenant.HostelId+",'"+tenant.TenantGender+"')");
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

        public List<Tenant> GetTenants(string hostelId)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("SELECT * FROM Tenants WHERE HostelId="+hostelId);
            List<Tenant> tenants = new List<Tenant>();
            SqlDataReader reader = dbConnection.DoQuery();
            while (reader.Read())
            {
                Tenant tenant = new Tenant();
                tenant.TenantId = reader["TenantId"].ToString();
                tenant.TenantFirstName = reader["TenantFirstName"].ToString();
                tenant.TenantLastName = reader["TenantLastName"].ToString();
                tenant.TenantPhone = reader["TenantPhone"].ToString();
                tenant.TenantEmail = reader["TenantEmail"].ToString();
                tenant.TenantAddress = reader["TenantAddress"].ToString();
                tenant.TenantInstitution = reader["TenantInstitution"].ToString();
                tenant.TenantPass = reader["TenantPass"].ToString();
                tenant.TenantProfileImage = reader["TenantProfileImage"].ToString();
                tenant.TenantGender = reader["TenantGender"].ToString();
                tenant.HostelId = reader["HostelId"].ToString();
                tenants.Add(tenant);
            }
            dbConnection.Dispose();
            dbConnection = null;
            return tenants;
        }

        public Tenant GetTenant(string tenantEmail, string tenantPass)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("SELECT * FROM Tenants WHERE TenantEmail='"+tenantEmail+"' AND TenantPass='"+tenantPass+"'");
            SqlDataReader reader = dbConnection.DoQuery();
            Tenant tenant = new Tenant();
            while (reader.Read())
            {
                tenant.TenantId = reader["TenantId"].ToString();
                tenant.TenantFirstName = reader["TenantFirstName"].ToString();
                tenant.TenantLastName = reader["TenantLastName"].ToString();
                tenant.TenantPhone = reader["TenantPhone"].ToString();
                tenant.TenantEmail = reader["TenantEmail"].ToString();
                tenant.TenantAddress = reader["TenantAddress"].ToString();
                tenant.TenantInstitution = reader["TenantInstitution"].ToString();
                tenant.TenantPass = reader["TenantPass"].ToString();
                tenant.TenantProfileImage = reader["TenantProfileImage"].ToString();
                tenant.TenantGender = reader["TenantGender"].ToString();
                tenant.HostelId = reader["HostelId"].ToString();
            }
            dbConnection.Dispose();
            dbConnection = null;
            return tenant;
        }

        public bool IsPhoneEmailTaken(string tenantPhone, string tenantEmail)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("SELECT TenantPhone, TenantEmail FROM Tenants WHERE TenantPhone='" + tenantPhone + "' OR TenantEmail='" + tenantEmail + "'");
            SqlDataReader reader = dbConnection.DoQuery();
            bool flag = reader.HasRows;
            dbConnection.Dispose();
            dbConnection = null;
            return flag;
        }

        public bool UpdatePassword(string tenantEmail, string tenantPass)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("UPDATE Tenants SET TenantPass='" + tenantPass + "' WHERE TenantEmail='" + tenantEmail + "'");
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

        public bool UpdateTenant(Tenant tenant)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("UPDATE Tenants SET TenantFirstName='"+tenant.TenantFirstName+"',TenantLastName='"+tenant.TenantLastName+"',TenantPhone='"+tenant.TenantPhone+"',TenantEmail='"+tenant.TenantEmail+"',TenantAddress='"+tenant.TenantAddress+"',TenantInstitution='"+tenant.TenantInstitution+"',TenantProfileImage='"+tenant.TenantProfileImage+"',HostelId="+tenant.HostelId+",TenantGender='"+tenant.TenantGender+"' WHERE TenantId="+tenant.TenantId);
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

        public bool DeleteTenant(string tenantId)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("DELETE * FROM Tenants WHERE TenantId="+tenantId);
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
