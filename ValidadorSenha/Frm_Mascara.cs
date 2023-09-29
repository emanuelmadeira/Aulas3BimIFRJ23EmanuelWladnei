using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidadorSenha
{
    public partial class Frm_Mascara : Form
    {
        bool click,click2,click3 = false;

        public Frm_Mascara()
        {
            InitializeComponent();
        }

        private void Btn_Hora_Click(object sender, EventArgs e)
        {
            click2 = true;  
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00:00";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            Btn_VerConteudo.Text = "Validar Hora";
        }
       
        public void verificarhora()
        {
            Uteis verifica = new Uteis();
            Uteis.Força forca;
            forca = verifica.GetForcaHora(Msk_TextBox.Text);
            Lbl_Valida.Text = $"Hora {forca.ToString()}";
        }
        public void verificarData()
        {
            Uteis verifica = new Uteis();
            Uteis.Força forca;
            forca = verifica.GetForcaData(Msk_TextBox.Text);
            Lbl_Valida.Text = $"Data {forca.ToString()}";
        }
        public void verificsenha()
        {
            Uteis verifica = new Uteis();
            Uteis.Força forca;
            forca = verifica.GetForcaSenha(Msk_TextBox.Text);
            Lbl_Valida.Text = $"Senha {forca.ToString()}";
        }


        public void Btn_VerConteudo_Click(object sender, EventArgs e)
        {
            
            Lbl_Conteudo.Text = Msk_TextBox.Text;
            string ent = Msk_TextBox.Text;
            if (Btn_VerConteudo.Text == "Validar Data")
            {
                verificarData();
                
                
            }
           
            if(Btn_VerConteudo.Text == "Validar Hora")
            {
                verificarhora();
                
                
            }
            
            
            if(Btn_VerConteudo.Text=="Validar Senha")
            {
                verificsenha();
                return;
                
            }
            
           
            Btn_VerConteudo.Text = "Ver COnteudo";

        }

            private void Btn_CEP_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00000-000";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            Btn_VerConteudo.Text = "Ver Conteudo";
        }

        private void Btn_Moeda_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "$000,000,000.00";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            Btn_VerConteudo.Text = "Ver Conteudo";
        }

        private void Btn_Data_Click(object sender, EventArgs e)
        {
            click = true;
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00/00/0000";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            Btn_VerConteudo.Text = "Validar Data";
        }

        private void Btn_Telefone_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "(00) 0000-0000";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            Btn_VerConteudo.Text = "Ver COnteudo";
        }

        private void Btn_Senha_Click(object sender, EventArgs e)
        {
            click3 = true;
            Msk_TextBox.UseSystemPasswordChar = true;
            Msk_TextBox.Mask = "";
            Lbl_Conteudo.Text = "";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Btn_VerConteudo.Text = "Validar Senha";

        }
       
    
    }
}
