<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManager/BackAdmin.Master" AutoEventWireup="true" CodeBehind="ClientList.aspx.cs" Inherits="HOMEHORK_CRUD2_.AdminManager.ClientList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <div class="row">
    <div class="col-lg-12">
        <h1 class="page-header">רשימת לקוחות</h1>
    </div>
    <!-- /.col-lg-12 -->
</div>
<!-- /.row -->
<div class="row">
    <div class="col-lg-12">                     
        <div class="panel panel-default">
            <div class="panel-heading">
                מאגר קטגוריות במערכת
       
            </div>
            <!-- /.panel-heading -->
            <div class="panel-body">
                <div class="table-responsive">
                    <table class="table table-striped table-bordered table-hover" id="MainTbl">
                        <thead>
                            <tr>
                                <th>קוד משתמש</th>
                                <th>שם פרטי</th>
                                <th>שם משפחה</th>
                                <th>עיר</th>
                                <th>קוד עיר</th>
                                <th>טלפון</th>
                                <th>מייל</th>
                                <th>תאריך הוספה</th>
                                <th>ניהול</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="RptClient" runat="server">
                                <ItemTemplate>
                                    <tr class="odd gradeX">
                                        <td><%#Eval("Uid") %></td>
                                        <td><%#Eval("FirstName") %></td>
                                        <td><%#Eval("LastName") %></td>
                                        <td><%#Eval("City") %></td>
                                        <td><%#Eval("CityCode") %></td>
                                        <td><%#Eval("Phone") %></td>
                                        <td><%#Eval("Email") %></td>
                                         <td><%#Eval("AddDate") %></td>
                                        <td class="center"><a href="ClientAddEdit.aspx?Uid=<%#Eval("Uid") %>">ערוך<span class="fa fa-pencil"></span></a></td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>
                </div>
                <!-- /.table-responsive -->
            </div>
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
    </div>
    <!-- /.col-lg-12 -->
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderFooter" runat="server">
<script src="js/jquery/jquery.dataTables.min.js"></script>
<script src="js/bootstrap/dataTables.bootstrap.min.js"></script>
<script>
    $(document).ready(function() {
        $('#MainTbl').dataTable({
            language: {
                url: '//cdn.datatables.net/plug-ins/2.0.7/i18n/he.json',
            }
        });
    });
</script>

</asp:Content>