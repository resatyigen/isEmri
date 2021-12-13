<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddWork.aspx.cs" MasterPageFile="~/Admin/Layout.Master" Inherits="LogibaProject.WebUI.Admin.AddWork" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-md-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <i class="fa fa-plus-square" aria-hidden="true"></i> İş Emri Oluştur
                </div>
                <!-- /.panel-heading -->
                <div class="panel-body">
                    <div runat="server" role="form">
                        <div class="form-group">
                            <label>İş Adı</label>
                            <asp:TextBox runat="server" ID="txtName" CssClass="form-control" required />
                         </div>
                        <div class="form-group">
                            <label>İş No</label>
                            <asp:TextBox runat="server" ID="txtNo" TextMode="Number" CssClass="form-control" required />
                        </div>
                        <div class="form-group">
                            <label>Ürün Adı</label>
                            <asp:TextBox runat="server" ID="txtMaterial" CssClass="form-control" required />
                        </div>
                        <div class="form-group">
                            <label>Ürün Açıklaması</label>
                            <asp:TextBox runat="server" ID="txtDescription" CssClass="form-control" required />
                        </div>
                        <div class="form-group">
                            <label>Ürün Adedi</label>
                            <asp:TextBox runat="server" ID="txtQuantity" TextMode="Number" CssClass="form-control" required />
                        </div>
                        <div class="form-group">
                            <label>Başlama Tarihi</label>
                            <asp:TextBox runat="server" ID="txtStartDate" TextMode="Date" CssClass="form-control" required />
                        </div>
                        <div class="form-group">
                            <label>Bitirme Tarihi</label>
                            <asp:TextBox runat="server" ID="txtEndDate" TextMode="Date" CssClass="form-control" required />
                        </div>
                        <div class="form-group">
                            <label>Dosya Yükle</label>
                            <asp:FileUpload runat="server" ID="file" />
                        </div>
                        <asp:Button Text="Kaydet" runat="server" ID="btnSave" CssClass="btn btn-primary" OnClick="addWork" />
                    </div>
                </div>
                <!-- /.panel-body -->
            </div>
        </div>
    </div>
</asp:Content>
