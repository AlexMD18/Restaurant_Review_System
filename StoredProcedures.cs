/*
Alex Drogo
10/22/2020
CIS 3342
Prof. Pascucci
Description: This class is compliled full of all of the code that connects the stored procedures that perform SQL tasks, with the backend and 
front end code.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

using Utilities;

namespace Restaurant_Review_System
{
    public class StoredProcedures
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        string strSQL;

        //Gets all reults for the homepage
        public DataSet getAllResults()
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetAllRestaurants";

            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);

            return myDS;
        }

        //Gets all reviews for one restaurant using the restaurant's ID
        public DataSet getReviews(int restID)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetReviews";

            SqlParameter inputParameter = new SqlParameter("@Rest_ID", restID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;

            objCommand.Parameters.Add(inputParameter);

            DBConnect objDB = new DBConnect();
            DataSet myDS;
            myDS = objDB.GetDataSetUsingCmdObj(objCommand);

            return myDS;
        }

        //Gets all reviews that a particular user wrote
        public DataSet getUserReviews(string username)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetUserReviews";

            SqlParameter inputParameter = new SqlParameter("@Username", username);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;

            objCommand.Parameters.Add(inputParameter);

            DBConnect objDB = new DBConnect();
            DataSet myDS;
            myDS = objDB.GetDataSetUsingCmdObj(objCommand);

            return myDS;
        }

        //Get the restaurant that the representative is associated with
        public DataSet getRestRep(string username)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetRestByRep";

            SqlParameter inputParameter = new SqlParameter("@RepUsername", username);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;

            objCommand.Parameters.Add(inputParameter);

            DBConnect objDB = new DBConnect();
            DataSet myDS;
            myDS = objDB.GetDataSetUsingCmdObj(objCommand);

            return myDS;
        }

        //Get all reservations for a restaurant using the restaurant ID
        public DataSet getRestReservations(int restID)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetRestReservations";

            SqlParameter inputParameter = new SqlParameter("@RestaurantID", restID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;

            objCommand.Parameters.Add(inputParameter);

            DBConnect objDB = new DBConnect();
            DataSet myDS;
            myDS = objDB.GetDataSetUsingCmdObj(objCommand);

            return myDS;
        }

        //Search for a restaurant by its name
        public DataSet searchName(string name)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "SearchByName";

            SqlParameter inputParameter = new SqlParameter("@searchName", name);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;

            objCommand.Parameters.Add(inputParameter);

            DBConnect objDB = new DBConnect();
            DataSet myDS;
            myDS = objDB.GetDataSetUsingCmdObj(objCommand);

            return myDS;
        }

        //Search for a restaurant by its ddl category
        public DataSet searchCategory(string category)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "SearchByCategory";

            SqlParameter inputParameter = new SqlParameter("@searchCategory", category);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;

            objCommand.Parameters.Add(inputParameter);

            DBConnect objDB = new DBConnect();
            DataSet myDS;
            myDS = objDB.GetDataSetUsingCmdObj(objCommand);

            return myDS;
        }

        //Search for restaurant by city
        public DataSet searchCity(string city)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "SearchByCity";

            SqlParameter inputParameter = new SqlParameter("@searchCity", city);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;

            objCommand.Parameters.Add(inputParameter);

            DBConnect objDB = new DBConnect();
            DataSet myDS;
            myDS = objDB.GetDataSetUsingCmdObj(objCommand);

            return myDS;
        }

        //Search for restaurant by state
        public DataSet searchState(string state)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "SearchByState";

            SqlParameter inputParameter = new SqlParameter("@searchState", state);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;

            objCommand.Parameters.Add(inputParameter);

            DBConnect objDB = new DBConnect();
            DataSet myDS;
            myDS = objDB.GetDataSetUsingCmdObj(objCommand);

            return myDS;
        }

        //Search for restaurant id by name
        public DataSet searchRestByUsername(string restaurantName)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "SearchRestByUsername";

            SqlParameter inputParameter = new SqlParameter("@restaurant_name", restaurantName);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;

            objCommand.Parameters.Add(inputParameter);

            DBConnect objDB = new DBConnect();
            DataSet myDS;
            myDS = objDB.GetDataSetUsingCmdObj(objCommand);

            return myDS;
        }

        //This method searches the DB for a username in the username column within the representitives table. If one is found
        //then the true/false flag will be changed from false to true indicating that the username was found.
        public Boolean searchRepLogin(string loginID)
        {
            Boolean found = false;
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "SearchRepUsername";

            SqlParameter inputParameter = new SqlParameter("@repUsername", loginID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;

            objCommand.Parameters.Add(inputParameter);

            DBConnect objDB = new DBConnect();
            DataSet myDS;
            myDS = objDB.GetDataSetUsingCmdObj(objCommand);

            if(myDS.Tables[0].Rows.Count >= 1)
            {
                found = true;
            }
            else
            {
                found = false;
            }

            return found;
        }

        //Checks to see if the representative is already representing a restaurant.
        public Boolean searchRepForRestaurant(string loginID)
        {
            Boolean found = false;
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "SearchRepForRest";

            SqlParameter inputParameter = new SqlParameter("@RepUsername", loginID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;

            objCommand.Parameters.Add(inputParameter);

            DBConnect objDB = new DBConnect();
            DataSet myDS;
            myDS = objDB.GetDataSetUsingCmdObj(objCommand);

            if (myDS.Tables[0].Rows.Count >= 1)
            {
                found = true;
            }
            else
            {
                found = false;
            }

            return found;
        }

        //This method searches the DB for a username in the username column within the reviewer table. If one is found
        //then the true/false flag will be changed from false to true indicating that the username was found.
        public Boolean searchRevLogin(string loginID)
        {
            Boolean found = false;
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "SearchRevUsername";

            SqlParameter inputParameter = new SqlParameter("@revUsername", loginID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;

            objCommand.Parameters.Add(inputParameter);

            DBConnect objDB = new DBConnect();
            DataSet myDS;
            myDS = objDB.GetDataSetUsingCmdObj(objCommand);

            if (myDS.Tables[0].Rows.Count >= 1)
            {
                found = true;
            }
            else
            {
                found = false;
            }

            return found;
        }

        
        //Adds new restaurant to database
        public int addNewRestaurant(string image, string name, string category, string hours, string phone, string street,
                                    string city, string state, string zip)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "AddRestaurant";

            SqlParameter inputParameter = new SqlParameter("@Restaurant_Pic", image);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Restaurant_Name", name);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Restaurant_Category", category);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Restaurant_Phone", phone);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Restaurant_Hours", hours);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Restaurant_Street", street);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Restaurant_City", city);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Restaurant_State", state);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Restaurant_Zip", zip);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            DBConnect objDB = new DBConnect();
            return objDB.DoUpdateUsingCmdObj(objCommand);
        }

        //Adds new reviewer to database
        public int addNewReviewer(string username, string fname, string lname)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "AddReviewer";

            SqlParameter inputParameter = new SqlParameter("@Reviewer_Username", username);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Reviewer_FName", fname);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Reviewer_LName", lname);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            DBConnect objDB = new DBConnect();
            return objDB.DoUpdateUsingCmdObj(objCommand);
        }

        //Adds new representative to a restaurant
        public int addNewRep(string username, string fname, string lname)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "AddRepresentative";

            SqlParameter inputParameter = new SqlParameter("@Representative_Username", username);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Representative_FName", fname);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Representative_LName", lname);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            DBConnect objDB = new DBConnect();
            return objDB.DoUpdateUsingCmdObj(objCommand);
        }

        //Adds a new reservation to the database
        public int addNewReservation(string fname, string lname, string time, string date, int restID)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "AddReservation";

            SqlParameter inputParameter = new SqlParameter("@ReservationFName", fname);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@ReservationLName", lname);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@ReservationTime", time);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@ReservationDate", date);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@RestaurantID", restID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            DBConnect objDB = new DBConnect();
            return objDB.DoUpdateUsingCmdObj(objCommand);
        }

        //Adds a new review to the database
        public int addReview(int revFood, int revService, int reviewAtmosphere, int reviewPrice, string reviewComments, int restID, 
                             string restName, string revUser)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "AddReview";

            SqlParameter inputParameter = new SqlParameter("@Review_Food", revFood);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Review_Service", revService);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Review_Atmosphere", reviewAtmosphere);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Review_Price", reviewPrice);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Review_Comments", reviewComments);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Restaurant_Name", restName);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Restaurant_ID", restID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Reviewer_Username", revUser);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            DBConnect objDB = new DBConnect();
            return objDB.DoUpdateUsingCmdObj(objCommand);
        }

        //Delete reveiw from database
        public int deleteReview(int revID)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "DeleteReview";

            SqlParameter inputParameter = new SqlParameter("@RevID", revID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(inputParameter);

            DBConnect objDB = new DBConnect();
            return objDB.DoUpdateUsingCmdObj(objCommand);
        }

        //Delete reservation from database
        public int deleteReservation(int resID)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "DeleteReservation";

            SqlParameter inputParameter = new SqlParameter("@ResID", resID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(inputParameter);

            DBConnect objDB = new DBConnect();
            return objDB.DoUpdateUsingCmdObj(objCommand);
        }

        //Update reservation with new information
        public int updateReservation(int reservationID, string fname, string lname, string time, string date, int restaurantID)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "UpdateReservations";

            SqlParameter inputParameter = new SqlParameter("@resID", reservationID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@fname", fname);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@lname", lname);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@time", time);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@date", date);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@restID", restaurantID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            DBConnect objDB = new DBConnect();
            return objDB.DoUpdateUsingCmdObj(objCommand);
        }

        //Update review with new information
        public int updateReview(int reviewID, int revFood, int revService, int revAtmosphere, int revPrice, string revComments, int restID,
                                string restName, string reviewerUsername)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "UpdateReviews";

            SqlParameter inputParameter = new SqlParameter("@reviewID", reviewID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@reviewFood", revFood);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@reviewService", revService);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@reviewAtmosphere", revAtmosphere);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@reviewPrice", revPrice);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@reviewComments", revComments);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@restaurantID", restID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@restaurantName", restName);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@reviewerUsername", reviewerUsername);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            DBConnect objDB = new DBConnect();
            return objDB.DoUpdateUsingCmdObj(objCommand);
        }

        //Update restaurant with new information
        public int updateRestaurant(int restID, string image, string name, string category, string hours, string phone, string street,
                                    string city, string state, string zip, string restRep)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "UpdateRestaurant";

            SqlParameter inputParameter = new SqlParameter("@Restaurant_ID", restID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Restaurant_Pic", image);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Restaurant_Name", name);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Restaurant_Category", category);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Restaurant_Phone", phone);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Restaurant_Hours", hours);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Restaurant_Street", street);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Restaurant_City", city);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Restaurant_State", state);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Restaurant_Zip", zip);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Restaurant_Rep", restRep);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            DBConnect objDB = new DBConnect();
            return objDB.DoUpdateUsingCmdObj(objCommand);
        }

        //Add rep to restaurant
        public int insertRep(string restName, string username)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "InsertRepresentative";

            SqlParameter inputParameter = new SqlParameter("@Restaurant_Name", restName);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@RepUsername", username);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            DBConnect objDB = new DBConnect();
            return objDB.DoUpdateUsingCmdObj(objCommand);
        }
    }
}