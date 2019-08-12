using AspNetEmCamadas.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AspNetEmCamadas.BLL
{
    public class CategoriaBLL
    {
        
        DAL dal = new DAL();

        public void InsertCategory(Categoria categoria)
        {
            string sql = "INSERT INTO categoria VALUES('{0}')";
            sql = String.Format(sql,categoria.Nome);
            dal.ExecuteCommandSql(sql);
        }

        public DataTable RetCategory()
        {
            string sql = "SELECT * FROM categoria";

            return dal.RetDataTable(sql);
        }

    }
}