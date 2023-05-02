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
    public partial class Detalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlDados.Visible = false;
        }

        protected void btnPesquisarUsuario(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtId.Text);

                var d = new UsuarioDAL();

                DAL.Model.Pista u = d.PesquisarPorCodigo(Id);

                if (u != null)
                {
                    pnlDados.Visible = true;
                    txtNome.Text = u.Nome;
                    txtSenha.Text = u.Senha;
                    txtEmail.Text = u.Email;
                }
                else
                {
                    lblMensagem.Text = "Usuário não encontrado!";
                    txtId.Text = string.Empty;
                }



            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnExcluirCliente(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtId.Text);

                var u = new DAL.Model.Pista();
                var d = new UsuarioDAL();

                d.Excluir(codigo);

                lblMensagem.Text = "Usuário excluido com sucesso!";

                txtId.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtSenha.Text = string.Empty;
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnAtualizarCliente(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtId.Text);
                var u = new DAL.Model.Pista();
                
                u.Id = Convert.ToInt32(txtId.Text);
                u.Nome = Convert.ToString(txtNome.Text);
                u.Senha = Convert.ToString(txtSenha.Text);
                u.Email = Convert.ToString(txtEmail.Text);

                var d = new UsuarioDAL();
                d.Atualizar(u);

                lblMensagem.Text = "Cliente atualizado com sucesso!";

                txtId.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtSenha.Text = string.Empty;
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }
    }
}