using FrontEnd.Conexao;
using FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrontEnd.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult frmCadFun()
        {


            return View();
        }

        funcionario d = new funcionario();
        clFunAcoes cll = new clFunAcoes();


        public ActionResult FrmConfCadFun(FormCollection frm)
        {

            d.nome_funcio = frm["txtNome"];  //Nome do formulário
            d.user_funcio = frm["txtUsuario"];  //Nome do formulário
            d.email_funcio = frm["txtEmail"];  //Nome do formulário
            d.telefone_funcio = frm["txtTelefone"];  //Nome do formulário
            d.senha_funcio = frm["txtSenha"];  //Nome do formulário
            d.permissao_funcio = frm["txtPermissao"];  //Nome do formulário


            cll.InserirFuncionario(d);

            return View();
        }
    }
}