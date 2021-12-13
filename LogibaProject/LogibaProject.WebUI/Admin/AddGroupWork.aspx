<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddGroupWork.aspx.cs" MasterPageFile="~/Admin/Layout.Master" Inherits="LogibaProject.WebUI.Admin.AddGroupWork" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-md-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <i class="fa fa-briefcase" aria-hidden="true"></i> Grup Bazlı İş Emri Ata
                </div>
                <!-- /.panel-heading -->
                <div class="panel-body">
                    <div id="dvMessage" runat="server" visible="false" class="alert alert-danger">
                        <strong>Hata!</strong>
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
                        <asp:Button Text="Kaydet" runat="server" ID="btnSave" CssClass="btn btn-primary" OnClick="addGroupWork" />
                    </div>
                </div>
                <!-- /.panel-body -->
            </div>
        </div>
    </div>
</asp:Content>