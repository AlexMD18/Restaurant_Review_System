<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reservation.aspx.cs" Inherits="Restaurant_Review_System.Reservation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <link href="Restaurant.css" type="text/css" rel="stylesheet"/>
    <link rel="shortcut icon" type="image/png" href="Restaurant_Images/restaurant-rating.png" />
    <title>Reservation</title>
</head>
<body>
    <form id="frmReservation" runat="server">
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
            <asp:Panel ID="pnlCreateReservation" runat="server">
                <h1>Create Reservation</h1>
                <br />
                <asp:Label ID="lblError" runat="server" Text="" ForeColor="#CC0000"></asp:Label>
                <br />
                <asp:Label ID="lblReservationFName" runat="server" Text="First Name: "></asp:Label>
                <asp:TextBox ID="txtReservationFName" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblReservationLName" runat="server" Text="Last Name: "></asp:Label>
                <asp:TextBox ID="txtReservationLName" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblReservationTime" runat="server" Text="Reservation Time:"></asp:Label>
                <asp:DropDownList ID="ddlReservationTime" runat="server">
                    <asp:ListItem Value="12:00:00">12:00pm</asp:ListItem>
                    <asp:ListItem Value="13:00:00">1:00pm</asp:ListItem>
                    <asp:ListItem Value="14:00:00">2:00pm</asp:ListItem>
                    <asp:ListItem Value="15:00:00">3:00pm</asp:ListItem>
                    <asp:ListItem Value="16:00:00">4:00pm</asp:ListItem>
                    <asp:ListItem Value="17:00:00">5:00pm</asp:ListItem>
                    <asp:ListItem Value="18:00:00">6:00pm</asp:ListItem>
                    <asp:ListItem Value="19:00:00">7:00pm</asp:ListItem>
                    <asp:ListItem Value="20:00:00">8:00pm</asp:ListItem>
                    <asp:ListItem Value="21:00:00">9:00pm</asp:ListItem>
                    <asp:ListItem Value="22:00:00">10:00pm</asp:ListItem>
                    <asp:ListItem Value="23:00:00">11:00pm</asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:Label ID="lblReservationDate" runat="server" Text="Reservation Date"></asp:Label>
                <asp:TextBox ID="txtReservationDate" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnSubmitReservation" runat="server" Text="Submit" OnClick="btnSubmitReservation_Click" />
                <asp:Button ID="btnClear" runat="server" Text="Clear" />
                <br />
                <br />
                <br />
            </asp:Panel>
            <asp:Panel ID="pnlSuccessResAdd" runat="server" Visible="False">
                <h2>You have successfully submitted a reservation</h2>
                <asp:Label ID="lblSuccessResAdd" runat="server" Text="Press the home button to go back to the main screen!"></asp:Label>
            </asp:Panel>
        </div>
    </form>
</body>
</html>