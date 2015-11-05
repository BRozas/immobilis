<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Portal.master" AutoEventWireup="true" CodeFile="RegistroUsuario.aspx.cs" Inherits="Paginas_RegistroUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Home" runat="Server">
    <style>
        .form-control {
            margin-bottom: 10px;
        }
    </style>
    <div class="container" style="color: white;">
        <asp:FormView runat="server" ID="fwNuevaPersona" ItemType="Inmobiliaria.Dto.Persona"
            DefaultMode="Insert"
            InsertMethod="fwNuevaPersona_InsertItem">
            <InsertItemTemplate>
                <!-- /row -->
                <div class="row subtitle-row" style="margin-top: 40px;">
                    <div class="col-12 font-thin">Nuevo<span class="font-semibold"> Usuario</span></div>
                </div>
                <!-- /row -->
                <div class="row content-row">
                    <div class="col-12 col-lg-3 col-sm-6">
                        <p><i class="icon icon-user"></i></p>
                        <h2 class="font-thin">Algo sobre<span class="font-semibold"> Mi</span></h2>
                        <asp:TextBox ID="txtNombre" Text='<%# BindItem.Nombre %>' class="form-control" placeholder="Nombre" runat="server"></asp:TextBox>
                        <asp:TextBox ID="TextBox1" Text='<%# BindItem.Apellido %>' class="form-control" placeholder="Apellido" runat="server"></asp:TextBox>
                        <asp:TextBox ID="TextBox2" Text='<%# BindItem.Rut %>' class="form-control" placeholder="Rut" runat="server"></asp:TextBox>
                    </div>
                    <!-- /col12 -->
                    <div class="col-12 col-lg-3 col-sm-6">
                        <p><i class="icon icon-laptop"></i></p>
                        <h2 class="font-thin">Acceso <span class="font-semibold">Portal Web</span></h2>
                        <asp:TextBox ID="TextBox3" Text='<%# BindItem.NombreUsuario %>' class="form-control" placeholder="Nombre Usuario" runat="server"></asp:TextBox>
                        <asp:TextBox ID="TextBox4" Text='<%# BindItem.Contrasena %>' class="form-control" placeholder="Contraseña" runat="server"></asp:TextBox>
                        <asp:TextBox ID="TextBox5" Text='<%# BindItem.Email %>' class="form-control" placeholder="Email" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-12 col-lg-3 col-sm-6">
                        <p><i class="icon icon-pencil"></i></p>
                        <h2 class="font-semibold">Opcional</h2>
                        <asp:TextBox ID="TextBox6" Text='<%# BindItem.Telefono %>' class="form-control" placeholder="Teléfono" runat="server"></asp:TextBox>
                        <h4 class="font-thin">Tipo persona</h4>
                        <asp:DropDownList ID="DropDownList1" runat="server" class="form-control" placeholder="Tipo persona">
                            <asp:ListItem Value="0" Text="Natural"></asp:ListItem>
                            <asp:ListItem Value="1" Text="Jurídica"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <!-- /col12 -->
                    <!-- /col12 -->
                    <div class="col-12 col-lg-3 col-sm-6">
                        <p><i class="icon icon-tablet"></i></p>
                        <h2 class="font-thin">Tu portal <span class="font-semibold">Mobile</span></h2>
                        <h4 class="font-thin"><span class="font-semibold">Portal Immobilis está optimizado para todo tipo dispositivos !</span></h4>
                    </div>
                    <!-- /col12 -->
                </div>
                <div class="row text-center" style="margin-top: 100px;">
                    <asp:LinkButton ID="InsertButton" CssClass="btn-lg btn-success"
                        Text="Registrar"
                        CommandName="Insert"
                        runat="server" />
                </div>
                <!-- /row -->
            </InsertItemTemplate>
        </asp:FormView>
    </div>
    <!-- /container -->
</asp:Content>

