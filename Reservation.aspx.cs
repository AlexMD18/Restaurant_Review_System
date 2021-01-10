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

namespace Restaurant_Review_System
{
    public partial class Reservation : System.Web.UI.Page
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

        protected void btnSubmitReservation_Click(object sender, EventArgs e)
        {
            string resFName = txtReservationFName.Text;
            string resLName = txtReservationLName.Text;
            string resTime = ddlReservationTime.Text;
            string resDate = txtReservationDate.Text;
            string strRestID = Session["restaurantID"].ToString();
            int restID = int.Parse(strRestID);

            if (valRes.checkAddReservation(txtReservationFName, txtReservationLName, txtReservationDate) == true)
            {
                int addStatus = stoPros.addNewReservation(resFName, resLName, resTime, resDate, restID);

                if (addStatus >= 1)
                {
                    pnlSuccessResAdd.Visible = true;
                    pnlCreateReservation.Visible = false;
                }
                else
                {
                    lblError.Text = "*Reservation not added. Something went wrong*";
                }
            }
            else
            {
                lblError.Text = "*Reservation not added. Please enter all the information below.*";
            }
        }
    }
}