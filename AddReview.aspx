<%@ Page Language="C#" UnobtrusiveValidationMode="None" AutoEventWireup="true" CodeBehind="AddReview.aspx.cs" Inherits="Restaurant_Review_System.AddReview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Restaurant.css" type="text/css" rel="stylesheet"/>
    <link rel="shortcut icon" type="image/png" href="Restaurant_Images/restaurant-rating.png" />
    <title>Write Review</title>
</head>
<body>
    <form id="frmAddReview" runat="server">
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
            <br />
            <h1>Write a Review</h1>
            <br />
            <asp:Label ID="lblAddRevError" runat="server" Text="" ForeColor="#CC0000"></asp:Label>
            <br />
            <asp:Label ID="lblReviewFood" runat="server" Text="Food: "></asp:Label>
            <br />
            <asp:RadioButtonList ID="rdioBLReviewFood" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Value="5">5</asp:ListItem>
                <asp:ListItem Value="4">4</asp:ListItem>
                <asp:ListItem Value="3">3</asp:ListItem>
                <asp:ListItem Value="2">2</asp:ListItem>
                <asp:ListItem Value="1">1</asp:ListItem>
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator ID="rfvAddReview" ErrorMessage="Please select a number<br />"
            ControlToValidate="rdioBLReviewFood" runat="server" ForeColor="Red" Display="Dynamic" />
            <br />

            <asp:Label ID="lblReviewService" runat="server" Text="Service: "></asp:Label>
            <br />
            <asp:RadioButtonList ID="rdioBLReviewService" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Value="5">5</asp:ListItem>
                <asp:ListItem Value="4">4</asp:ListItem>
                <asp:ListItem Value="3">3</asp:ListItem>
                <asp:ListItem Value="2">2</asp:ListItem>
                <asp:ListItem Value="1">1</asp:ListItem>
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ErrorMessage="Please select a number<br />"
            ControlToValidate="rdioBLReviewService" runat="server" ForeColor="Red" Display="Dynamic" />
            <br />

            <asp:Label ID="lblReviewAtmosphere" runat="server" Text="Atmosphere: "></asp:Label>
            <br />
            <asp:RadioButtonList ID="rdioBLReviewAtmosphere" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Value="5">5</asp:ListItem>
                <asp:ListItem Value="4">4</asp:ListItem>
                <asp:ListItem Value="3">3</asp:ListItem>
                <asp:ListItem Value="2">2</asp:ListItem>
                <asp:ListItem Value="1">1</asp:ListItem>
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ErrorMessage="Please select a number<br />"
            ControlToValidate="rdioBLReviewAtmosphere" runat="server" ForeColor="Red" Display="Dynamic" />
            <br />

            <asp:Label ID="lblReviewPrice" runat="server" Text="Price: "></asp:Label>
            <br />
            <asp:RadioButtonList ID="rdioBLReviewPrice" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Value="5">5</asp:ListItem>
                <asp:ListItem Value="4">4</asp:ListItem>
                <asp:ListItem Value="3">3</asp:ListItem>
                <asp:ListItem Value="2">2</asp:ListItem>
                <asp:ListItem Value="1">1</asp:ListItem>
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ErrorMessage="Please select a number<br />"
            ControlToValidate="rdioBLReviewPrice" runat="server" ForeColor="Red" Display="Dynamic" />
            <br />
            <br />
            <asp:Label ID="lblReviewComments" runat="server" Text="Comments:"></asp:Label>
            <br />
            <textarea id="txtarReviewComments" runat="server" cols="150" rows="20"></textarea>
            <br />
            <br />
            <asp:Button ID="btnSubmitReview" runat="server" Text="Submit" OnClick="btnSubmitReview_Click" />
            <asp:Button ID="btnClearReview" runat="server" Text="Clear" OnClick="btnClearReview_Click" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
