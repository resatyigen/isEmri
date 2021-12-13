<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserWorks.aspx.cs" MasterPageFile="~/Admin/Layout.Master" Inherits="LogibaProject.WebUI.Admin.UserWorks" %>
<%@ Import Namespace="LogibaProject.WebUI.Providers" %>

<asp:Content ID="styles" ContentPlaceHolderID="styles" runat="Server">
    <link href="../css/dataTables.bootstrap.css" rel="stylesheet" />
    <link href="../css/dataTables.responsive.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-md-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <i class="fa fa-list-alt" aria-hidden="true"></i> Kullanıcı Bazlı İş Emirleri
                </div>
                <!-- /.panel-heading -->
                <div class="panel-body">
                    <table border="1" class="workList table table-striped table-bordered table-hover" id="userWorkList">
                        <thead>
                            <tr>
                                <th>Adı Soyadı</th>
                                <th>İş Emri Adı</th>
                                <th>Başlama Tarihi</th>
                                <th>Bitirme Tarihi</th>
                                <th>Durum</th>
                                <th>#</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="rptUserWorkList" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><%# Eval("FullName") %></td>
                                        <td><%# Eval("WorkName") %></td>
                                        <td><%# Eval("StartDate","{0:dd/MM/yyyy}") %></td>
                                        <td><%# Eval("EndDate","{0:dd/MM/yyyy}") %></td>
                                        <td><span class="label label-<%# Provider.getStatusColor(Eval("Status")) %>"><%# Provider.getStatusText(Eval("Status")) %></span></td>
                                        <td>
                                            <a href="EditUserWork/<%# Eval("MapId") %>" class="btn btn-primary btn-circle"><i class="fa fa-pencil" aria-hidden="true"></i></a>
                                            <a href="Process/delete_user_work/<%# Eval("MapId") %>" class="btn btn-danger btn-circle"><i class="fa fa-times" aria-hidden="true"></i></a>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>
                </div>
                <!-- /.panel-body -->
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content ID="scripts" ContentPlaceHolderID="scripts" runat="Server">
    <script src="../js/jquery.dataTables.min.js"></script>
    <script src="../js/dataTables.bootstrap.min.js"></script>
    <script src="../js/dataTables.responsive.js"></script>
    <script>
        $(document).ready(function () {
            $('#userWorkList').DataTable({
                responsive: true
            });
        });
    </script>
</asp:Content>