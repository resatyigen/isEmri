<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Groups.aspx.cs" MasterPageFile="~/Admin/Layout.Master" Inherits="LogibaProject.WebUI.Admin.Groups" %>

<asp:Content ID="styles" ContentPlaceHolderID="styles" runat="Server">
    <link href="../css/dataTables.bootstrap.css" rel="stylesheet" />
    <link href="../css/dataTables.responsive.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-md-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <i class="fa fa-list" aria-hidden="true"></i> Gruplar
                </div>
                <!-- /.panel-heading -->
                <div class="panel-body">
                    <table border="1" class="workList table table-striped table-bordered table-hover" id="groupList">
                        <thead>
                            <tr>
                                <th>Grup Adı</th>
                                <th>Gruba Dahil Kullanıcı Sayısı</th>
                                <th>#</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="rptGroupList" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><%# Eval("Name") %></td>
                                        <td><%# Eval("UserCount") %></td>
                                        <td>
                                            <a href="EditGroup/<%# Eval("id") %>" class="btn btn-primary btn-circle"><i class="fa fa-pencil" aria-hidden="true"></i></a>
                                            <a href="Process/delete_group/<%# Eval("id") %>" class="btn btn-danger btn-circle"><i class="fa fa-times" aria-hidden="true"></i></a>
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
            $('#groupList').DataTable({
                responsive: true
            });
        });
    </script>
</asp:Content>