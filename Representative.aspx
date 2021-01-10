<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Representative.aspx.cs" Inherits="Restaurant_Review_System.Representitive" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Restaurant.css" type="text/css" rel="stylesheet"/>
    <link rel="shortcut icon" type="image/png" href="Restaurant_Images/restaurant-rating.png" />
    <title>Representative</title>
</head>
<body>
    <form id="frmRep" runat="server">
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
            <h3>Representitive Management Homepage</h3>
            <br />
            <br />
            <asp:Panel ID="pnlChooseRestaurant" runat="server" Visible="False">
                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                <asp:Label ID="lblChooseRepRestaurant" runat="server" Text="Select business you would like to represent: "></asp:Label>
                <asp:DropDownList ID="ddlChooseRepRestaurant" runat="server">
                </asp:DropDownList>
                <asp:Button ID="btnChooseRepRestaurant" runat="server" Text="Add" OnClick="btnChooseRepRestaurant_Click" />
            </asp:Panel>
            <asp:Panel ID="pnlChooseRestaurantSuccess" runat="server" Visible="False">
                <h3>Success, you are now a representative for <asp:Label ID="lblRestName" runat="server" Text=""></asp:Label></h3>
            </asp:Panel>
            <br />
            <br />
            <br />
            <asp:Panel ID="pnlRepRestaurant" runat="server">
                <h2>Your Restaurant</h2>
                <br />
                <asp:GridView ID="gvRepRestaurants" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
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
                        <asp:TemplateField HeaderText="Manage Reservations">
                            <ItemTemplate>
                                <asp:Button ID="btnAllRestReservations" runat="server" Text="Reservations" OnClick="btnAllRestReservations_Click"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Manage Restaurant">
                            <ItemTemplate>
                                <asp:Button ID="btnEditResaurant" runat="server" Text="Manage Restaurant" OnClick="btnEditRestaurant_Click"/>
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
            </asp:Panel>
            <br />
            <br />
            <asp:Panel ID="pnlReservationTitle" runat="server">
                <asp:Label ID="lblReservationTitle" runat="server" Text="<h2>Your Reservations</h2>" Visible="False"></asp:Label>
                <br />
                <asp:GridView ID="gvRestaurantReservations" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="Reservation_ID" HeaderText="Reservation ID" />
                        <asp:BoundField DataField="Reservation_FName" HeaderText="First Name" />
                        <asp:BoundField DataField="Reservation_LName" HeaderText="Last Name" />
                        <asp:BoundField DataField="Reservation_Time" HeaderText="Time" />
                        <asp:BoundField DataField="Reservation_Date" HeaderText="Date" />
                        <asp:TemplateField HeaderText="Modify Reservation">
                            <ItemTemplate>
                                <asp:Button ID="btnModifyReservation" runat="server" Text="Modify" OnClick="btnEditReservation_Click"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Delete Reservation">
                            <ItemTemplate>
                                <asp:Button ID="btnDeleteReservation" runat="server" Text="Delete" OnClick="btnDeleteReservation_Click"/>
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
            </asp:Panel>
            <br />
            <br />
            <asp:Panel ID="pnlEditReservation" runat="server" Visible="False">
                <h2>Edit Reservation</h2>
                <br />
                <asp:Label ID="lblError2" runat="server" Text=""></asp:Label>
                <br />
                <asp:Label ID="lblEditResFName" runat="server" Text="First Name"></asp:Label>
                <asp:TextBox ID="txtEditResFName" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblEditResLName" runat="server" Text="Last Name"></asp:Label>
                <asp:TextBox ID="txtEditResLName" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblEditResTime" runat="server" Text="Time: "></asp:Label>
                <asp:TextBox ID="txtEditResTime" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblEditResDate" runat="server" Text="Date: "></asp:Label>
                <asp:TextBox ID="txtEditResDate" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnEditSubmit" runat="server" Text="Submit" OnClick="btnEditSubmit_Click" />
                <asp:Button ID="btnEditClear" runat="server" Text="Clear" OnClick="btnEditClear_Click" />
                <br />
            </asp:Panel>
            <asp:Panel ID="pnlEditRestaurant" runat="server" Visible="False">
                <h2>Edit Restaurant</h2>
                <br />
                <asp:Label ID="lblError3" runat="server" Text="" ForeColor="#CC0000"></asp:Label>
                <br />
                <asp:Label ID="lblEditRestaurantPic" runat="server" Text="Restaurant Image: "></asp:Label>
            <asp:TextBox ID="txtEditRestaurantPic" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblEditRestaurantName" runat="server" Text="Restaurant Name: "></asp:Label>
            <asp:TextBox ID="txtEditRestaurantName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblEditRestaurantCategory" runat="server" Text="Restaurant Type: "></asp:Label>
            <asp:DropDownList ID="ddlEditRestaurantCategory" runat="server">
                <asp:ListItem>None Selected...</asp:ListItem>
                <asp:ListItem>American</asp:ListItem>
                <asp:ListItem>Bakery</asp:ListItem>
                <asp:ListItem>Bar</asp:ListItem>
                <asp:ListItem>Buffet</asp:ListItem>
                <asp:ListItem>Cafe</asp:ListItem>
                <asp:ListItem>Caribbean</asp:ListItem>
                <asp:ListItem>Chinese</asp:ListItem>
                <asp:ListItem>Diner</asp:ListItem>
                <asp:ListItem>Fast Food</asp:ListItem>
                <asp:ListItem>Fine Dining</asp:ListItem>
                <asp:ListItem>Food Truck</asp:ListItem>
                <asp:ListItem>French</asp:ListItem>
                <asp:ListItem>Greek</asp:ListItem>
                <asp:ListItem>Ice Cream</asp:ListItem>
                <asp:ListItem>Indian</asp:ListItem>
                <asp:ListItem>Italian</asp:ListItem>
                <asp:ListItem>Japanese</asp:ListItem>
                <asp:ListItem>Mexican</asp:ListItem>
                <asp:ListItem>Pizza</asp:ListItem>
                <asp:ListItem>Polish</asp:ListItem>
                <asp:ListItem>Pub</asp:ListItem>
                <asp:ListItem>Seafood</asp:ListItem>
                <asp:ListItem>Spanish</asp:ListItem>
                <asp:ListItem>Other</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblEditRestaurantHours" runat="server" Text="Operating Hours: "></asp:Label>
            <asp:TextBox ID="txtEditRestaurantHours" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblEditRestaurantPhone" runat="server" Text="Phone Number: "></asp:Label>
            <asp:TextBox ID="txtEditPhone1" runat="server" MinLength="3" MaxLength="3" Width="35px"></asp:TextBox>
            <asp:Label ID="lblEditPhoneDash1" runat="server" Text=" - "></asp:Label>
            <asp:TextBox ID="txtEditPhone2" runat="server" MinLength="3" MaxLength="3" Width="35px"></asp:TextBox>
            <asp:Label ID="lblEditPhoneDash2" runat="server" Text=" - "></asp:Label>
            <asp:TextBox ID="txtEditPhone3" runat="server" MinLength="4" MaxLength="4" Width="55px"></asp:TextBox>
            <br />
            <asp:Label ID="lblEditRestaurantAddress" runat="server" Text="Restaurant Address: "></asp:Label>
            <asp:TextBox ID="txtEditRestaurantAddress" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblEditRestaurantCity" runat="server" Text="Restaurant City: "></asp:Label>
            <asp:TextBox ID="txtEditRestaurantCity" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblEditRestaurantState" runat="server" Text="Restaurant State: "></asp:Label>
            <asp:DropDownList ID="ddlEditRestaurantState" runat="server">
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
            <asp:Label ID="lblEditRestaurantZip" runat="server" Text="Restaurant Zip Code:"></asp:Label>
            <asp:TextBox ID="txtEditRestaurantZip" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnEditRestSubmit" runat="server" Text="Submit" OnClick="btnEditRestSubmit_Click" />
            <asp:Button ID="btnEditRestClear" runat="server" Text="Clear" OnClick="btnEditRestClear_Click" />
            <br />
            </asp:Panel>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>