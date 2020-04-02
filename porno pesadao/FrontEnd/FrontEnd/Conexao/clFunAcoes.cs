using FrontEnd.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FrontEnd.Conexao
{
    public class clFunAcoes
    {
        conexao con = new conexao();

        public void InserirFuncionario(funcionario m)
        {
            MySqlCommand cmd = new MySqlCommand("insert into funcionario values (default,@nome,@user,@tel,@email,@permissao,@senha)", con.MyConectarBD()); // @: PARAMETRO


            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = m.nome_funcio;
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = m.user_funcio;
            cmd.Parameters.Add("@tel", MySqlDbType.VarChar).Value = m.telefone_funcio;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = m.email_funcio;
            cmd.Parameters.Add("@permissao", MySqlDbType.Int32).Value = m.permissao_funcio;
            cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = m.senha_funcio;
           



            cmd.ExecuteNonQuery();
            con.MyDesConectarBD();
        }

        public DataTable consultaFuncionario()
        {
            MySqlCommand cmd = new MySqlCommand("select * from funcionario", con.MyConectarBD());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable Funcionario = new DataTable();
            da.Fill(Funcionario);
            con.MyDesConectarBD();
            return Funcionario;
        }
    }
}