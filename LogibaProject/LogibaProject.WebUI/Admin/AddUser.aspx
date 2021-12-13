<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" MasterPageFile="~/Admin/Layout.Master" Inherits="LogibaProject.WebUI.Admin.AddUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-md-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <i class="fa fa-user-plus" aria-hidden="true"></i> Kullanıcı Oluştur
                </div>
                <!-- /.panel-heading -->
                <div class="panel-body">
                    <div id="dvMessage" runat="server" visible="false" class="alert alert-danger">
                        <strong>Hata!</strong>
                        <asp:Label ID="lblMessage" runat="server" />
                    </div>
                    <div runat="server" role="form">
                        <div class="form-group">
                            <label>Adı Soyadı</label>
                            <asp:TextBox runat="server" ID="txtFullName" CssClass="form-control" required />
                         </div>
                        <div class="form-group">
                            <label>Kullanıcı Adı</label>
                            <asp:TextBox runat="server" ID="txtUserName" CssClass="form-control" required />
                        </div>
                        <div class="form-group">
                            <label>Şifresi</label>
                            <asp:TextBox runat="server" TextMode="Password" ID="txtPassword" CssClass="form-control" required />
                        </div>
                        <asp:Button Text="Kaydet" runat="server" ID="btnSave" CssClass="btn btn-primary" OnClick="addUser" />
                    </div>
                </div>
                <!-- /.panel-body -->
            </div>
        </div>
    </div>
</asp:Content>