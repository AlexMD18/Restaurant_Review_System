/*
Alex Drogo
10/22/2020
CIS 3342
Prof. Pascucci
Description: This class is the backend code to the add a new user form page. It allows a visitor to visit this page, choose between being a 
representative or a reviewer, and then insert their information. If there are no errors and nothing missing, they will be able to access more
features on the site.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Restaurant_Review_System
{
    public partial class NewUser : System.Web.UI.Page
    {
        StoredProcedures stoPros = new StoredProcedures();
        ValidationRestaurant valRes = new ValidationRestaurant();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ibtnLogo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewUser.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if(rdioUserTypeRev.Checked)
            {
                string username = "";
                string fname = "";
                string lname = "";

                username = txtReviewerUsername.Text;
                fname = txtReviewerFName.Text;
                lname = txtReviewerLName.Text;

                if(valRes.checkAddUser(txtReviewerUsername, txtReviewerFName, txtReviewerLName) == true)
                {
                    int addStatus = stoPros.addNewReviewer(username, fname, lname);

                    if (addStatus >= 1)
                    {
                        pnlSignUp.Visible = false;
                        pnlWelcome.Visible = true;
                    }
                    else
                    {
                        lblError.Text = "*User not added. You are missing or entered incorrect information*";
                    }
                }
                else
                {
                    lblError.Text = "*User not added. Please enter all the information below.*";
                }
            }
            else if(rdioUserTypeRep.Checked)
            {
                string username = "";
                string fname = "";
                string lname = "";
                username = txtRepresentativeUsername.Text;
                fname = txtRepresentativeUsername.Text;
                lname = txtRepresentativeLName.Text;

                if (valRes.checkAddUser(txtRepresentativeUsername, txtRepresentativeUsername, txtRepresentativeLName) == true)
                {
                
                    int addStatus = stoPros.addNewRep(username, fname, lname);

                    if (addStatus >= 1)
                    {
                        pnlSignUp.Visible = false;
                        pnlWelcome.Visible = true;
                    }
                    else
                    {
                        lblError.Text = "*User not added. You are missing or entered incorrect information*";
                    }
                }
                else
                {
                    lblError.Text = "*User not added. Please enter all the information below.*";
                }
            }
        }

        protected void rdioUserTypeRep_CheckedChanged(object sender, EventArgs e)
        {
            
                lblReviewerUsername.Visible = false;
                txtReviewerUsername.Visible = false;
                lblReviewerFName.Visible = false;
                lblReviewerLName.Visible = false;
                txtReviewerFName.Visible = false;
                txtReviewerLName.Visible = false;

                lblRepresentativeUsername.Visible = true;
                txtRepresentativeUsername.Visible = true;
                lblRepresentativeFName.Visible = true;
                lblRepresentativeLName.Visible = true;
                txtRepresentativeFName.Visible = true;
                txtRepresentativeLName.Visible = true;
            
        }

        protected void rdioUserTypeRev_CheckedChanged(object sender, EventArgs e)
        {
            lblRepresentativeUsername.Visible = false;
            txtRepresentativeUsername.Visible = false;
            lblRepresentativeFName.Visible = false;
            lblRepresentativeLName.Visible = false;
            txtRepresentativeFName.Visible = false;
            txtRepresentativeLName.Visible = false;

            lblReviewerUsername.Visible = true;
            txtReviewerUsername.Visible = true;
            lblReviewerFName.Visible = true;
            lblReviewerLName.Visible = true;
            txtReviewerFName.Visible = true;
            txtReviewerLName.Visible = true;
        }
    }
}