using AspNetEmCamadas.BLL;
using AspNetEmCamadas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetEmCamadas
{
    public partial class CadastroCategoria : System.Web.UI.Page
    {
        Categoria categoria = new Categoria();
        CategoriaBLL categoriaBLL = new CategoriaBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }
        
        public void LoadGridView()
        {
            gridForm.DataSource = categoriaBLL.RetCategory();
            gridForm.DataBind();
        }


        protected void btnGravar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNome.Text))
            {
                categoria.Nome = txtNome.Text;
                categoriaBLL.InsertCategory(categoria);
                LoadGridView();
            }
           
        }

        protected void gridForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write("<script>alert('evento nao programado ainda')</script>");
        }
    }
}