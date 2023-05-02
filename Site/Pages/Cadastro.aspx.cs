using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;

namespace Site.Pages
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrarUsuario(object sender, EventArgs e)
        {
            try
            {
                var u = new DAL.Model.Pista();

                u.Nome = txtNome.Text;
                u.Senha = txtSenha.Text;
                u.Email = txtEmail.Text;

                var d = new UsuarioDAL();

                string Id = txtEmail.Text;

                Boolean b = d.validaEmail(Id);

               if (b == true)
                {
                    lblMensagem.Text = ("email já existente");
                    d.casoErro();
                }
                
                d.Gravar(u);// Gravando a pessoa

                lblMensagem.Text = "Pista " + u.Nome + " cadastrado com sucesso!!!";

                txtNome.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtSenha.Text = string.Empty;
            }
            catch (Exception ex)
            {
                int i;

                i = 0 / 1;
                
            }
        }
    }
}