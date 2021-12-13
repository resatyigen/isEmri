<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditGroupWork.aspx.cs" MasterPageFile="~/Admin/Layout.Master" Inherits="LogibaProject.WebUI.Admin.EditGroupWork" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-md-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <i class="fa fa-pencil" aria-hidden="true"></i> Grup Bazlı İş Emri Düzenle
                </div>
                <!-- /.panel-heading -->
                <div class="panel-body">
                    <div id="dvMessage" runat="server" visible="false" class="alert alert-success">
                        <asp:Label ID="lblMessage" runat="server" />
                    </div>
                    <div runat="server" role="form">
                        <div class="form-group">
                            <label>İş Emri</label>
                            <asp:DropDownList runat="server" ID="drpWorks" CssClass="form-control" required>
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>Grup</label>
                            <asp:DropDownList runat="server" ID="drpGroups" CssClass="form-control" required>
                            </asp:DropDownList>
                         </div>
                        <asp:HiddenField runat="server" ID="hdId" />
                        <asp:Button Text="Kaydet" runat="server" ID="btnSave" CssClass="btn btn-primary" OnClick="saveEditGroupWork" />
                    </div>
                </div>
                <!-- /.panel-body -->
            </div>
        </div>
    </div>
</asp:Content>