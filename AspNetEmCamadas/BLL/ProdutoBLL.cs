using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using AspNetEmCamadas.Model;

namespace AspNetEmCamadas
{
    public class ProdutoBLL
    {
        
        DAL dal = new DAL();


        public DataTable RetCategoriasProdutos()
        {
            return dal.RetDataTable("SELECT * FROM categoria");

        }
        public DataTable RetListarProdutos()
        {
            return dal.RetDataTable("SELECT * FROM produto");

        }

        public DataTable LoadProdutoId(string id)
        {
            return dal.RetDataTable("SELECT * FROM produto where id =" + id);

        }



        public void InserirProduto(Product produto)
        {
            string sql = "INSERT INTO produto(nome,descricao,preco_custo,preco_venda,quantidade,unidade_medida,categoria_id)" +
                          "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
            sql = String.Format(sql, produto.Nome, produto.Descricao, produto.Preco_Custo, produto.Preco_Venda, produto.Quantidade, produto.Unidade_Medida, produto.Categoria_ID);
         
            dal.ExecuteCommandSql(sql);
        }

        public void AlterProduto(Product produto,string id)
        {
            string sql = "UPDATE produto SET nome='{0}', descricao='{1}', preco_custo='{2}', preco_venda='{3}', quantidade='{4}', unidadeMedida='{5}', categoria_id ='{6}' WHERE id='{7}'";
            sql = String.Format(sql, produto.Nome, produto.Descricao, produto.Preco_Custo, produto.Preco_Venda, produto.Quantidade, produto.Unidade_Medida, produto.Categoria_ID, id);
            dal.ExecuteCommandSql(sql);
        }

    }
}