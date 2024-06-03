<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="HOMEHORK_CRUD2_.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="\Css\LogIn.css" rel="stylesheet" />
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
                        <h2>LOGIN</h2>
                        
                        
                        <div class="inputbox">
                            <asp:TextBox ID="TxtEmail" runat="server" Width="320px" PlaceHolder="Email" CssClass="style">
                            </asp:TextBox>
                        </div>
                        <div class="inputbox">
                            <asp:TextBox ID="TxtPassword" runat="server" Width="320px" PlaceHolder="Password" CssClass="style">
                            </asp:TextBox>
                        </div>
                        <div class="inputbox">
                            <asp:Button ID="button" runat="server" CssClass="style" Text="Submit" ForeColor="white" BackColor="Green" Width="320px" OnClick="button_Click" />
                        </div>

                    </div>
                </div>
                <div style="text-align: center; justify-content: center; margin-top: -20px; color: orangered; font-family: Century">
                    Project By Valery
                </div>
            </div>
        </section>
    </form>
</body>
</html>


