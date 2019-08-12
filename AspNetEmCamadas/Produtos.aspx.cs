using AspNetEmCamadas.App_Code;
using AspNetEmCamadas.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetEmCamadas
{
    public partial class Produto : System.Web.UI.Page
    {
        Product produto = new Product();
        ProdutoBLL produtoBLL = new ProdutoBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadDropDownList();
            LoadGridView();
        }
        public void LoadDropDownList()
        {
            ddlCategoriaProduto.DataSource = produtoBLL.RetCategoriasProdutos();
            ddlCategoriaProduto.DataValueField = "id";
            ddlCategoriaProduto.DataTextField = "nome";
            ddlCategoriaProduto.DataBind();
        }
        public void LoadGridView()
        {
            gridProdutos.DataSource = produtoBLL.RetListarProdutos();
            gridProdutos.DataBind();
        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            produto.Nome = Convert.ToString(txtNome.Text);
            produto.Descricao = Convert.ToString(txtDescricao.Text);
            produto.Preco_Custo = Convert.ToDecimal(txtPrecoCusto.Text);
            produto.Preco_Venda = Convert.ToDecimal(txtPrecoVenda.Text);
            produto.Quantidade = Convert.ToDouble(txtQuantidade.Text);
            produto.Unidade_Medida = Convert.ToString(txtUnidadeMedida.Text);
            produto.Categoria_ID = Convert.ToInt32(ddlCategoriaProduto.SelectedValue.ToString());
            produtoBLL.InserirProduto(produto);

            if (String.IsNullOrEmpty(txtID.Text))
            {
                produtoBLL.InserirProduto(produto);

            }
            else{
                produtoBLL.AlterProduto(produto,txtID.Text);
            }
            Response.Write("<script>alert('Funcionou perfeitamente')</script>");

            LoadGridView();

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable data = produtoBLL.LoadProdutoId(Convert.ToString(txtID.Text));
            //pegando os via indice e atribuindo ao campo do formulario para posteriormente fazer o update
            txtNome.Text = data.Rows[0]["nome"].ToString();
            txtDescricao.Text = data.Rows[0]["descricao"].ToString();
            txtPrecoCusto.Text = data.Rows[0]["preco_custo"].ToString();
            txtPrecoVenda.Text = data.Rows[0]["preco_venda"].ToString();
            txtQuantidade.Text = data.Rows[0]["quantidade"].ToString();
            txtUnidadeMedida.Text = data.Rows[0]["unidade_medida"].ToString();
            ddlCategoriaProduto.SelectedValue = data.Rows[0]["categoria_id"].ToString();

        }
    }
}