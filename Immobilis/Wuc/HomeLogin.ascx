<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HomeLogin.ascx.cs" Inherits="Wuc_HomeLogin" %>

<div id="myModal" class="modal fade" role="dialog">
    <div class="modal-dialog" style="position: static; width: 400px;">
        <div class="container">
            <div class="row">
                <div class="col-md-4 col-md-offset-7">
                    <div class="panel panel-default">
                        <div class="panel-heading text-center">
                            <b>
                                <asp:Label ID="lblNombreUsuario" runat="server" Text="Acceso portal Immobilis"></asp:Label></b>
                        </div>
                        <div class="panel-body">
                            <asp:Panel ID="panelLogInModal" runat="server">
                                <div class="row">
                                    <div class="col-sm-12">
                                        <asp:TextBox ID="txtEmail" runat="server" class="form-control" placeholder="Email"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-sm-12">
                                        <asp:TextBox ID="txtContrasena" runat="server" class="form-control" TextMode="Password" placeholder="Password"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row last" style="margin-bottom: 0px;">
                                    <div class="col-sm-12">
                                        <asp:Button ID="btnLoginHome" runat="server" class="btn btn-primary btn-block" Text="Entrar" OnClick="btnLoginHome_Click" />
                                    </div>
                                </div>
                            </asp:Panel>
                            <asp:Panel ID="panelSession" runat="server">
                                <div class="row">
                                    <div class="col-12 col-lg-3 col-sm-6">
                                        <p><i class="fa fa-user"></i></p>
                                        <h2 class="font-thin"><span class="font-semibold">Usuario Logeado</span></h2>
                                        <h1><a href="../PortalUsuario/UsuarioInicio.aspx">Accede a tu cuenta!</a></h1>
                                    </div>
                                </div>
                            </asp:Panel>
                        </div>
                        <div class="panel-footer">
                            Aún no estas registrado?  <a href="RegistroUsuario.aspx">Registrate aquí</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
