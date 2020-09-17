using DatabaseOperationlib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLib
{
    public class FoodDataAccess
    {
        DatabaseConnection dbConnection;

        public bool CreateFood(Food food)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("INSERT INTO Foods(FOODITEM, QUANTITY, ADMINID) VALUES ('"+food.FoodItem+"',"+food.FoodQuantity+","+food.AdminId+")");
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

        public List<Food> GetFoods(string adminId)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("SELECT * FROM Foods WHERE AdminId="+adminId);
            List<Food> foods = new List<Food>();
            SqlDataReader reader = dbConnection.DoQuery();
            while (reader.Read())
            {
                Food food = new Food();
                food.FoodId = reader["FoodId"].ToString();
                food.FoodItem = reader["FoodItem"].ToString();
                food.FoodQuantity = reader["FoodQuantity"].ToString();
                food.AdminId = reader["AdminId"].ToString();
                foods.Add(food);
            }
            dbConnection.Dispose();
            dbConnection = null;
            return foods;
        }

        public bool UpdateFood(Food food)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("UPDATE Foods SET FoodItem='"+food.FoodItem+"',FoodQuantity="+food.FoodQuantity);
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

        public bool UpdateFoodQuantity(Food food)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("UPDATE Foods SET FoodQuantity=FoodQuantity-" + food.FoodQuantity + " WHERE FoodId=" + food.FoodId);
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

        public bool DeleteFood(string foodId)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("DELETE * FROM Foods WHERE FoodId=" + foodId);
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
