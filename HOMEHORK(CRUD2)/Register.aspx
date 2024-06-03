<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="HOMEHORK_CRUD2_.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="\Css\Register.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <div class="color"></div>
            <div class="color"></div>
            <div class="color"></div>
            <div class="box">
                <div class="container">
                    <div class="form">
                        <h2>Registration</h2>
                        <div class="inputbox">
                            <asp:TextBox ID="TxtFname" runat="server" Width="150px" CssClass="style" PlaceHolder="First Name"></asp:TextBox>
                            &nbsp;&nbsp;
                            <asp:TextBox ID="TxtLname" runat="server" Width="150px" CssClass="style" PlaceHolder="Last Name"></asp:TextBox>
                        </div>
                        <div class="inputbox">
                        </div>

                        <div class="inputbox">
                            <asp:TextBox ID="TxtEmail" runat="server" Width="320px" PlaceHolder="Email" CssClass="style">
                            </asp:TextBox>
                        </div>
                        <div class="inputbox">
                            <asp:TextBox ID="TxtPassword" runat="server" Width="320px" PlaceHolder="Password" CssClass="style">
                            </asp:TextBox>
                        </div>
                        <div class="inputbox">
                            <asp:TextBox ID="TxtPhone" runat="server" Width="320px" PlaceHolder="Phone" CssClass="style">
                            </asp:TextBox>
                        </div>
                        <div class="inputbox">
                            <asp:DropDownList ID="DDLCity" runat="server" CssClass="style" Width="320px">
                                <asp:ListItem Value="City" />
                            </asp:DropDownList>
                        </div>
                        <div class="inputbox">
                            <asp:DropDownList ID="DDLCityCode" runat="server" CssClass="style" Width="320px">
                                <asp:ListItem Value="City Code" />
                            </asp:DropDownList>
                        </div>
                        <div class="inputbox">
                            <asp:CheckBox ID="check1" runat="server" />
                            <span style="color: white">I Accept
       
                                <a href="/Terms.aspx" style="color: blue">Terms Of Use.</a>
                            </span>
                        </div>
                        <div class="inputbox">
                            <asp:Button ID="button" runat="server" CssClass="style" Text="Submit" ForeColor="white" BackColor="Blue" Width="320px" OnClick="button_Click" />
                        </div>
                        <div class="inputbox">
                            <asp:Label ID="label" runat="server" ForeColor="Blue"></asp:Label>
                        </div>
                    </div>
                </div>
                <div style="text-align: center; justify-content: center; margin-top: -20px; color: black; font-family: Century">
                    Project By Valery
                </div>
            </div>
        </section>
    </form>
</body>
</html>
