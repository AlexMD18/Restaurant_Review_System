/*
Alex Drogo
10/22/2020
CIS 3342
Prof. Pascucci
Description: This class is the backend code to the add a new restaurant form. This will process all the information that the user inserts into 
the form and will validate all the information to make sure nothing was missed.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Restaurant_Review_System
{
    public partial class AddRestaurant : System.Web.UI.Page
    {
        StoredProcedures stoPros = new StoredProcedures();
        ValidationRestaurant valRest = new ValidationRestaurant();

        protected void Page_Load(object sender, EventArgs e)
        {
            pnlAddRestaurant.Visible = true;
            pnlAddSuccess.Visible = false;
        }

        protected void ibtnLogo_Click(object sender, ImageClickEventArgs e)
        {

            Response.Redirect("Home.aspx");

        }

        //The user can fill out the form and when they press submit, the information below is checked and send to the database.
        protected void btnAddRestaurant_Click(object sender, EventArgs e)
        {
            string restaurantPic = "";
            string restaurantName = "";
            string restaurantCategory = "";
            string restaurantHours = "";
            string restaurantPhone = "";
            string restaurantStreet = "";
            string restaurantCity = "";
            string restaurantState = "";
            string restaurantZip = "";

            restaurantPic = txtRestaurantPic.Text;
            restaurantName = txtRestaurantName.Text;
            Session["restaurant_nameAdd"] = restaurantName;
            restaurantCategory = ddlRestaurantCategory.Text;
            restaurantHours = txtRestaurantHours.Text;
            restaurantPhone = txtPhone1.Text + "-" + txtPhone2.Text + "-" + txtPhone3.Text;
            restaurantStreet = txtRestaurantAddress.Text;
            restaurantCity = txtRestaurantCity.Text;
            restaurantState = ddlRestaurantState.Text;
            restaurantZip = txtRestaurantZip.Text;

            if (valRest.checkAddRestaurant(txtRestaurantName, ddlRestaurantCategory, txtRestaurantHours, txtPhone1, txtPhone2, txtPhone3, txtRestaurantAddress,
                                           txtRestaurantCity, ddlRestaurantState, txtRestaurantZip) == true)
            {
                int addStatus = stoPros.addNewRestaurant(restaurantPic, restaurantName, restaurantCategory, restaurantHours, restaurantPhone,
                                                         restaurantStreet, restaurantCity, restaurantState, restaurantZip);

                if (addStatus >= 1)
                {
                    pnlAddSuccess.Visible = true;
                    pnlAddRestaurant.Visible = false;
                    if (Session["Rep_Username"] != null)
                    {
                        btnAddRepToRest.Visible = true;
                    }
                }
                else
                {
                    lblError.Text = "*Restaurant not added. Something went wrong*";
                }
            }
            else
            {
                lblError.Text = "*Restaurant not added. Please enter all the information below.*";
            }
        }

        //Clears all textboxes and drop down lists on the form.
        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtRestaurantPic.Text = "";
            txtRestaurantName.Text = "";
            ddlRestaurantCategory.Text = "None Selected...";
            txtRestaurantHours.Text = "";
            txtPhone1.Text = "";
            txtPhone2.Text = "";
            txtPhone3.Text = "";
            txtRestaurantAddress.Text = "";
            txtRestaurantCity.Text = "";
            ddlRestaurantState.Text = "None Selected...";
            txtRestaurantZip.Text = "";
        }

        protected void btnAddRepToRest_Click(object sender, EventArgs e)
        {
            string repUsername = Session["Rep_Username"].ToString();
            string repRestAdd = Session["restaurant_nameAdd"].ToString();
            int addRepStatus = stoPros.insertRep(repRestAdd, repUsername);
            if (addRepStatus >= 1)
            {
                Response.Redirect("Representative.aspx");
            }
        }
    }
}