<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostraLectura.aspx.cs" Inherits="M.Inteligente.MostraLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
   
     <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Lectura</h3>
                </div>
                <div class="card-body">
                    <asp:GridView CssClass="table table-hover table-bordered" runat="server" 

                         OnRowCommand="grillaLectura_RowCommand"
                         AutoGenerateColumns="false" ID="grillaLectura">
                        <Columns>
                            <asp:BoundField DataField="tipolb" HeaderText="Tipo de Medidor" />
                            <asp:BoundField DataField="Calendar1" HeaderText=" Fecha de Lectura" />
                           <asp:BoundField DataField="horaTxt" HeaderText="Hora de Lectura" />
                            <asp:BoundField DataField="minutosTxt" HeaderText=" " />
                            <asp:BoundField DataField="consumotxt" HeaderText="Consumo" />

                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>



</asp:Content>
