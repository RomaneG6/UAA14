
namespace Immo
{
    using System.Data;
    using MySql.Data.MySqlClient;
    using System.Diagnostics;

    internal class Program
    {
        static void Main(string[] args)
        {
            //Connection String
            //String connectionString = "Server=" + host + ";Database=" + database
            // + ";port=" + port + ";User Id=" + username + ";password=" + password;
        }
        static string DefinirCheminBD() // détermine la chaîne de connexion
        {
            return "server=localhost;database=immo;port=3306;User Id=romane;password=root";
        }

    }
}