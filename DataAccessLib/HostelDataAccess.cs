using DatabaseOperationlib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLib
{
    public class HostelDataAccess
    {
        DatabaseConnection dbConnection;

        public bool CreateHostel(Hostel hostel)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("INSERT INTO Hostels(HostelName, HostelAddress, HostelType, HostelCapacity, AdminId) VALUES ('" + hostel.HostelName + "','" + hostel.HostelAddress + "','" + hostel.HostelType + "','" + hostel.HostelCapacity + "'," + hostel.AdminId + ")");
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

        public List<Hostel> GetHostels(string adminId)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("SELECT * FROM Hostels WHERE AdminId="+adminId);
            List<Hostel> hostels = new List<Hostel>();
            SqlDataReader reader = dbConnection.DoQuery();
            while (reader.Read())
            {
                Hostel hostel =new Hostel();
                hostel.HostelId = reader["HostelId"].ToString();
                hostel.HostelName = reader["HostelName"].ToString();
                hostel.HostelAddress = reader["HostelAddress"].ToString();
                hostel.HostelType = reader["HostelType"].ToString();
                hostel.HostelCapacity = reader["HostelCapacity"].ToString();
                hostel.AdminId = reader["AdminId"].ToString();
                hostels.Add(hostel);
            }
            dbConnection.Dispose();
            dbConnection = null;
            return hostels;
        }

        public Hostel GetHostel(string hostelId)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("SELECT * FROM Hostels WHERE HostelId="+hostelId);
            SqlDataReader reader = dbConnection.DoQuery();
            Hostel hostel = new Hostel();
            while (reader.Read())
            {
                hostel.HostelId = reader["HostelId"].ToString();
                hostel.HostelName = reader["HostelName"].ToString();
                hostel.HostelAddress = reader["HostelAddress"].ToString();
                hostel.HostelType = reader["HostelType"].ToString();
                hostel.HostelCapacity = reader["HostelCapacity"].ToString();
                hostel.AdminId = reader["AdminId"].ToString();
            }
            dbConnection.Dispose();
            dbConnection = null;
            return hostel;
        }

        public bool UpdateHostel(Hostel hostel)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("UPDATE Hostels SET HostelName='" + hostel.HostelName + "', HostelAddress='" + hostel.HostelAddress + "', HostelType='" + hostel.HostelType + "', HostelCapacity='" + hostel.HostelCapacity + "' WHERE HostelId=" + hostel.HostelId);
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

        public bool DeleteHostel(string hostelId)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("DELETE FROM Hostels WHERE HostelId="+hostelId);
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
