using FrontEnd.Conexao;
using FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FrontEnd.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }


        clLoginAcoes ac = new clLoginAcoes();

        public ActionResult Logar(funcionario verLogin )
        {
            ac.TestarUsuario(verLogin);
            ViewBag.mensagem = "Digite o usuário e senha";

            if (verLogin.user_funcio != null && verLogin.senha_funcio != null)
            {
                FormsAuthentication.SetAuthCookie(verLogin.user_funcio, false);
                Session["usuarioLogado"] = verLogin.user_funcio.ToString();
                Session["senhaLogado"] = verLogin.senha_funcio.ToString();



                if (verLogin.permissao_funcio == "1")
                {
                    Session["tipoLogado"] = verLogin.permissao_funcio.ToString();
                }
                else
                {
                    Session["tipoLogado1"] = verLogin.permissao_funcio.ToString();
                }



                clLoginAcoes.mail = Session["usuarioLogado"].ToString();



                return RedirectToAction("About", "Home");
            }

            else
            {
                return View();

            }
        }


        funcionario log = new funcionario();

        public ActionResult CadLogin(FormCollection frm)
        {
            if ((frm["txtEmail"]) != null && (frm["txtSenha"]) != null && (frm["txtconfsenha"]) != null)
            {

                log.user_funcio = frm["txtEmail"];
                log.senha_funcio = frm["txtSenha"];
                string ConfSenha;
                ConfSenha = frm["txtconfsenha"];

                if (log.senha_funcio == ConfSenha)

                {
                    ac.inserirLogin(log);
                    return View();
                }
                else
                {
                    ViewBag.erro = "As senhas não conferem!";
                    return View();
                }
            }
            else
            {
                return View();
            }

        }

        public ActionResult About()
        {


            if ((Session["usuarioLogado"] == null) || (Session["senhaLogado"] == null))

            {
                return RedirectToAction("semAcesso", "Home");
            }
            else
            {
                ViewBag.teste = Session["tipoLogado"];

                return View();
            }
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult semAcesso()
        {
            ViewBag.Message = "Você não pode acessar essa página";

            return View();
        }


        public ActionResult Logout()
        {

            Session["usuarioLogado"] = null;
            Session["senhaLogado"] = null;
            Session["tipoLogado"] = null;
            Session["tipoLogado1"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
    
}