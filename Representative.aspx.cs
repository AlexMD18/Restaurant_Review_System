/*
Alex Drogo
10/22/2020
CIS 3342
Prof. Pascucci
Description: This class is the backend code to the main representatives page. This page will allow them to manage their restaurant information.
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace Restaurant_Review_System
{
    public partial class Representitive : System.Web.UI.Page
    {
        StoredProcedures stoPros = new StoredProcedures();
        ValidationRestaurant valRes = new ValidationRestaurant();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DBConnect objDB = new DBConnect();
                SqlCommand objCommand = new SqlCommand();

                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "GetNoRepRestaurants";

                DataSet myDS;
                myDS = objDB.GetDataSetUsingCmdObj(objCommand);
                string repUsername = Session["Rep_Username"].ToString();

                if (stoPros.searchRepForRestaurant(repUsername) == true)
                {
                    pnlChooseRestaurant.Visible = false;
                }
                else
                {
                    pnlChooseRestaurant.Visible = true;

                    ddlChooseRepRestaurant.DataSource = myDS;
                    ddlChooseRepRestaurant.DataTextField = "Restaurant_Name";
                    ddlChooseRepRestaurant.DataBind();
                }

                gvRepRestaurants.DataSource = stoPros.getRestRep(repUsername);
                gvRepRestaurants.DataBind();
            }
        }

        protected void ibtnLogo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Home.aspx");

        }

        protected void btnRepresentitiveRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewUser.aspx");
        }

        protected void btnChooseRepRestaurant_Click(object sender, EventArgs e)
        {
            string restaurantName = ddlChooseRepRestaurant.Text;
            string repUsername = Session["Rep_Username"].ToString();
            int addStatus = stoPros.insertRep(restaurantName, repUsername);
            if (addStatus >= 1)
            {
                pnlChooseRestaurant.Visible = false;
                pnlChooseRestaurantSuccess.Visible = true;
                lblRestName.Text = restaurantName;
                pnlRepRestaurant.Visible = true;
                gvRepRestaurants.DataSource = stoPros.getRestRep(repUsername);
                gvRepRestaurants.DataBind();

            }
            else
            {
                lblError.Text = "*Restaurant not added. You are missing or entered incorrect information*";
            }
        }

        protected void btnAllRestReservations_Click(object sender, EventArgs e)
        {
            pnlEditRestaurant.Visible = false;
            pnlReservationTitle.Visible = true;

            Button viewResButton = (Button)sender;
            GridViewRow gvRow = (GridViewRow)viewResButton.NamingContainer;

            Session["restaurantID_Res"] = gvRow.Cells[1].Text;
            string restIDString = Session["restaurantID_Res"].ToString();
            int restID = int.Parse(restIDString);
            lblReservationTitle.Visible = true;
            gvRestaurantReservations.DataSource = stoPros.getRestReservations(restID);
            gvRestaurantReservations.DataBind();
        }

        protected void btnEditRestaurant_Click(object sender, EventArgs e)
        {
            pnlEditReservation.Visible = false;
            pnlEditRestaurant.Visible = true;
            pnlReservationTitle.Visible = false;

            Button editResButton = (Button)sender;
            GridViewRow gvRow = (GridViewRow)editResButton.NamingContainer;

            string editRestImageString = gvRow.Cells[0].Text;
            txtEditRestaurantPic.Text = editRestImageString;

            Session["restaurantID_Edit"] = gvRow.Cells[1].Text;

            string editRestNameString = gvRow.Cells[2].Text;
            txtEditRestaurantName.Text = editRestNameString;

            string editRestCategoryString = gvRow.Cells[3].Text;
            ddlEditRestaurantCategory.Text = editRestCategoryString;

            string editRestHoursString = gvRow.Cells[4].Text;
            txtEditRestaurantHours.Text = editRestHoursString;

            string editRestAddressString = gvRow.Cells[6].Text;
            txtEditRestaurantAddress.Text = editRestAddressString;

            string editRestCityString = gvRow.Cells[7].Text;
            txtEditRestaurantCity.Text = editRestCityString;

            string editRestZipString = gvRow.Cells[9].Text;
            txtEditRestaurantZip.Text = editRestZipString;

            pnlEditRestaurant.Visible = true;
        }

        protected void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            Button deleteRes = (Button)sender;
            GridViewRow gvRow = (GridViewRow)deleteRes.NamingContainer;

            string deleteResIDString = gvRow.Cells[0].Text;
            int deleteResID = int.Parse(deleteResIDString);

            int result = stoPros.deleteReservation(deleteResID);

            string restIDString = Session["restaurantID_Res"].ToString();
            int restID = int.Parse(restIDString);

            gvRestaurantReservations.DataSource = stoPros.getRestReservations(restID);
            gvRestaurantReservations.DataBind();
        }

        protected void btnEditReservation_Click(object sender, EventArgs e)
        {
            pnlEditRestaurant.Visible = false;
            pnlEditReservation.Visible = true;

            Button editRes = (Button)sender;
            GridViewRow gvRow = (GridViewRow)editRes.NamingContainer;

            Session["editReservationID"] = gvRow.Cells[0].Text;

            string editResFNameString = gvRow.Cells[1].Text;
            txtEditResFName.Text = editResFNameString;

            string editResLNameString = gvRow.Cells[2].Text;
            txtEditResLName.Text = editResLNameString;

            string editResTimeString = gvRow.Cells[3].Text;
            txtEditResTime.Text = editResTimeString;

            string editResDateString = gvRow.Cells[4].Text;
            txtEditResDate.Text = editResDateString;
        }

        protected void btnEditSubmit_Click(object sender, EventArgs e)
        {
            int reservationID = 0;
            string firstName = "";
            string lastName = "";
            string time = "";
            string date = "";
            int restaurantID = 0;

            string resIDString = Session["editReservationID"].ToString();
            reservationID = int.Parse(resIDString);
            firstName = txtEditResFName.Text;
            lastName = txtEditResLName.Text;
            time = txtEditResTime.Text;
            date = txtEditResDate.Text;
            string restIDString = Session["restaurantID_Res"].ToString();
            restaurantID = int.Parse(restIDString);

            if (valRes.checkEditReservation(txtEditResFName, txtEditResLName, txtEditResTime, txtEditResDate) == true)
            {
                int editStatus = stoPros.updateReservation(reservationID, firstName, lastName, time, date, restaurantID);

                if (editStatus >= 1)
                {
                    int restID = int.Parse(restIDString);
                    gvRestaurantReservations.DataSource = stoPros.getRestReservations(restID);
                    gvRestaurantReservations.DataBind();
                    pnlEditReservation.Visible = false;
                }
                else
                {
                    lblError2.Text = "*Reservation not edited. You are missing or entered incorrect information*";
                }

            }
            else
            {
                lblError2.Text = "*Reservation not edited. Please enter all the information below.*";
            }
            
        }

        //This method does the update when the user chooses to edit a restaurants information
        protected void btnEditRestSubmit_Click(object sender, EventArgs e)
        {
            int restaurantID = 0;
            string restaurantPic = "";
            string restaurantName = "";
            string restaurantCategory = "";
            string restaurantHours = "";
            string restaurantPhone = "";
            string restaurantStreet = "";
            string restaurantCity = "";
            string restaurantState = "";
            string restaurantZip = "";
            string restaurantRep = "";

            string restaurantIDString = Session["restaurantID_Edit"].ToString();
            restaurantID = int.Parse(restaurantIDString);
            restaurantPic = txtEditRestaurantPic.Text;
            restaurantName = txtEditRestaurantName.Text;
            restaurantCategory = ddlEditRestaurantCategory.Text;
            restaurantHours = txtEditRestaurantHours.Text;
            restaurantPhone = txtEditPhone1.Text + "-" + txtEditPhone2.Text + "-" + txtEditPhone3.Text;
            restaurantStreet = txtEditRestaurantAddress.Text;
            restaurantCity = txtEditRestaurantCity.Text;
            restaurantState = ddlEditRestaurantState.Text;
            restaurantZip = txtEditRestaurantZip.Text;
            restaurantRep = Session["Rep_Username"].ToString();

            if (valRes.checkAddRestaurant(txtEditRestaurantName, ddlEditRestaurantCategory, txtEditRestaurantHours, txtEditPhone1, txtEditPhone2,
                                          txtEditPhone3, txtEditRestaurantAddress, txtEditRestaurantCity, ddlEditRestaurantState, txtEditRestaurantZip) == true)
            {
                int editStatus = stoPros.updateRestaurant(restaurantID, restaurantPic, restaurantName, restaurantCategory, restaurantHours,
                                                      restaurantPhone, restaurantStreet, restaurantCity, restaurantState, restaurantZip, restaurantRep);

                if (editStatus >= 1)
                {
                    string repUsername = Session["Rep_Username"].ToString();
                    gvRepRestaurants.DataSource = stoPros.getRestRep(repUsername);
                    gvRepRestaurants.DataBind();
                }
                else
                {
                    lblError3.Text = "*Restaurant not edited. Something went wrong*";
                }
            }
            else
            {
                lblError3.Text = "*Restaurant not edited. Please enter all the information below.*";
            }
        }

        protected void btnEditClear_Click(object sender, EventArgs e)
        {
            txtEditResFName.Text = "";
            txtEditResLName.Text = "";
            txtEditResDate.Text = "";
            txtEditResTime.Text = "";
        }

        protected void btnEditRestClear_Click(object sender, EventArgs e)
        {
            txtEditRestaurantPic.Text = "";
            txtEditRestaurantName.Text = "";
            txtEditRestaurantAddress.Text = "";
            txtEditRestaurantCity.Text = "";
            txtEditRestaurantHours.Text = "";
            txtEditPhone1.Text = "";
            txtEditPhone2.Text = "";
            txtEditPhone3.Text = "";
            ddlEditRestaurantCategory.Text = "None Selected...";
            ddlEditRestaurantState.Text = "None Selected...";
            txtEditRestaurantZip.Text = "";
        }
    }
}