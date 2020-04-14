using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontEnd.Models
{
    public class ManageData
    {

    }

    public class Pedido
    {
        public int idPedido { get; set; }
        public int atendido { get; set; }
        public int observacao { get; set; }
        public int idFuncionario { get; set; }
    }
}