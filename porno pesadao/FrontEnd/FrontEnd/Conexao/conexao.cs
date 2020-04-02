using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontEnd.Conexao
{
    public class conexao
    {

        MySqlConnection cn = new MySqlConnection("Server=localhost; DataBase=TCC_SEMIK; User=root;pwd=1234567");


        public MySqlConnection MyConectarBD() //Método: MyConectarBD()
        {

            cn.Open();
            return cn;
        }


        public MySqlConnection MyDesConectarBD()  //Método: MyDesConectarBD()
        {

            cn.Close();
            return cn;
        }

    }
}