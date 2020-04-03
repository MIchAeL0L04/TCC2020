using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontEnd.Models
{
    public class funcionario
    {
        public int cod_funcio { get; set; }
        public string nome_funcio { get; set; }
        public string user_funcio { get; set; }
        public string email_funcio { get; set; }
        public string telefone_funcio { get; set; }
        public string senha_funcio { get; set; }
        public string permissao_funcio { get; set; }
    }
}