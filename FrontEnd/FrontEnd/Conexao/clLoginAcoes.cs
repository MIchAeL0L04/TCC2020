using FrontEnd.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontEnd.Conexao
{
    public class clLoginAcoes
    {
        conexao con = new conexao();
        public void inserirLogin(funcionario cm)
        {
            MySqlCommand cmd = new MySqlCommand("insert into funcionario(nome_funcio, usuario_funcio, telefone, email, permissao, senha) values(@Nome, @Usuario, @Telefone, @Email, @Permissao, @Senha)", con.MyConectarBD());

            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = cm.nome_funcio;
            cmd.Parameters.Add("@Usuario", MySqlDbType.VarChar).Value = cm.user_funcio;
            cmd.Parameters.Add("@Telefone", MySqlDbType.VarChar).Value = cm.telefone_funcio;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = cm.email_funcio;
            cmd.Parameters.Add("@Permissao", MySqlDbType.VarChar).Value = cm.permissao_funcio;
            cmd.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = cm.senha_funcio;

            cmd.ExecuteNonQuery();
            con.MyDesConectarBD();

        }

        public static string mail;

        public void TestarUsuario(funcionario user)
        {
            MySqlCommand cmd = new MySqlCommand("select * from funcionario where usuario_funcio = @usuario and senha = @Senha ", con.MyConectarBD());

            cmd.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = user.user_funcio;
            cmd.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = user.senha_funcio;

            MySqlDataReader leitor;

            leitor = cmd.ExecuteReader();

            if (leitor.HasRows)
            {
                while (leitor.Read())
                {

                    {
                        user.user_funcio = Convert.ToString(leitor["usuario"]);
                        user.senha_funcio = Convert.ToString(leitor["Senha"]);
                        user.permissao_funcio = Convert.ToString(leitor["tipo"]);
                    }
                }

            }

            else
            {
                user.user_funcio = null;
                user.senha_funcio = null;
                user.permissao_funcio = null;
            }

            con.MyDesConectarBD();
        }
    }
}