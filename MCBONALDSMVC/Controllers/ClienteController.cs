using System;
using MCBONALDSMVC.Models.Repositario;
using MCBONALDSMVC.Repositorio;
using MCBONALDSMVC.ViewMoldels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MCBONALDSMVC.Controllers
{
    public class ClienteController : Controller
    {
        private const string SESSION_CLIENTE_EMAIL = "cliente_email";
        private ClienteRepositariy clienteRepositariy = new ClienteRepositariy();
        private PedidoRepoditory pedidoRepository = new PedidoRepoditory();
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            ViewData["Action"] = "Login";
            try{
                System.Console.WriteLine("===================");
                System.Console.WriteLine("email");
                System.Console.WriteLine("senha");
                System.Console.WriteLine("===================");

                var usuario = form["email"];
                var senha = form["senha"];

                var cliente = clienteRepositariy.ObterPor(usuario);
                //isso serve para não ter erro ao tentar achar algum usuario.. erro no email----
                if(cliente !=null)
                {
                    //isso é caso erre a senha=====
                    if(cliente.Senha.Equals(senha))
                    {
                        //estamos guardando informacões
                        HttpContext.Session.SetString("SESSION_CLIENTE_EMAIL", usuario);
                        //o usuario não ve as coisas que tem no return view
                        return RedirectToAction("Historico","Cliente");
                    }else{
                        return View("Erro", new RespostasViewModel ("Senha Incorreta"));
                    }
                    //=================
                }else{
                    //é usado esse respostaViewModel para que aparece a mensagem de erro para pessoa, vai ser levado para View- Shared- Erro
                    return View("Erro", new RespostasViewModel($"usuario {usuario} não encontrado"));
                }
                //----------
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("erro");
            }
        }
    public IActionResult Historico()
    {
        var emailCliente = HttpContext.Session.GetString("SESSION_CLIENTE_EMAIL");
        //vai buscar os pedidos do cliente
        var pedidoCliente = pedidoRepository.ObterTodosPorCliente(emailCliente);

        return View(new HistoricoViewModel()
        {
            Pedido = pedidoCliente
        });
    }
    }
}