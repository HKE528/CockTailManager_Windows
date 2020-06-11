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
        }

        public List<CocktailDTO> GetCocktails()
        {
            List<CocktailDTO> cocktails = new List<CocktailDTO>();

            try
            {
                conn.Open();
                command = conn.CreateCommand();

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

                //MessageBox.Show("Sussece");
            }catch(OdbcException e)
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
        public CocktailDTO SelectData(CocktailDTO cocktail)
        {
            CocktailDTO totalInfo = new CocktailDTO();
            try
            {
                conn.Open();
                command = conn.CreateCommand();

                command.CommandText = "select * from cocktail " +
                    "where name = '" + cocktail.name + "'";
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    totalInfo.name = reader.GetString(0);
                    totalInfo.alcohol = reader.GetInt32(1);
                    totalInfo.baseLiquor = reader.GetString(2);
                    totalInfo.material = reader.GetString(3);
                    totalInfo.recipe = reader.GetString(4);

                    return totalInfo;
                }
                else
                {
                    MessageBox.Show("불러오기 실패ㅜ");
                    return null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("불러오기 실패ㅜ");
                return null;
            }
            finally
            {
                reader.Close();
                command.Dispose();
                conn.Close();
            }
        }
        public bool InsertData(CocktailDTO cocktail)
        {
            try
            {
                conn.Open();
                command = conn.CreateCommand();

                command.CommandText = "insert into cockTail values('"
                    + cocktail.name + "', "
                    + cocktail.alcohol + ", '"
                    + cocktail.baseLiquor + "', '"
                    + cocktail.material + "', '"
                    + cocktail.recipe + "')";
                int count = command.ExecuteNonQuery();

                if(count == 1)
                {
                    MessageBox.Show("저장 완료!!");
                    return true;
                }
                else
                {
                    MessageBox.Show("저장 실패ㅜ");
                    return false;
                }
            }catch(Exception e)
            {
                MessageBox.Show("저장 실패ㅜ");
                return false;
            }
            finally
            {
                command.Dispose();
                conn.Close();
            }
        }

        public bool UpdateData(CocktailDTO cocktail)
        {
            try
            {
                conn.Open();
                command = conn.CreateCommand();

                command.CommandText = "update cocktail set " + 
                    "name='"+ cocktail.name + "', " +
                    "alcohol=" + cocktail.alcohol + ", " + 
                    "baseLiquor='"+ cocktail.baseLiquor + "', " +
                    "material='" + cocktail.material + "', " +
                    "recipe='" + cocktail.recipe + "' " + 
                    "where name='"+ cocktail.name + "'";
                int count = command.ExecuteNonQuery();

                if (count == 1)
                {
                    MessageBox.Show("수정 완료!!");
                    return true;
                }
                else
                {
                    MessageBox.Show("수정 실패ㅜ");
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("수정 실패ㅜ");
                return false;
            }
            finally
            {
                command.Dispose();
                conn.Close();
            }
        }

        public bool DeleteData(CocktailDTO cocktail)
        {
            try
            {
                conn.Open();
                command = conn.CreateCommand();

                command.CommandText = "delete from cocktail " +
                    "where name='" + cocktail.name + "'";
                int count = command.ExecuteNonQuery();

                if (count == 1)
                {
                    MessageBox.Show("삭제 완료!!");
                    return true;
                }
                else
                {
                    MessageBox.Show("삭제 실패ㅜ");
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("삭제 실패ㅜ");
                return false;
            }
            finally
            {
                command.Dispose();
                conn.Close();
            }
        }
    }
}
