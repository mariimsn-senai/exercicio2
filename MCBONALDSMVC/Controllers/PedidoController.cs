using System;
using MCBONALDSMVC.Models;
using MCBONALDSMVC.Repositorio;
using MCBONALDSMVC.ViewMoldels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MCBONALDSMVC.Controllers
{
    public class PedidoController : Controller
    {
        PedidoRepoditory pedidoRepoditory = new PedidoRepoditory();
        
        HamburguerRepository hamburguerRepository = new HamburguerRepository();
        ShakeRepository shakeRepository = new ShakeRepository();
        public IActionResult Index () {
            PedidoViewModels pvm = new PedidoViewModels();
            pvm.hamburgueres = hamburguerRepository.ObterTodos();
            pvm.shake = shakeRepository.ObterTodos();

            return View (pvm);
        }

        public IActionResult Registrar(IFormCollection form)
        {
            Pedido pedido = new Pedido();

            var nomeShake =  form["shake"];
            Shake shake = new Shake (
            nomeShake,
            shakeRepository.ObterPrecoDe(nomeShake));

            pedido.Shake = shake;

            var nomeHamburguer =  form["hamburguer"];
            Hamburguer hamburguer = new Hamburguer (
            nomeHamburguer,
            hamburguerRepository.ObterPrecoDe(nomeHamburguer));

            pedido.Hamburguer = hamburguer;

            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Endereço = form["telefone"];
            cliente.Telefone = form["telefone"];
            cliente.Email = form["email"];

            pedido.Cliente = cliente;
            pedido.DataDoPedido = DateTime.Now;
            pedido.PrecoTotal = hamburguer.Preco + shake.Preco;

            if(pedidoRepoditory.Inserir(pedido)){
                return View("Sucesso");

            }else{
                return View("Erro");
            }

        }
    }
}