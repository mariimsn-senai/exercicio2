using System.Collections.Generic;
using MCBONALDSMVC.Models;

namespace MCBONALDSMVC.ViewMoldels
{
    public class PedidoViewModels
    {
        public List<Hamburguer> hamburgueres {get; set;}
        public List<Shake> shake {get; set;}
        public PedidoViewModels()
        {
            this.hamburgueres = new List<Hamburguer>();
            this.shake = new List<Shake>();
        }
    }
}