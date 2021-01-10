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
    public partial class Log_In : System.Web.UI.Page
    {
        StoredProcedures stoPros = new StoredProcedures();
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Displays the entire list of restaurants in the database
            if (!Page.IsPostBack)
            {
                if(Session["Rep_Username"] != null)
                {
                    string repUName = Session["Rep_Username"].ToString();
                    lblLogin.Visible = true;
                    txtLogin.Visible = true;
                    btnLogin.Visible = true;
                    txtLogin.Text = repUName;
                    ddlPersonType.Text = "Representative";
                    btnAddRestaurant.Enabled = true;
                    btnRepresentitives.Enabled = true;
                    btnAddUser.Enabled = false;
                    btnUserReviews.Enabled = false;
                }
                else if(Session["Rev_Username"] != null)
                {
                    string revUName = Session["Rev_Username"].ToString();
                    lblLogin.Visible = true;
                    txtLogin.Visible = true;
                    btnLogin.Visible = true;
                    txtLogin.Text = revUName;
                    ddlPersonType.Text = "Reviewer";
                    btnAddRestaurant.Enabled = true;
                    btnRepresentitives.Enabled = false;
                    btnAddUser.Enabled = false;
                    btnUserReviews.Enabled = true;
                }

                gvHome.DataSource = stoPros.getAllResults();
                gvHome.DataBind();
            }
        }

        //Page Redirects Start

        //Directs user to the Add Review page This only available to users signed in as a reviewer
        protected void btnWriteReview_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddReview.aspx");
        }

        //Directs the user to the representative management page. This is only available to representatives who signed in with their username
        protected void btnRepresentitives_Click(object sender, EventArgs e)
        {
            Response.Redirect("Representative.aspx");
        }

        //Directs the user to the Add Restaurant page. This is available to both reviewers and representatives
        protected void btnAddRestaurant_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddRestaurant.aspx");
        }

        //Allows a visitor to sign-up to become a member of the site
        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewUser.aspx");
        }

        //Redirects the user back to the homepage
        protected void ibtnLogo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Home.aspx");

        }

        //Allows the reviewer to see all the reviews they have written on the site
        protected void btnUserReviews_Click(object sender, EventArgs e)
        {
            Response.Redirect("Review.aspx");
        }

        //Page Redirects End

        //Changes level of access on the homepage
        protected void ddlPersonType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlPersonType.Text == "Visitor")
            {
                btnAddRestaurant.Enabled = false;
                btnRepresentitives.Enabled = false;
                lblLogin.Visible = false;
                txtLogin.Visible = false;
                btnLogin.Visible = false;
                btnAddUser.Enabled = true;
            }
            else if(ddlPersonType.Text == "Representative" || ddlPersonType.Text == "Reviewer")
            {
                lblLogin.Visible = true;
                txtLogin.Visible = true;
                btnLogin.Visible = true;
                txtLogin.Text = "";
            }
            
        }

        protected void btnReview_Click(object sender, EventArgs e)
        {
            Button resButton = (Button)sender;
            GridViewRow gvRow = (GridViewRow)resButton.NamingContainer;

            Session["restaurantID_Review"] = gvRow.Cells[1].Text;
            Session["restaurantName_Review"] = gvRow.Cells[2].Text;
            Response.Redirect("Review.aspx");
        }

        //This button is used to make a reservation at a particular restaurant. When the user clicks on a button it will retrieve the information 
        protected void btnMakeReservation_Click(object sender, EventArgs e)
        {
            Button resButton = (Button)sender;
            GridViewRow gvRow = (GridViewRow)resButton.NamingContainer;

            Session["restaurantID"] = gvRow.Cells[1].Text;

            Response.Redirect("Reservation.aspx");
        }

        protected void btnHomeSearch_Click(object sender, EventArgs e)
        {
            if(txtHomeNameSearch.Text != "")
            {
                string name = txtHomeNameSearch.Text;
                gvHome.DataSource = stoPros.searchName(name);
                gvHome.DataBind();
            }
            else if(ddlHomeCategorySearch.Text != "None Selected...")
            {
                string category = ddlHomeCategorySearch.Text;
                gvHome.DataSource = stoPros.searchCategory(category);
                gvHome.DataBind();
            }
            else if(txtHomeSearchCity.Text != "")
            {
                string city = txtHomeSearchCity.Text;
                gvHome.DataSource = stoPros.searchCity(city);
                gvHome.DataBind();
            }
            else if(ddlHomeSearchState.Text != "None Selected...")
            {
                string state = ddlHomeSearchState.Text;
                gvHome.DataSource = stoPros.searchState(state);
                gvHome.DataBind();
            }
            else
            {
                gvHome.DataSource = stoPros.getAllResults();
                gvHome.DataBind();
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (ddlPersonType.Text == "Representative" && stoPros.searchRepLogin(txtLogin.Text) == true)
            {
                Session["Rev_Username"] = null;               
                btnAddRestaurant.Enabled = false;
                btnRepresentitives.Enabled = false;
                lblLogin.Visible = true;
                txtLogin.Visible = true;
                btnLogin.Visible = true;
                if (txtLogin.Text != "" && stoPros.searchRepLogin(txtLogin.Text) == true)
                {
                    Session["Rep_Username"] = txtLogin.Text;
                    Session["Rev_Username"] = null;
                    btnAddRestaurant.Enabled = true;
                    btnRepresentitives.Enabled = true;
                    btnAddUser.Enabled = false;
                }
            }
            else if(ddlPersonType.Text == "Reviewer" && stoPros.searchRevLogin(txtLogin.Text) == true)
            {
                Session["Rep_Username"] = null;
                btnAddRestaurant.Enabled = false;
                btnRepresentitives.Enabled = false;
                btnUserReviews.Enabled = true;
                lblLogin.Visible = true;
                txtLogin.Visible = true;
                btnLogin.Visible = true;
                if (txtLogin.Text != "" && stoPros.searchRevLogin(txtLogin.Text) == true)
                {
                    Session["Rev_Username"] = txtLogin.Text;
                    Session["Rep_Username"] = null;
                    btnAddRestaurant.Enabled = true;
                    btnRepresentitives.Enabled = false;
                    btnAddUser.Enabled = false;
                }
            }
        }
    }
}