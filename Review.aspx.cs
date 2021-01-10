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
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

using Utilities;

namespace Restaurant_Review_System
{

    public partial class Review : System.Web.UI.Page
    {
        StoredProcedures stoPros = new StoredProcedures();
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {

                if (Session["Rev_Username"] != null && Session["restaurantID_Review"] == null)
                {
                    gvReviews.Visible = false;
                    gvUserReviews.Visible = true;
                    string user = Session["Rev_Username"].ToString();
                    gvUserReviews.DataSource = stoPros.getUserReviews(user);
                    gvUserReviews.DataBind();

                    btnWriteReview.Enabled = false;
                    btnUserReviewsRevPage.Enabled = true;
                }
                else if(Session["Rev_Username"] == null && Session["restaurantID_Review"] != null)
                {
                    btnWriteReview.Enabled = false;
                    btnUserReviewsRevPage.Enabled = false;
                    gvReviews.Visible = true;
                    gvUserReviews.Visible = false;
                    string sto = Session["restaurantID_Review"].ToString();
                    int reviewNumber = int.Parse(sto);

                    gvReviews.DataSource = stoPros.getReviews(reviewNumber);
                    gvReviews.DataBind();

                    decimal foodAvg = 0;
                    decimal serviceAvg = 0;
                    decimal atmosphereAvg = 0;
                    decimal priceAvg = 0;

                    int numRows = gvReviews.Rows.Count;

                    foreach (GridViewRow row in gvReviews.Rows)
                    {
                        foodAvg += int.Parse(row.Cells[1].Text);
                        serviceAvg += int.Parse(row.Cells[2].Text);
                        atmosphereAvg += int.Parse(row.Cells[3].Text);
                        priceAvg += int.Parse(row.Cells[4].Text);
                    }

                    //Fixes divide by 0 problem
                    if (numRows > 0)
                    {
                        foodAvg = (foodAvg / numRows);
                        serviceAvg = (serviceAvg / numRows);
                        atmosphereAvg = (atmosphereAvg / numRows);
                        priceAvg = (priceAvg / numRows);
                    }
                    gvReviews.Columns[0].FooterText = "Avg: ";
                    gvReviews.Columns[1].FooterText = foodAvg.ToString();
                    gvReviews.Columns[2].FooterText = serviceAvg.ToString();
                    gvReviews.Columns[3].FooterText = atmosphereAvg.ToString();
                    gvReviews.Columns[4].FooterText = priceAvg.ToString();

                    gvReviews.DataBind();
                }
                else
                {
                    btnWriteReview.Enabled = true;
                    btnUserReviewsRevPage.Enabled = true;
                    gvReviews.Visible = true;
                    gvUserReviews.Visible = false;
                    string sto = Session["restaurantID_Review"].ToString();
                    int reviewNumber = int.Parse(sto);

                    gvReviews.DataSource = stoPros.getReviews(reviewNumber);
                    gvReviews.DataBind();

                    decimal foodAvg = 0;
                    decimal serviceAvg = 0;
                    decimal atmosphereAvg = 0;
                    decimal priceAvg = 0;

                    int numRows = gvReviews.Rows.Count;

                    foreach (GridViewRow row in gvReviews.Rows)
                    {
                        foodAvg += int.Parse(row.Cells[1].Text);
                        serviceAvg += int.Parse(row.Cells[2].Text);
                        atmosphereAvg += int.Parse(row.Cells[3].Text);
                        priceAvg += int.Parse(row.Cells[4].Text);
                    }

                    //Fixes divide by 0 problem
                    if (numRows > 0)
                    {
                        foodAvg = (foodAvg / numRows);
                        serviceAvg = (serviceAvg / numRows);
                        atmosphereAvg = (atmosphereAvg / numRows);
                        priceAvg = (priceAvg / numRows);
                    }
                    gvReviews.Columns[0].FooterText = "Avg: ";
                    gvReviews.Columns[1].FooterText = foodAvg.ToString();
                    gvReviews.Columns[2].FooterText = serviceAvg.ToString();
                    gvReviews.Columns[3].FooterText = atmosphereAvg.ToString();
                    gvReviews.Columns[4].FooterText = priceAvg.ToString();

                    gvReviews.DataBind();
                }
            }
        }

        protected void ibtnLogo_Click(object sender, ImageClickEventArgs e)
        {
            Session["restaurantID_Review"] = null;
            Response.Redirect("Home.aspx");
        }

        protected void btnWriteReview_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddReview.aspx");
        }

        protected void btnUserReviews_Click(object sender, EventArgs e)
        {
            gvReviews.Visible = false;
            gvUserReviews.Visible = true;

            string user = Session["Rev_Username"].ToString();
            gvUserReviews.DataSource = stoPros.getUserReviews(user);
            gvUserReviews.DataBind();
        }

        protected void btnReviewModify_Click(object sender, EventArgs e)
        {
            Button revModButton = (Button)sender;
            GridViewRow gvRow = (GridViewRow)revModButton.NamingContainer;

            pnlEditReview.Visible = true;

            Session["ReviewID"] = gvRow.Cells[0].Text;
            Session["ReviewRestName"] = gvRow.Cells[1].Text;
            string foodRating = gvRow.Cells[2].Text;
            rdioBLReviewFood.SelectedValue = foodRating;
            string serviceRating = gvRow.Cells[3].Text;
            rdioBLReviewService.SelectedValue = serviceRating;
            string atmosphereRating = gvRow.Cells[4].Text;
            rdioBLReviewAtmosphere.SelectedValue = atmosphereRating;
            string priceRating = gvRow.Cells[5].Text;
            rdioBLReviewPrice.SelectedValue = priceRating;
            string reviewComments = gvRow.Cells[6].Text;
            txtarReviewComments.Value = reviewComments;
            Session["ReviewerUserame"] = gvRow.Cells[7].Text;
            Session["RestaurantID"] = gvRow.Cells[8].Text;

            string restName = Session["ReviewRestName"].ToString();
            lblRevTitle.Text = restName;
        }

        protected void btnReviewDelete_Click(object sender, EventArgs e)
        {
            Button revDelButton = (Button)sender;
            GridViewRow gvRow = (GridViewRow)revDelButton.NamingContainer;

            string delRev = gvRow.Cells[0].Text;
            int delRevID = int.Parse(delRev.ToString());

            int result = stoPros.deleteReview(delRevID);

            gvUserReviews.Visible = true;
            string user = Session["Rev_Username"].ToString();

            gvUserReviews.DataSource = stoPros.getUserReviews(user);
            gvUserReviews.DataBind();
        }

        protected void btnSubmitReview_Click(object sender, EventArgs e)
        {
            int reviewID = 0;
            int food = 0;
            int service = 0;
            int atmosphere = 0;
            int price = 0;
            string comments = "";
            int restaurantID = 0;
            string restaurantName = "";
            string reviewerUsername = "";

            string reviewIDString = Session["ReviewID"].ToString();
            reviewID = int.Parse(reviewIDString);
            string foodString = rdioBLReviewFood.SelectedValue;
            food = int.Parse(foodString);
            string serviceString = rdioBLReviewService.SelectedValue;
            service = int.Parse(serviceString);
            string atmosphereString = rdioBLReviewAtmosphere.SelectedValue;
            atmosphere = int.Parse(atmosphereString);
            string priceString = rdioBLReviewPrice.SelectedValue;
            price = int.Parse(priceString);
            comments = txtarReviewComments.Value;
            string restaurantIDString = Session["RestaurantID"].ToString();
            restaurantID = int.Parse(restaurantIDString);
            restaurantName = Session["ReviewRestName"].ToString();
            reviewerUsername = Session["Rev_Username"].ToString();


            if (txtarReviewComments.Value != "")
            {
                int editStatus = stoPros.updateReview(reviewID, food, service, atmosphere, price, comments, restaurantID, restaurantName, reviewerUsername);

                if (editStatus >= 1)
                {
                    string user = Session["Rev_Username"].ToString();
                    gvUserReviews.DataSource = stoPros.getUserReviews(user);
                    gvUserReviews.DataBind();

                    pnlEditReview.Visible = false;

                }
                else
                {
                    lblEditRevError.Text = "*Something went wrong*";
                }

                
            }
            else
            {
                lblEditRevError.Text = "You are missing information below.";
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