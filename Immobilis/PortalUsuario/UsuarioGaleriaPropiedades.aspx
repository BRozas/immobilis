<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/PortalUsuario.master" AutoEventWireup="true" CodeFile="UsuarioGaleriaPropiedades.aspx.cs" Inherits="PortalUsuario_UsuarioGaleriaPropiedades" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Home" runat="Server">
    <section class="content-header">
        <h1>Galeria de Propiedades</h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i>Inicio</a></li>
            <li><a href="#">Propiedades</a></li>
            <li class="active">Galeria de Propiedades</li>
        </ol>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-6">
                <!-- Box Comment -->
                <div class="box box-widget">
                    <div class="box-header with-border">
                        <%--<div class="user-block">
                            <img class="img-circle" src="../dist/img/user1-128x128.jpg" alt="user image">
                            <span class="username"><a href="#">Jonathan Burke Jr.</a></span>
                            <span class="description">Shared publicly - 7:30 PM Today</span>
                        </div>--%>
                        <!-- /.user-block -->
                        <div class="box-tools">
                            <button class="btn btn-box-tool" data-toggle="tooltip" title="Mark asread"><i class="fa fa-circle-o"></i></button>
                            <button class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i></button>
                            <button class="btn btn-box-tool" data-widget="remove"><i class="fa fa-times"></i></button>
                        </div>
                        <!-- /.box-tools -->
                    </div>
                    <!-- /.box-header -->
                    <div class="box-body">
                        <img class="img-responsive pad" src="../dist/img/photo2.png" alt="Photo">
                        <button class="btn btn-default btn-xs"><i class="fa fa-share"></i>Share</button>
                        <button class="btn btn-default btn-xs"><i class="fa fa-thumbs-o-up"></i>Like</button>
                        <span class="pull-right text-muted">127 likes - 3 comments</span>
                    </div>
                    <!-- /.box-body -->
                    <div class="box-footer box-comments">
                        
                    </div>
                    <!-- /.box-footer -->
                    <div class="box-footer">
                        
                    </div>
                    <!-- /.box-footer -->
                </div>
                <!-- /.box -->
            </div>
            <!-- /.col -->
            <div class="col-md-6">
                <!-- Box Comment -->
                <div class="box box-widget">
                    <div class="box-header with-border">
                        <%--<div class="user-block">
                            <img class="img-circle" src="../dist/img/user1-128x128.jpg" alt="user image">
                            <span class="username"><a href="#">Jonathan Burke Jr.</a></span>
                            <span class="description">Shared publicly - 7:30 PM Today</span>
                        </div>--%>
                        <!-- /.user-block -->
                        <div class="box-tools">
                            <button class="btn btn-box-tool" data-toggle="tooltip" title="Mark as read"><i class="fa fa-circle-o"></i></button>
                            <button class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i></button>
                            <button class="btn btn-box-tool" data-widget="remove"><i class="fa fa-times"></i></button>
                        </div>
                        <!-- /.box-tools -->
                    </div>
                    <!-- /.box-header -->
                    <div class="box-body">
                        <img class="img-responsive pad" src="../dist/img/photo2.png" alt="Photo">
                        <button class="btn btn-default btn-xs"><i class="fa fa-share"></i>Share</button>
                        <button class="btn btn-default btn-xs"><i class="fa fa-thumbs-o-up"></i>Like</button>
                        <span class="pull-right text-muted">127 likes - 3 comments</span>
                    </div>
                    <!-- /.box-body -->
                    <div class="box-footer box-comments">
                        
                    </div>
                    <!-- /.box-footer -->
                    <div class="box-footer">
                        
                    </div>
                    <!-- /.box-footer -->
                </div>
                <!-- /.box -->
            </div>
            <!-- /.col -->
        </div>
    </section>
</asp:Content>

