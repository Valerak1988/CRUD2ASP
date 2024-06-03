﻿<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManager/BackAdmin.Master" AutoEventWireup="true" CodeBehind="CityList.aspx.cs" Inherits="HOMEHORK_CRUD2_.AdminManager.City" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <div class="row">
    <div class="col-lg-12">
        <h1 class="page-header">רשימת ערים</h1>
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
                                <th>קוד מזהה של העיר</th>
                                <th>שם העיר</th>
                                <th>קוד עיר</th>
                                <th>תאריך הוספה</th>
                                <th>ניהול</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="RptCity" runat="server">
                                <ItemTemplate>
                                    <tr class="odd gradeX">
                                        <td><%#Eval("CityId") %></td>
                                        <td><%#Eval("CityName") %></td>
                                        <td><%#Eval("CityCode") %></td>
                                         <td><%#Eval("AddDate") %></td>
                                        <td class="center"><a href="CityAddEdit.aspx?CityID=<%#Eval("CityId") %>">ערוך<span class="fa fa-pencil"></span></a></td>
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