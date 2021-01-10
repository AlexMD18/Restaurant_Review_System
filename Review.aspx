<%@ Page Language="C#" UnobtrusiveValidationMode="None" AutoEventWireup="true" ValidateRequest="false" CodeBehind="Review.aspx.cs" Inherits="Restaurant_Review_System.Review" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <link href="Restaurant.css" type="text/css" rel="stylesheet"/>
    <link rel="shortcut icon" type="image/png" href="Restaurant_Images/restaurant-rating.png" />
    <title>Review</title>
</head>
<body>
    <form id="frmReview" runat="server">
            <div>
                <asp:ImageButton ID="ibtnLogo" runat="server" ImageUrl="Restaurant_Images/RR.png" OnClick="ibtnLogo_Click" />
                <asp:Label ID="lblRR" runat="server" Text="RestauRate"></asp:Label>
                <asp:Button ID="btnUserReviewsRevPage" runat="server" Text="Your Reviews" Enabled="False" OnClick="btnUserReviews_Click" />
                <asp:Button ID="btnWriteReview" runat="server" Text="Write a Review" OnClick="btnWriteReview_Click" Enabled="False" />
                <br />
                <asp:Label ID="lblCatchPhrase" runat="server" Text="The world's number one restaurant review system!"></asp:Label>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <h1>Reviews</h1>
                <br />
                <asp:GridView ID="gvReviews" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" ShowFooter="True">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="Review_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Review_Food" HeaderText="Food Rating" />
                        <asp:BoundField DataField="Review_Service" HeaderText="Service" />
                        <asp:BoundField DataField="Review_Atmosphere" HeaderText="Atmosphere"></asp:BoundField>
                        <asp:BoundField DataField="Review_Price" HeaderText="Price" />
                        <asp:BoundField DataField="Review_Comments" HeaderText="Comments">
                        <ItemStyle Width="600px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Restaurant_ID" HeaderText="Restaurant ID" />
                        <asp:BoundField DataField="Reviewer_Username" HeaderText="Reviewer" />
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

                <asp:GridView ID="gvUserReviews" runat="server" AutoGenerateColumns="False" CellPadding="4" Visible="False">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="Review_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Restaurant_Name" HeaderText="Name" />
                        <asp:BoundField DataField="Review_Food" HeaderText="Food Rating" />
                        <asp:BoundField DataField="Review_Service" HeaderText="Service" />
                        <asp:BoundField DataField="Review_Atmosphere" HeaderText="Atmosphere" />
                        <asp:BoundField DataField="Review_Price" HeaderText="Price" />
                        <asp:BoundField DataField="Review_Comments" HeaderText="Comments">
                        <ItemStyle Width="450px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Reviewer_Username" HeaderText="Reviewer" />
                        <asp:BoundField DataField="Restaurant_ID" HeaderText="Restaurant ID" />
                        <asp:TemplateField HeaderText="Modify Review">
                            <ItemTemplate>
                                <asp:Button ID="btnReviewModify" runat="server" Text="Modify" OnClick="btnReviewModify_Click" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Delete Review">
                            <ItemTemplate>
                                <asp:Button ID="btnReviewDelete" runat="server" Text="Delete" OnClick="btnReviewDelete_Click"/>
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
            <asp:Panel ID="pnlEditReview" runat="server" Visible="False">
                <h2>Edit Review For <strong><asp:Label ID="lblRevTitle" runat="server" Text=""></asp:Label></strong></h2>
                <br />
                <asp:Label ID="lblEditRevError" runat="server" Text=""></asp:Label>
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
            </asp:Panel>
            <br />
            <br />
            <br />
            </div>
    </form>
</body>
</html>