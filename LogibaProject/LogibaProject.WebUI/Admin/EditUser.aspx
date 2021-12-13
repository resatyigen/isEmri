<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditUser.aspx.cs" MasterPageFile="~/Admin/Layout.Master" Inherits="LogibaProject.WebUI.Admin.EditUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-md-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <i class="fa fa-pencil" aria-hidden="true"></i> Kullanıcı Düzenle
                </div>
                <!-- /.panel-heading -->
                <div class="panel-body">
                    <div id="dvMessage" runat="server" visible="false" class="alert alert-success">
                        <asp:Label ID="lblMessage" runat="server" />
                    </div>
                    <div runat="server" role="form">
                        <div class="form-group">
                            <label>Adı Soyadı</label>
                            <asp:TextBox runat="server" ID="txtFullName" CssClass="form-control" required />
                         </div>
                        <div class="form-group">
                            <label>Kullanıcı Adı</label>
                            <asp:TextBox runat="server" ID="txtUserName" Enabled="false" CssClass="form-control" required />
                        </div>
                        <div class="form-group">
                            <label>Şifresi</label>
                            <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="form-control" />
                        </div>
                        <asp:HiddenField runat="server" ID="hdId" />
                        <asp:Button Text="Kaydet" runat="server" ID="btnSave" CssClass="btn btn-primary" OnClick="saveEditUser" />
                    </div>
                </div>
                <!-- /.panel-body -->
            </div>
        </div>
    </div>
</asp:Content>