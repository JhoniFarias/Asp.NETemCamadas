<%@ Page Title="" Language="C#" MasterPageFile="~/template.Master" AutoEventWireup="true" CodeBehind="CadastroCategoria.aspx.cs" Inherits="AspNetEmCamadas.CadastroCategoria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <div class="row justify-content-center">
        <div class="col-12 col-md-8 col-sm-12">

            <form id="formCategoria" runat="server">

                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" CssClass="form-control-plaintext" Text="Digite uma nova categoria:"></asp:Label>
                    <asp:TextBox ID="txtNome" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <asp:Button ID="btnGravar" runat="server" Text="Inserir Categoria" CssClass=" btn btn-success" OnClick="btnGravar_Click" />
                <asp:GridView ID="gridForm" runat="server" CssClass="table table-bordered" OnSelectedIndexChanged="gridForm_SelectedIndexChanged" />
            </form>

        </div>
    </div>
</asp:Content>
