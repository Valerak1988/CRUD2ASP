<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManager/BackAdmin.Master" AutoEventWireup="true" CodeBehind="CityAddEdit.aspx.cs" Inherits="HOMEHORK_CRUD2_.AdminManager.CityAddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
        <div class="row">
    <div class="col-lg-12">
        <h1 class="page-header">ניהול ערים</h1>
    </div>
    <!-- /.col-lg-12 -->
</div>
<!-- /.row -->
<div class="row">
    <div class="col-lg-12">
        <div class="panel panel-default">
            <div class="panel-heading">
                עריכה/הוספה עיר
            </div>
            <div class="panel-body">
                <div class="row">
                    <div class="col-lg-6">
                        <asp:HiddenField ID="HidCityId" runat="server" value="-1"/>
                        <div class="form-group">
                            <label>שם העיר</label>

                            <asp:TextBox ID="TxtCityName" CssClass="form-control" runat="server" placeholder="נא הזן שם העיר" />
                        </div>
                        <div class="form-group">
                            <label>קוד עיר</label>
                            <asp:TextBox ID="TxtCityCode" CssClass="form-control" runat="server" placeholder="נא הזן קוד עיר" />
                        </div>
                        <asp:button ID="BtnSave" runat="server" class="btn btn-primary" OnClick="BtnSave_Click" Text="שמירה"/>

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

