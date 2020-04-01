using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Models;
using SistemaVendas.Uteis;



namespace SistemaVendas.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {


        ViewBag.ListaClientes = new ClienteModel().ListarTodosClientes();
          
            return View();
        }


           [HttpGet]
             public IActionResult Cadastro(int? id)
        {
            if(id != null){

             ViewBag.Cliente = new ClienteModel().RetornarCliente(id);
            }


            return View();
        }
         [HttpPost]
             public IActionResult Cadastro(ClienteModel cliente)
        {
            if(ModelState.IsValid){
                cliente.Gravar();
                return RedirectToAction("Index");
            }


            return View();
        }
        
             public IActionResult Excluir( int id)

        {

            ViewData[" IdExcluir"] = id;


            return View();
        }

        
             public IActionResult ExcluirCliente( int id)

        {

               new ClienteModel().Excluir(id);

            return View();
        }
    }
}