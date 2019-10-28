using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmeController
{
    public class FilmeController
    {
       
        public List<Filme> Listar()
        {
           
            string strConexao = "SERVER=localhost; DataBase=dbhost; UID=root; pwd=";

            using (MySqlConnection conn = new MySqlConnection(strConexao))
            {
                conn.Open();

               
                using (MySqlCommand cmd = new MySqlCommand())
                {

                    string query = "SELECT titulo, produção,ano,classificação,gênero FROM filme";

                   
                    cmd.Connection = conn;
                    cmd.CommandText = query;

                    
                    using (MySqlDataAdapter da = new MySqlDataAdapter())
                    {
                        da.SelectCommand = cmd;

                        
                        DataSet ds = new DataSet();
                        
                        da.Fill(ds, "filme");

                        /
                        List<filme> lstRetorno = ds.Tables["filme"].AsEnumerable().Select(x => new filme
                        {
                           Titulo = x.Field<int>("titulo"),
                            Produção = x.Field<string>("produção"),
                            Classificação = x.Field<string>("classificação"),
                            Genero = x.Field<string>("Genero")

                        }).ToList();

                        
                        return lstRetorno;
                    }
                }
            }
        }

        public Filme Buscar(int id)
        {
            string strConexao = "SERVER=localhost; DataBase=dbhost; UID=root; pwd=";

         
            using (MySqlConnection conn = new MySqlConnection(strConexao))
            {
                
                conn.Open();

               
                using (MySqlCommand cmd = new MySqlCommand())
                {
                   
                    string query = $""SELECT titulo, produção, classificação, gênero where filme" = Filme";

                    
                    cmd.Connection = conn;
                    cmd.CommandText = query;

                    
                    MySqlDataReader reader = cmd.ExecuteReader();

                   
                    Filme retorno = new Filme();

                   while (reader.Read())
                    {
                       
                        retorno.Titulo= (int)reader["Titulo"];
                        retorno.Produção = (string)reader["Produção"];
                        retorno.Classificação= (string)reader["Classificação"];
                        retorno.Genero = (string)reader["Genero"];

                    }

                    return retorno;
                }
            }
        }

        public void Inserir(Filme registro)
        {
           
            string strConexao = "SERVER=localhost; DataBase=dbhost; UID=root; pwd=";

           
            using (MySqlConnection conn = new MySqlConnection(strConexao))
            {
               
                conn.Open();

                
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string query = $"INSERT INTO FIlme (titulo, Produção, Genero,classificação) VALUES ('{registro.titulo}', '{registro.Produção}', '{registro.Genero:}'{registro.classificação:}')')";

                    
                    cmd.Connection = conn;
                    cmd.CommandText = query;

                  
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Pessoa registro)
        {
           
            string strConexao = "SERVER=localhost; DataBase=dbhost; UID=root; pwd=";

            
            using (MySqlConnection conn = new MySqlConnection(strConexao))
            {
                
                conn.Open();

                
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string query = $@"UPDATE Pessoa SET
                                    titulo = '{registro.titulo}',
                                    produção = '{registro.produção}',
                                   genero = '{registro.genero}'
                                    Classificação = '{registro.classificação}'
                                    WHERE id = {registro.Id}";

                    cmd.Connection = conn;
                    cmd.CommandText = query;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id)
        {
            string strConexao = "SERVER=localhost; DataBase=dbhost; UID=root; pwd=";

            using (MySqlConnection conn = new MySqlConnection(strConexao))
            {
             
                conn.Open();

            
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string query = $"DELETE FROM Pessoa WHERE Id = {id}";

                    
                    cmd.Connection = conn;
                    cmd.CommandText = query;

              
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}