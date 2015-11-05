<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Portal.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Paginas_Home" %>

<%@ Register Src="../Wuc/Propiedades.ascx" TagName="Propiedades" TagPrefix="Wuc1" %>
<%@ Register Src="../Wuc/Clientes.ascx" TagName="Clientes" TagPrefix="Wuc2" %>
<%@ Register Src="../Wuc/QuienesSomos.ascx" TagName="QuienesSomos" TagPrefix="Wuc3" %>
<%@ Register Src="../Wuc/Contacto.ascx" TagName="Contacto" TagPrefix="Wuc4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Home" ContentPlaceHolderID="Home" runat="server">
    <div class="slide story" id="slide-1" data-slide="1">
        <div class="container">
            <div id="home-row-1" class="row clearfix">
                <div class="col-12">
                    <h1 class="font-semibold">Immobilis<span class="font-thin"></span></h1>
                    <h4 class="font-thin">El portal<span class="font-semibold"> Número 1 </span>para adquirir tu Propiedad</h4>
                    <br>
                    <br>
                    <div class="form-group">
                        <div class="col-sm-3">
                            <div class="input">
                                <input id="demo3" type="text" class="combobox form-control" placeholder="Buscar Región..." autocomplete="off" />
                            </div>
                        </div>
                        <div class="col-sm-3">
                            <div class="input">
                                <input id="demo5" type="text" class="combobox form-control" placeholder="Buscar Comuna..." autocomplete="off" />
                            </div>
                        </div>
                        <div class="col-sm-2">
                            <div class="input">
                                <button type="button" class="btn btn-primary btn-lg">
                                    <span class="icon icon-home"></span>Buscar
                                </button>
                            </div>
                        </div>
                    </div>
                    <br>
                </div>
                <!-- /col-12 -->
            </div>
            <!-- /row -->
            <div id="home-row-2" class="row clearfix">
                <div class="col-12 col-sm-4">
                    <div class="home-hover navigation-slide" data-slide="4">
                        <img src="../../images/s02.png"/>
                    </div>
                    <span>CONFIABILIDAD</span>
                </div>
                <div class="col-12 col-sm-4">
                    <div class="home-hover navigation-slide" data-slide="3">
                        <img src="../../images/s01.png"/>
                    </div>
                    <span>PRESTIGIO</span>
                </div>
                <div class="col-12 col-sm-4">
                    <div class="home-hover navigation-slide" data-slide="5">
                        <img src="../../images/s03.png"/>
                    </div>
                    <span>EFICIENCIA</span>
                </div>
            </div>
            <!-- /row -->
        </div>
        <!-- /container -->
    </div>
    <Wuc1:Propiedades runat="server" />
    <Wuc2:Clientes runat="server" />
    <Wuc3:QuienesSomos runat="server" />
    <Wuc4:Contacto runat="server" />

</asp:Content>
