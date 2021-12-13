<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Users.aspx.cs" MasterPageFile="~/Admin/Layout.Master" Inherits="LogibaProject.WebUI.Admin.Users" %>

<asp:Content ID="styles" ContentPlaceHolderID="styles" runat="Server">
    <link href="../css/dataTables.bootstrap.css" rel="stylesheet" />
    <link href="../css/dataTables.responsive.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-md-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <i class="fa fa-list" aria-hidden="true"></i> Kullanıcılar
                </div>
                <!-- /.panel-heading -->
                <div class="panel-body">
                    <table border="1" class="workList table table-striped table-bordered table-hover" id="userList">
                        <thead>
                            <tr>
                                <th>Adı Soyadı</th>
                                <th>Kullanıcı Adı</th>
                                <th>#</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="rptUserList" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><%# Eval("FullName") %></td>
                                        <td><%# Eval("UserName") %></td>
                                        <td>
                                            <a href="EditUser/<%# Eval("id") %>" class="btn btn-primary btn-circle"><i class="fa fa-pencil" aria-hidden="true"></i></a>
                                            <a href="Process/delete_user/<%# Eval("id") %>" class="btn btn-danger btn-circle"><i class="fa fa-times" aria-hidden="true"></i></a>
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
            $('#userList').DataTable({
                responsive: true
            });
        });
    </script>
</asp:Content>
