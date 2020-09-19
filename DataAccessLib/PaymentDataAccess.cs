using DatabaseOperationlib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLib
{
    public class PaymentDataAccess
    {
        DatabaseConnection dbConnection;

        public bool CreatePayment(Payment payment)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("INSERT INTO Payments(DUE, PAID, TENANTID, BALANCE, PAYMENTDATE) VALUES ('" + payment.Due + "','" + payment.Paid + "'," + payment.TenantId + "," + payment.Balance + ",'" + payment.PaymentDate + "')");
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

        public List<Payment> GetPayments(string tenantId)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("SELECT * FROM Payments WHERE TenantId="+tenantId);
            List<Payment> payments = new List<Payment>();
            SqlDataReader reader = dbConnection.DoQuery();
            while (reader.Read())
            {
                Payment payment = new Payment();
                payment.PaymentId = reader["PaymentId"].ToString();
                payment.Due = reader["Due"].ToString();
                payment.Paid = reader["Paid"].ToString();
                payment.Balance = reader["Balance"].ToString();
                payment.PaymentDate = reader["PaymentDate"].ToString();
                payment.TenantId = reader["TenantId"].ToString();
                payments.Add(payment);
            }
            dbConnection.Dispose();
            dbConnection = null;
            return payments;
        }

        public bool UpdatePayment(Payment payment)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("UPDATE Payments SET Due='" + payment.Due + "', Paid='" + payment.Paid + "', Balance=" + payment.Balance + ", PaymentDate='" + payment.PaymentDate + "' WHERE PaymentId"+payment.PaymentId);
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
