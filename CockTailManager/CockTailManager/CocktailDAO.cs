using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CockTailManager
{
    class CocktailDAO
    { 
        private OdbcConnection conn;
        private OdbcCommand command;
        private OdbcDataReader reader;

        public CocktailDAO()
        {
            conn = new OdbcConnection("DSN=cocktail_manager");
            conn.Open();

            command = conn.CreateCommand();
        }

        public List<CocktailDTO> GetCocktails()
        {
            List<CocktailDTO> cocktails = new List<CocktailDTO>();

            try
            {
                command.CommandText = "select * from cocktail";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    CocktailDTO cocktail = new CocktailDTO();

                    cocktail.name = reader.GetString(0);
                    cocktail.alcohol = reader.GetInt32(1);
                    cocktail.baseLiquor = reader.GetString(2);
                    cocktail.material = reader.GetString(3);
                    cocktail.recipe = reader.GetString(4);

                    cocktails.Add(cocktail);
                }

                MessageBox.Show("Sussece");
            }catch(SqlException e)
            {
                MessageBox.Show("Failure");
                Console.WriteLine(e.Message);
            }
            finally
            {
                reader.Close();
                command.Dispose();
                conn.Close();
            }

            return cocktails;
        }
    }
}
