<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewUser.aspx.cs" Inherits="Restaurant_Review_System.NewUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <link href="Restaurant.css" type="text/css" rel="stylesheet"/>
    <link rel="shortcut icon" type="image/png" href="Restaurant_Images/restaurant-rating.png" />
    <title>Sign-Up</title>
</head>
<body>
    <form id="frmRepAdd" runat="server">
        <div>
             <asp:ImageButton ID="ibtnLogo" runat="server" ImageUrl="Restaurant_Images/RR.png" OnClick="ibtnLogo_Click" />
                <asp:Label ID="lblRR" runat="server" Text="RestauRate"></asp:Label>
                <br />
             <asp:Label ID="lblCatchPhrase" runat="server" Text="The world's number one restaurant review system!"></asp:Label>
        </div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Panel ID="pnlSignUp" runat="server">
            <h2>Sign Up Here!</h2>
            <br />
            <asp:Label ID="lblUserType" runat="server" Text="Are You a Reviewer Or Representitive?"></asp:Label>
            <br />
            <asp:RadioButton ID="rdioUserTypeRev" runat="server" Text="Reviewer" AutoPostBack="True" GroupName="userType" OnCheckedChanged="rdioUserTypeRev_CheckedChanged" />
            <asp:RadioButton ID="rdioUserTypeRep" runat="server" Text="Representitive" AutoPostBack="True" GroupName="userType" OnCheckedChanged="rdioUserTypeRep_CheckedChanged" />
            <br />
            <asp:Label ID="lblError" runat="server" Text="" ForeColor="#CC0000"></asp:Label>
            <br />
            <asp:Label ID="lblRepresentativeUsername" runat="server" Text="Username: " Visible="False"></asp:Label>
            <asp:TextBox ID="txtRepresentativeUsername" runat="server" Visible="False"></asp:TextBox>
            <asp:Label ID="lblReviewerUsername" runat="server" Text="Username: " Visible="False"></asp:Label>
            <asp:TextBox ID="txtReviewerUsername" runat="server" Visible="False"></asp:TextBox>
            <br />
            <asp:Label ID="lblRepresentativeFName" runat="server" Text="First Name: " Visible="False"></asp:Label>
            <asp:TextBox ID="txtRepresentativeFName" runat="server" Visible="False"></asp:TextBox>
            <asp:Label ID="lblReviewerFName" runat="server" Text="First Name: " Visible="False"></asp:Label>
            <asp:TextBox ID="txtReviewerFName" runat="server" Visible="False"></asp:TextBox>
            <br />
            <asp:Label ID="lblRepresentativeLName" runat="server" Text="Last Name: " Visible="False"></asp:Label>
            <asp:TextBox ID="txtRepresentativeLName" runat="server" Visible="False"></asp:TextBox>
            <asp:Label ID="lblReviewerLName" runat="server" Text="Last Name: " Visible="False"></asp:Label>
            <asp:TextBox ID="txtReviewerLName" runat="server" Visible="False"></asp:TextBox>
            <!--<br />
            <asp:Label ID="lblRepAddRestaurantID" runat="server" Text="Restaurant ID: " Visible="False"></asp:Label>
            <asp:TextBox ID="txtRepAddRestaurantID" runat="server" Visible="False"></asp:TextBox>-->
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
        </asp:Panel>
        <asp:Panel ID="pnlWelcome" runat="server" Visible="False">
            <h1>Welcome to RestauRate!</h1>
            <asp:Label ID="lblwelcome" runat="server" Text="We're happy to have you as part of the team, please press the logo at the top
                of the page to go back home and begin browsing the site."></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
