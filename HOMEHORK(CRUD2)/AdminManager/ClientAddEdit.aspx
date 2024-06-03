<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManager/BackAdmin.Master" AutoEventWireup="true" CodeBehind="ClientAddEdit.aspx.cs" Inherits="HOMEHORK_CRUD2_.AdminManager.ClientAddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">ניהול לקוח</h1>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    עריכה/הוספה לקוח
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-lg-6">
                            <asp:HiddenField ID="HidUid" runat="server" Value="-1" />
                            <div class="form-group">
                                <label>שם העיר</label>

                                <asp:TextBox ID="TxtFirstName" CssClass="form-control" runat="server" placeholder="נא הזן שם לקוח" />
                            </div>
                            <div class="form-group">
                                <label>קוד עיר</label>
                                <asp:TextBox ID="TxtLastName" CssClass="form-control" runat="server" placeholder="נא הזן שם משפחה לקוח" />
                            </div>
                            <div class="form-group">
                                <label>קוד עיר</label>
                                <asp:TextBox ID="TxtCity" CssClass="form-control" runat="server" placeholder="נא הזן עיר" />
                            </div>
                            <div class="form-group">
                                <label>קוד עיר</label>
                                <asp:TextBox ID="TxtCityCode" CssClass="form-control" runat="server" placeholder="נא הזן קוד עיר" />
                            </div>
                            <div class="form-group">
                                <label>קוד עיר</label>
                                <asp:TextBox ID="TxtPhone" CssClass="form-control" runat="server" placeholder="נא הזן טלפון" />
                            </div>
                            <div class="form-group">
                                <label>קוד עיר</label>
                                <asp:TextBox ID="TxtEmail" CssClass="form-control" runat="server" placeholder="נא הזן מייל" />
                            </div>
                            <asp:Button ID="BtnSave" runat="server" class="btn btn-primary" OnClick="BtnSave_Click" Text="שמירה" />
                        </div>
                    </div>
                    <!-- /.row (nested) -->
                </div>
                <!-- /.panel-body -->
            </div>
            <!-- /.panel -->
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderFooter" runat="server">
</asp:Content>
