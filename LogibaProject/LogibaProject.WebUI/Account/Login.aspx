<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LogibaProject.WebUI.Account.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Giriş Yap</title>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <link href="../css/font-awesome.css" rel="stylesheet" />
    <link href="../css/sb-admin-2.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-4 col-md-offset-4">
                    <div class="login-panel panel panel-default">
                        <div class="panel-heading">
                            <h3 class="panel-title">Giriş Yap</h3>
                        </div>
                        <div class="panel-body">
                                <fieldset>
                                    <div class="form-group">
                                        <asp:TextBox runat="server" ID="username" CssClass="form-control" placeholder="Kullanıcı Adı" required />
                                    </div>
                                    <div class="form-group">
                                        <asp:TextBox runat="server" ID="password" TextMode="Password" CssClass="form-control" placeholder="Şifre" required />
                                    </div>
                                    <div class="checkbox">
                                        <label>
                                            <asp:CheckBox runat="server" ID="remember" />Beni Hatıla
                                        </label>
                                    </div>
                                    
                                    <!-- Change this to a button or input when using this as a form -->
                                    <asp:Button Text="Giriş Yap" runat="server" ID="btnLogin" CssClass="btn btn-lg btn-success btn-block" OnClick="LoginClick" />

                                    <div id="dvMessage" runat="server" visible="false" class="alert alert-danger">
                                        <strong>Error!</strong>
                                        <asp:Label ID="lblMessage" runat="server" />
                                    </div>
                                </fieldset>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
