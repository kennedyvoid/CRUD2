using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Model;

namespace DAL.Persistence
{
    public class UsuarioDAL : Conexao
    {
        public void Gravar(Pista u)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("insert into Pista (Nome, Senha, Email) values(@v1, @v2, @v3)", Con);

                Cmd.Parameters.AddWithValue("@v1", u.Nome);
                Cmd.Parameters.AddWithValue("@v2", u.Senha);
                Cmd.Parameters.AddWithValue("@v3", u.Email);

                Cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar Usuario " + ex.Message);
            }
            finally
            {
                fecharConexao();
            }
        }

        public void Atualizar(Pista u)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("update Pista set Nome=@v1, Senha=@v2, Email=@v3 where Id=@v4", Con);

                Cmd.Parameters.AddWithValue("@v1", u.Nome);
                Cmd.Parameters.AddWithValue("@v2", u.Senha);
                Cmd.Parameters.AddWithValue("@v3", u.Email);
                Cmd.Parameters.AddWithValue("@v4", u.Id);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("erro ao atualizar o Ususario" + ex.Message);
            }
            finally
            {
                fecharConexao();
            }
        }

        public void Excluir(int Id)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("delete from Pista where Id=@v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Id);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao excluir o Usuario" + ex.Message);
            }
            finally
            {
                fecharConexao();
            }
        }

        public Pista PesquisarPorCodigo(int Id)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("Select * from Pista where Id=@v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Id);
                Dr = Cmd.ExecuteReader();//execução da leitura das informações no BD;
                Pista u = null; //criando um espaço na memoria: ponteiro.

                if (Dr.Read()/*recupera a pessoa encontrada acima*/)
                {
                    u = new Pista();

                    u.Id = Convert.ToInt32(Dr["Id"]);
                    u.Nome = Convert.ToString(Dr["Nome"]);
                    u.Senha = Convert.ToString(Dr["Senha"]);
                    u.Email = Convert.ToString(Dr["Email"]);
                }
                return u;

            }
            catch (Exception ex)
            {

                throw new Exception("erro ao pesquisar a Usuário" + ex.Message);
            }
            finally
            {
                fecharConexao();
            }
        }

        public List<Pista> Listar()
        {

            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Pista", Con);
                Dr = Cmd.ExecuteReader();// pra poder execultar uma consulta e ler os registro obtidos

                var lista = new List<Pista>();

                while (Dr.Read())
                {
                    Pista u = new Pista();

                    u.Id = Convert.ToInt32(Dr["Id"]);
                    u.Nome = Convert.ToString(Dr["Nome"]);
                    u.Senha = Convert.ToString(Dr["Senha"]);
                    u.Email = Convert.ToString(Dr["Email"]);

                    lista.Add(u);


                }
                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("erro ao listar os Usuário " + ex.Message);
            }
            finally
            {
                fecharConexao();
            }

        }

        public Boolean validaEmail( string Email)
        {
            try
            {

                AbrirConexao();
                Cmd = new SqlCommand("Select * from Pista where Email = @v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Email);
                Dr = Cmd.ExecuteReader();//execução da leitura das informações no BD;


                if (Dr.Read()/*recupera a pessoa encontrada acima*/)
                {
                    return true;
                    

                }
                else { 
                return false;
                    }
            }

            catch (Exception ex)
            {

                throw new Exception("erro ao pesquisar o email" + ex.Message);
            }
            finally
            {
                fecharConexao();
            }
        }

        public void casoErro()
        {
            throw new Exception();
        }
    }
}
