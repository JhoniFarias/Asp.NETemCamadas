<%@ Page Language="C#" MasterPageFile="~/template.Master" AutoEventWireup="true" CodeBehind="Produtos.aspx.cs" Inherits="AspNetEmCamadas.Produto" %>



<asp:Content ContentPlaceHolderID="head" runat="server">
    <style>
        .container{

        }
    </style>
</asp:Content>

<asp:Content ContentPlaceHolderID="content" runat="server">
    <div class="row justify-content-center">

        <div class="col-12 col-md-8 col-sm-3">
            <form id="form1" runat="server">
                
                    <h1>Cadastro de Produtos</h1>

                    <div class="form-group">
                        <asp:Label runat="server" Text="ID"></asp:Label>
                        <asp:TextBox ID="txtID" runat="server" CssClass="form-control-sm"></asp:TextBox>
                        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-info" OnClick="btnBuscar_Click" />
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" Text="Nome:"></asp:Label>
                        <asp:TextBox ID="txtNome" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" Text="Descrição:"></asp:Label>
                        <asp:TextBox ID="txtDescricao" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" Text="Preço Custo:" CssClass="form-control-plaintext"></asp:Label>
                        <asp:TextBox ID="txtPrecoCusto" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" Text="Preço Venda:" CssClass="form-control-plaintext"></asp:Label>
                        <asp:TextBox ID="txtPrecoVenda" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Quantidade:" CssClass="form-control-plaintext"></asp:Label>
                        <asp:TextBox ID="txtQuantidade" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Unidade Medida:" CssClass="form-control-plaintext"></asp:Label>
                        <asp:TextBox ID="txtUnidadeMedida" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Categoria:" CssClass="form-control-plaintext"></asp:Label>
                        <asp:DropDownList ID="ddlCategoriaProduto" runat="server" CssClass="form-control"></asp:DropDownList>
                    <div />

                        <asp:Button ID="btnGravar" runat="server" Text="Gravar" OnClick="btnGravar_Click" CssClass="btn btn-success form-control" />
                        
                        <asp:GridView ID="gridProdutos" runat="server" CssClass="table table-sm table-bordered table-hover">
                        </asp:GridView>
                    </div>
            </form>
        </div>
    </div>
</asp:Content>
