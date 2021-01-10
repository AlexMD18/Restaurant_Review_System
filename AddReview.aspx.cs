/*
Alex Drogo
10/22/2020
CIS 3342
Prof. Pascucci
Description: This class is the backend code to the homepage. This is the page that users are initally met with when they navigate to the site.
This is also the page that they will be redirected to when they press the logo at the top left corner of the screen.
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Restaurant_Review_System
{
    public partial class AddReview : System.Web.UI.Page
    {
        StoredProcedures stoPros = new StoredProcedures();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ibtnLogo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnSubmitReview_Click(object sender, EventArgs e)
        {
            string revFood = "";
            string revService = "";
            string revAtmosphere = "";
            string revPrice = "";
            string revComments = "";
            int restID = 0;
            string restName = "";
            string revUser = "";

            revFood = rdioBLReviewFood.SelectedItem.Text;
            revService = rdioBLReviewService.SelectedItem.Text;
            revAtmosphere = rdioBLReviewAtmosphere.SelectedItem.Text;
            revPrice = rdioBLReviewPrice.SelectedItem.Text;
            revComments = txtarReviewComments.Value;
            string restIDString = Session["restaurantID_Review"].ToString();
            restID = int.Parse(restIDString);
            restName = Session["restaurantName_Review"].ToString();
            revUser = Session["Rev_Username"].ToString();

            int addRevFood = int.Parse(revFood);
            int addRevService = int.Parse(revService);
            int addRevAtmosphere = int.Parse(revAtmosphere);
            int addRevPrice = int.Parse(revPrice);

            if (txtarReviewComments.Value != "")
            {

                int addStatus = stoPros.addReview(addRevFood, addRevService, addRevAtmosphere, addRevPrice, revComments, restID, restName, revUser);

                if (addStatus >= 1)
                {
                    Response.Redirect("Review.aspx");

                }
                else
                {
                    lblAddRevError.Text = "*Restaurant not added. Something went wrong*";
                }

            }
            else
            {
                lblAddRevError.Text = "You are missing information below.";
            }
        }

        protected void btnClearReview_Click(object sender, EventArgs e)
        {
            rdioBLReviewFood.ClearSelection();
            rdioBLReviewAtmosphere.ClearSelection();
            rdioBLReviewService.ClearSelection();
            rdioBLReviewPrice.ClearSelection();
            txtarReviewComments.Value = "";
        }
    }
}