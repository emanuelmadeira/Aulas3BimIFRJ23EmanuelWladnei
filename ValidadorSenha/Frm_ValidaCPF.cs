using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidadorSenha
{
    public partial class Frm_ValidaCPF : Form
    {
       
        public Frm_ValidaCPF()
        {
            InitializeComponent();
           
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = "";
            Msk_CPF.Text = "";
            Btn_Valida.Text = "Ver Conteudo";
            Msk_CPF.UseSystemPasswordChar = true;
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            
            if (Btn_Valida.Text == "Ver Conteudo")
            {
                Btn_Valida.Text = "Validar";
                Msk_CPF.PasswordChar = '\0';
                Msk_CPF.UseSystemPasswordChar = false;

            }
            else
            {
                bool ValidaCPF = false;
                ValidaCPF valida = new ValidaCPF();
                ValidaCPF = valida.Valida(Msk_CPF.Text);
                if (ValidaCPF == true)
                {
                    Lbl_Resultado.Text = "CPF Válido";
                    Lbl_Resultado.ForeColor = Color.Green;

                }
                else
                {
                    Lbl_Resultado.Text = "CPF Inválido";
                    Lbl_Resultado.ForeColor = Color.Red;
                }

            }
           
        }   
     

        private void Msk_CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
    }
}
