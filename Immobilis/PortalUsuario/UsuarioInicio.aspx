<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/PortalUsuario.master" AutoEventWireup="true" CodeFile="UsuarioInicio.aspx.cs" Inherits="PortalUsuario_UsuarioInicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Home" runat="Server">
    <section class="content-header">
        <h1>Inicio</h1>  
        <ol class="breadcrumb">
            <li><a>Portal Immobilis</a></li>
        </ol>
    </section>
    <section class="content">
        <h1>Angular Spinner!</h1>
        <input type="button" ng-click="startSpin()" value="Start spinner" />
        <input type="button" ng-click="stopSpin()" value="Stop spinner" />
        <br />
        Spinner active: {{spinneractive}}<br />
        Started: {{startcounter}} times<br />
    </section>
</asp:Content>

