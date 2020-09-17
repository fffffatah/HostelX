using DatabaseOperationlib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLib
{
    public class NoticesDataAccess
    {
        DatabaseConnection dbConnection;

        public bool CreateNotice(Notices notices)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("INSERT INTO Notices(Notice, Date, HostelId) VALUES ('" + notices.Notice + "','" + notices.Date + "'," + notices.HostelId + ")");
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

        public List<Notices> GetNotices(string hostelId)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("SELECT * FROM Notices WHERE HostelId="+hostelId);
            List <Notices> notices = new List<Notices>();
            SqlDataReader reader = dbConnection.DoQuery();
            while (reader.Read())
            {
                Notices notice = new Notices();
                notice.NoticeId = reader["NoticeId"].ToString();
                notice.Notice = reader["Notice"].ToString();
                notice.Date = reader["Date"].ToString();
                notice.HostelId = reader["HostelId"].ToString();
                notices.Add(notice);
            }
            dbConnection.Dispose();
            dbConnection = null;
            return notices;
        }

        public bool UpdateNotice(Notices notices)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("UPDATE Notices SET Notice='"+notices.Notice+"' WHERE NoticeId="+notices.NoticeId);
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

        public bool DeleteNotice(string noticeId)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("DELETE * FROM Notices WHERE NoticeId="+noticeId);
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
