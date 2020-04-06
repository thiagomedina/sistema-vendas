using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;




namespace SistemaVendas.Models
{
    public class VendaModel
    {
        public string Id { get; set; }
        public string Cliente_Id { get; set; }
        public string Vendedor_Id { get; set; }
        public string ListaProdutos { get; set; }

        public List<ClienteModel> RetornarListaClientes()
        {
            return new ClienteModel().ListarTodosClientes();
        }

        public List<VendedorModel> RetornarListaVendedores()
        {
            return new VendedorModel().ListarTodosVendedores();
        }


        public List<ProdutoModel> RetornarListaProutos()
        {
            return new ProdutoModel().ListarTodosProdutos();
        }



    }






}