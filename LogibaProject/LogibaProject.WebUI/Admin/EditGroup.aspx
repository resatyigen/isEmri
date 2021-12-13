<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditGroup.aspx.cs" MasterPageFile="~/Admin/Layout.Master" Inherits="LogibaProject.WebUI.Admin.EditGroup" %>

<asp:Content ID="styles" ContentPlaceHolderID="styles" runat="Server">
    <style>
        .checkboxlist{
                position: relative;
                display: block;
                margin-top: 10px;
                margin-bottom: 10px;
                border-spacing: 0;
                border-collapse: collapse;
                border: 1px solid #ccc;
                border-radius: 4px;
                padding: 5px;
                max-height: 200px;
                overflow: auto;
        }

        .checkboxlist input{
            position: absolute;
                margin: 4px 0 0;
                margin-top: 1px\9;
                line-height: normal;
        }

        .checkboxlist label{
            min-height: 20px;
    padding-left: 20px;
    margin-bottom: 0;
    font-weight: 400;
    cursor: pointer;
        display: inline-block;
        }
    </style>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-md-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <i class="fa fa-pencil" aria-hidden="true"></i> Grup Düzenle
                </div>
                <!-- /.panel-heading -->
                <div class="panel-body">
                    <div id="dvMessage" runat="server" visible="false" class="alert alert-success">
                        <asp:Label ID="lblMessage" runat="server" />
                    </div>
                    <div runat="server" role="form">
                        <div class="form-group">
                            <label>Grup Adı</label>
                            <asp:TextBox runat="server" ID="txtGroupName" CssClass="form-control" required />
                        </div>
                        <div class="form-group">
                            <label>Kullanıcılar</label>
                            <asp:CheckBoxList runat="server" ID="chkUsers" CssClass="checkboxlist" required>
                            </asp:CheckBoxList>
                        </div>
                        <asp:HiddenField runat="server" ID="hdId" />
                        <asp:Button Text="Kaydet" runat="server" ID="btnSave" CssClass="btn btn-primary" OnClick="saveEditGroup" />
                    </div>
                </div>
                <!-- /.panel-body -->
            </div>
        </div>
    </div>
</asp:Content>
