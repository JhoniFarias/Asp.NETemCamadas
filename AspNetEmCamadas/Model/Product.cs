using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetEmCamadas.Model
{
    public class Product
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco_Custo { get; set; }
        public decimal Preco_Venda { get; set; }
        public double Quantidade { get; set; }
        public string Unidade_Medida { get; set; }
        public int Categoria_ID { get; set; }
    }
}