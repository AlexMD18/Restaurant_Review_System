/*
Alex Drogo
10/22/2020
CIS 3342
Prof. Pascucci
Description: This class validates all textboxes and dropdown lists that are used in all the aspx pages.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Restaurant_Review_System
{
    public class ValidationRestaurant
    {
        //Checks to ensure all texts boxes, and dropdown boxes have a value.
        public bool checkAddRestaurant(TextBox name, DropDownList category, TextBox hours, TextBox phone1, TextBox phone2, TextBox phone3, 
                                       TextBox address, TextBox city, DropDownList state, TextBox zip)
        {
            if (name.Text != "" && category.Text != "" && hours.Text != "" && phone1.Text != "" && phone2.Text != "" && phone3.Text != "" &&
                address.Text != "" && state.Text != "" && zip.Text != "")
            {
                return true;
            }
            return false;
        }

        public bool checkAddUser(TextBox username, TextBox fname, TextBox lname)
        {
            if(username.Text != "" && fname.Text != "" && lname.Text != "")
            {
                return true;
            }
            return false;
        }

        public bool checkEditReservation(TextBox fname, TextBox lname, TextBox time, TextBox date)
        {
            if (fname.Text != "" && lname.Text != "" && time.Text != "" && date.Text != "")
            {
                return true;
            }
            return false;
        }

        public bool checkAddReservation(TextBox fname, TextBox lname, TextBox date)
        {
            if (fname.Text != "" && lname.Text != "" && date.Text != "")
            {
                return true;
            }
            return false;
        }
    }
}