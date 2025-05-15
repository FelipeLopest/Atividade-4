using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Atividade_4
{
    internal class Conexao
    {
        private static string conexaoString = "Server=localhost;Database=clinica;Uid=root;Pwd=";

        public static MySqlConnection ObterConexao()
        {
            return new MySqlConnection(conexaoString);
        }
    }
}
