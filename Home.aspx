<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Restaurant_Review_System.Log_In" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Restaurant.css" type="text/css" rel="stylesheet"/>
    <link rel="shortcut icon" type="image/png" href="Restaurant_Images/restaurant-rating.png" />
    <title>RestauRate</title>
</head>
<body>
    <form id="frmHome" runat="server">
        <div>
            <asp:ImageButton ID="ibtnLogo" runat="server" ImageUrl="Restaurant_Images/RR.png" OnClick="ibtnLogo_Click" />
            <asp:Label ID="lblRR" runat="server" Text="RestauRate"></asp:Label>
            <br />
            <asp:Label ID="lblCatchPhrase" runat="server" Text="The world's number one restaurant review system!"></asp:Label>
            <asp:DropDownList ID="ddlPersonType" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPersonType_SelectedIndexChanged">
                <asp:ListItem>Visitor</asp:ListItem>
                <asp:ListItem>Reviewer</asp:ListItem>
                <asp:ListItem>Representative</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="lblPersonType" runat="server" Text="View: "></asp:Label>
            <asp:Button ID="btnAddUser" runat="server" Text="Sign-Up" OnClick="btnAddUser_Click" />
            <asp:Button ID="btnAddRestaurant" runat="server" Text="Add Restaurant" OnClick="btnAddRestaurant_Click" Enabled="False" />
            <asp:Button ID="btnUserReviews" runat="server" Text="Your Reviews" Enabled="False" OnClick="btnUserReviews_Click" />
            <asp:Button ID="btnRepresentitives" runat="server" Text="Restaurant Representitives" Enabled="False" OnClick="btnRepresentitives_Click" />
            
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" Visible="False" OnClick="btnLogin_Click" />
            <asp:TextBox ID="txtLogin" runat="server" Visible="False"></asp:TextBox>
            <asp:Label ID="lblLogin" runat="server" Text="Username:  " Visible="False"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="lblErrorOutput" runat="server" Text=""></asp:Label>
            <br />  
            <asp:Label ID="lblHomeNameSearch" runat="server" Text="Search By Name: "></asp:Label>
            <asp:TextBox ID="txtHomeNameSearch" runat="server"></asp:TextBox>
            <asp:Label ID="lblHomeCategorySearch" runat="server" Text="Search Categories: "></asp:Label>
            <asp:DropDownList ID="ddlHomeCategorySearch" runat="server">
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
            <asp:Label ID="lblHomeSearchCity" runat="server" Text="Search By City: "></asp:Label>
            <asp:TextBox ID="txtHomeSearchCity" runat="server"></asp:TextBox>
            <asp:Label ID="lblHomeSearchState" runat="server" Text="Search By State: "></asp:Label>
            <asp:DropDownList ID="ddlHomeSearchState" runat="server">
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
            <br />
            <asp:Button ID="btnHomeSearch" runat="server" Text="Search" OnClick="btnHomeSearch_Click" />
            <br />
            <br />
            <asp:GridView ID="gvHome" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" Font-Names="Garamond">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:ImageField DataImageUrlField="Restaurant_Pic" HeaderText="Image" ControlStyle-Height="65px" ControlStyle-Width="90px">
                        <ControlStyle Height="65px" Width="90px"></ControlStyle>
                    </asp:ImageField>
                    <asp:BoundField DataField="Restaurant_ID" HeaderText="ID" />
                    <asp:BoundField DataField="Restaurant_Name" HeaderText="Name" />
                    <asp:BoundField DataField="Restaurant_Category" HeaderText="Category" />
                    <asp:BoundField DataField="Restaurant_Hours" HeaderText="Operating Hours" />
                    <asp:BoundField DataField="Restaurant_Phone" HeaderText="Phone Number" />
                    <asp:BoundField DataField="Restaurant_Street" HeaderText="Street Address" />
                    <asp:BoundField DataField="Restaurant_City" HeaderText="City" />
                    <asp:BoundField DataField="Restaurant_State" HeaderText="State" />
                    <asp:BoundField DataField="Restaurant_Zip" HeaderText="Zip Code" />
                    <asp:TemplateField HeaderText="See Reviews">
                        <ItemTemplate>
                            <asp:Button ID="btnSeeReviews" runat="server" Text="See Reviews" OnClick="btnReview_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Make Reservation">
                        <ItemTemplate>
                            <asp:Button ID="btnMakeReservation" runat="server" Text="Make Reservation" OnClick="btnMakeReservation_Click"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
