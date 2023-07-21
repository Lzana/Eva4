<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="M.Inteligente.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">

    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajesLbl" CssClass="text-success"> </asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Ingresar Medidor</h3>
                </div>

                <div class="card-body">
                   
                    <div class="form-group">
                        <label for="serieTxt">Numero de serie</label>
                        <asp:TextBox ID="serietxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label for="tipobl">Tipo Medidor</label>
                        <!--<select >-->
                        <asp:DropDownList runat="server" ID="tipobl" CssClass="form-select" AppendDataBoundItems="true" OnSelectedIndexChanged="tipobl_SelectedIndexChanged">
                            <asp:ListItem Text="Seleccione una opcion"></asp:ListItem>

                      </asp:DropDownList>
                    </div>
                  
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn" OnClick="agregarBtn_Click" Text="Agregar" CssClass="btn btn-primary btn-lg" />

                    </div>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
