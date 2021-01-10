<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddRestaurant.aspx.cs" Inherits="Restaurant_Review_System.AddRestaurant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <link href="Restaurant.css" type="text/css" rel="stylesheet"/>
    <link rel="shortcut icon" type="image/png" href="Restaurant_Images/restaurant-rating.png" />
    <title>Add Restaurant</title>
</head>
<body>
    <form id="frmAddRestaurant" runat="server">
        <div>
            <asp:ImageButton ID="ibtnLogo" runat="server" ImageUrl="Restaurant_Images/RR.png" OnClick="ibtnLogo_Click" />
            <asp:Label ID="lblRR" runat="server" Text="RestauRate"></asp:Label>
            <br />
            <asp:Label ID="lblCatchPhrase" runat="server" Text="The world's number one restaurant review system!"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text="" ForeColor="#CC0000"></asp:Label>
            <br />
            <asp:Panel ID="pnlAddRestaurant" runat="server">
                <h1>Add Restaurant</h1>
                <asp:Label ID="lblRestaurantPic" runat="server" Text="Restaurant Image: "></asp:Label>
                <asp:TextBox ID="txtRestaurantPic" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblRestaurantName" runat="server" Text="Restaurant Name: "></asp:Label>
                <asp:TextBox ID="txtRestaurantName" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblRestaurantCategory" runat="server" Text="Restaurant Type: "></asp:Label>
                <asp:DropDownList ID="ddlRestaurantCategory" runat="server">
                    <asp:ListItem>None Selected...</asp:ListItem>
                    <asp:ListItem>Asian</asp:ListItem>
                    <asp:ListItem>Bar</asp:ListItem>
                    <asp:ListItem>Cafe</asp:ListItem>
                    <asp:ListItem>Diner</asp:ListItem>
                    <asp:ListItem>Fast Food</asp:ListItem>
                    <asp:ListItem>Italian</asp:ListItem>
                    <asp:ListItem>Spanish</asp:ListItem>
                    <asp:ListItem>Other</asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:Label ID="lblRestaurantHours" runat="server" Text="Operating Hours: "></asp:Label>
                <asp:TextBox ID="txtRestaurantHours" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblRestaurantPhone" runat="server" Text="Phone Number: "></asp:Label>
                <asp:TextBox ID="txtPhone1" runat="server" MinLength="3" MaxLength="3" Width="35px"></asp:TextBox>
                <asp:Label ID="lblPhoneDash1" runat="server" Text=" - "></asp:Label>
                <asp:TextBox ID="txtPhone2" runat="server" MinLength="3" MaxLength="3" Width="35px"></asp:TextBox>
                <asp:Label ID="lblPhoneDash2" runat="server" Text=" - "></asp:Label>
                <asp:TextBox ID="txtPhone3" runat="server" MinLength="4" MaxLength="4" Width="55px"></asp:TextBox>
                <br />
                <asp:Label ID="lblRestaurantAddress" runat="server" Text="Restaurant Address: "></asp:Label>
                <asp:TextBox ID="txtRestaurantAddress" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblRestaurantCity" runat="server" Text="Restaurant City: "></asp:Label>
                <asp:TextBox ID="txtRestaurantCity" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblRestaurantState" runat="server" Text="Restaurant State: "></asp:Label>
                <asp:DropDownList ID="ddlRestaurantState" runat="server">
                    <asp:ListItem>None Selected...</asp:ListItem>
                    <asp:ListItem Value="AL">Alabama</asp:ListItem>
	                <asp:ListItem Value="AK">Alaska</asp:ListItem>
	                <asp:ListItem Value="AZ">Arizona</asp:ListItem>
	                <asp:ListItem Value="AR">Arkansas</asp:ListItem>
	                <asp:ListItem Value="CA">California</asp:ListItem>
	                <asp:ListItem Value="CO">Colorado</asp:ListItem>
	                <asp:ListItem Value="CT">Connecticut</asp:ListItem>
	                <asp:ListItem Value="DC">District of Columbia</asp:ListItem>
	                <asp:ListItem Value="DE">Delaware</asp:ListItem>
	                <asp:ListItem Value="FL">Florida</asp:ListItem>
	                <asp:ListItem Value="GA">Georgia</asp:ListItem>
	                <asp:ListItem Value="HI">Hawaii</asp:ListItem>
	                <asp:ListItem Value="ID">Idaho</asp:ListItem>
	                <asp:ListItem Value="IL">Illinois</asp:ListItem>
	                <asp:ListItem Value="IN">Indiana</asp:ListItem>
	                <asp:ListItem Value="IA">Iowa</asp:ListItem>
	                <asp:ListItem Value="KS">Kansas</asp:ListItem>
	                <asp:ListItem Value="KY">Kentucky</asp:ListItem>
	                <asp:ListItem Value="LA">Louisiana</asp:ListItem>
	                <asp:ListItem Value="ME">Maine</asp:ListItem>
	                <asp:ListItem Value="MD">Maryland</asp:ListItem>
	                <asp:ListItem Value="MA">Massachusetts</asp:ListItem>
	                <asp:ListItem Value="MI">Michigan</asp:ListItem>
	                <asp:ListItem Value="MN">Minnesota</asp:ListItem>
	                <asp:ListItem Value="MS">Mississippi</asp:ListItem>
	                <asp:ListItem Value="MO">Missouri</asp:ListItem>
	                <asp:ListItem Value="MT">Montana</asp:ListItem>
	                <asp:ListItem Value="NE">Nebraska</asp:ListItem>
	                <asp:ListItem Value="NV">Nevada</asp:ListItem>
	                <asp:ListItem Value="NH">New Hampshire</asp:ListItem>
	                <asp:ListItem Value="NJ">New Jersey</asp:ListItem>
	                <asp:ListItem Value="NM">New Mexico</asp:ListItem>
	                <asp:ListItem Value="NY">New York</asp:ListItem>
	                <asp:ListItem Value="NC">North Carolina</asp:ListItem>
	                <asp:ListItem Value="ND">North Dakota</asp:ListItem>
	                <asp:ListItem Value="OH">Ohio</asp:ListItem>
	                <asp:ListItem Value="OK">Oklahoma</asp:ListItem>
	                <asp:ListItem Value="OR">Oregon</asp:ListItem>
	                <asp:ListItem Value="PA">Pennsylvania</asp:ListItem>
	                <asp:ListItem Value="RI">Rhode Island</asp:ListItem>
	                <asp:ListItem Value="SC">South Carolina</asp:ListItem>
	                <asp:ListItem Value="SD">South Dakota</asp:ListItem>
	                <asp:ListItem Value="TN">Tennessee</asp:ListItem>
	                <asp:ListItem Value="TX">Texas</asp:ListItem>
	                <asp:ListItem Value="UT">Utah</asp:ListItem>
	                <asp:ListItem Value="VT">Vermont</asp:ListItem>
	                <asp:ListItem Value="VA">Virginia</asp:ListItem>
	                <asp:ListItem Value="WA">Washington</asp:ListItem>
	                <asp:ListItem Value="WV">West Virginia</asp:ListItem>
	                <asp:ListItem Value="WI">Wisconsin</asp:ListItem>
	                <asp:ListItem Value="WY">Wyoming</asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:Label ID="lblRestaurantZip" runat="server" Text="Restaurant Zip Code:"></asp:Label>
                <asp:TextBox ID="txtRestaurantZip" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnAddRestaurant" runat="server" Text="Add Restaurant" OnClick="btnAddRestaurant_Click" />
                <asp:Button ID="btnClear" runat="server" Text="Clear Form" OnClick="btnClear_Click" />
                <br />
            </asp:Panel>
            <asp:Panel ID="pnlAddSuccess" runat="server" Visible="False">
                <h2>Restaurant Successfully Added!</h2>
                <asp:Label ID="lblAddSuccess" runat="server" Text="Your restaurant has been successfully added. To find it, please press the logo 
                    at the top of the page to go back home and begin browsing the site. There you can search for it, write a review, and see the restaurant's
                    reviews. If you are a representative, go to the representative portal to manage your restaurant. Press the button below to be assigned 
                    to the restaurant you just created."></asp:Label>
                <br />
                <br />
                <asp:Button ID="btnAddRepToRest" runat="server" Text="Add Yourself" Visible="False" OnClick="btnAddRepToRest_Click" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
