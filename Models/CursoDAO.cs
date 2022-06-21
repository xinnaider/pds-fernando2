using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProjetoEscola.Database;
using ProjetoEscola.Helpers;

namespace ProjetoEscola.Models
{
    class CursoDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Curso curso)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO curso VALUES " +
                "(null, @nome, @cargaH, @turno, @descricao);";

                comando.Parameters.AddWithValue("@nome", curso.NomeCurso);
                comando.Parameters.AddWithValue("@cargaH", curso.CargaH);
                comando.Parameters.AddWithValue("@turno", curso.Turno);
                comando.Parameters.AddWithValue("@descricao", curso.Descricao);


                var resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                {
                    throw new Exception("Ocorreram erros ao salvar as informações");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Curso> List()
        {
            try
            {
                var lista = new List<Curso>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM curso";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var curso = new Curso();

                    curso.Id = reader.GetInt32("id_cur");
                    curso.NomeCurso = DAOHelper.GetString(reader, "nome_cur");
                    curso.CargaH = DAOHelper.GetString(reader, "cargaH_cur");
                    curso.Turno = DAOHelper.GetString(reader, "turno_cur");
                    curso.Descricao = DAOHelper.GetString(reader, "descricao_cur");
                  
                    lista.Add(curso);
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
