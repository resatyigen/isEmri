<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditWork.aspx.cs" MasterPageFile="~/Admin/Layout.Master" Inherits="LogibaProject.WebUI.Admin.EditWork" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-md-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <i class="fa fa-pencil"></i> İş Emri Düzenle
                </div>
                <!-- /.panel-heading -->
                <div class="panel-body">
                    <div id="dvMessage" runat="server" visible="false" class="alert alert-success">
                        <asp:Label ID="lblMessage" runat="server" />
                    </div>
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
                            <label>Başlama Zamanı</label>
                            <asp:TextBox runat="server" ID="txtStartDate" TextMode="Date" CssClass="form-control" required />
                        </div>
                        <div class="form-group">
                            <label>Bitirme Zamanı</label>
                            <asp:TextBox runat="server" ID="txtEndDate" TextMode="Date" CssClass="form-control" required />
                        </div>
                        <div class="form-group">
                            <label>Dosya Yükle</label>
                            <asp:FileUpload runat="server" ID="file" />
                        </div>
                        <div class="form-group">
                            <label>Durum</label>
                            <asp:DropDownList runat="server" ID="drpStatus" CssClass="form-control">
                                <asp:ListItem Value="1" Text="Devam Ediyor" />
                                <asp:ListItem Value="2" Text="Bitti" />
                                <asp:ListItem Value="3" Text="Durduruldu" />
                            </asp:DropDownList>
                        </div>
                        <asp:HiddenField runat="server" ID="hdId" />
                        <asp:Button Text="Kaydet" runat="server" ID="btnSave" CssClass="btn btn-primary" OnClick="saveEditWork" />
                    </div>
                </div>
                <!-- /.panel-body -->
            </div>
        </div>
    </div>
</asp:Content>
