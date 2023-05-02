using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL.Persistence
{
    public class Conexao
    {
       

        protected SqlConnection Con; 
        protected SqlCommand Cmd;    
        protected SqlDataReader Dr;  
                                     
        

        protected void AbrirConexao()
        {
            try
            {
                //connection string
                Con = new SqlConnection("Data Source=DESKTOP-PEDTC2B;Initial Catalog=master;Integrated Security=True");
                Con.Open();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //MÉTODOS - FECHAR CONEXÃO:

        protected void fecharConexao()
        {
            try
            {
                Con.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
