namespace ValidadorSenha
{
    public partial class Form1 : Form
    {
        bool VerSenhaTxt = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Senha.Text = string.Empty;
            Lbl_Resultado.Text = "";
        }

        private void Txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            ChecaForcaSenha verifica = new ChecaForcaSenha();
            ChecaForcaSenha.ForcaDaSenha forca;
            forca = verifica.GetForcaDaSenha(Txt_Senha.Text);
            Lbl_Resultado.Text = forca.ToString();
            if(Lbl_Resultado.Text == "Inaceitavel"| Lbl_Resultado.Text == "Fraca")
            {
                Lbl_Resultado.ForeColor = Color.Red;
            }
            if(Lbl_Resultado.Text == "Aceitavel")
            {
                Lbl_Resultado.ForeColor = Color.Blue;
            }
            if(Lbl_Resultado.Text == "Forte"| Lbl_Resultado.Text == "Segura")
            {
                Lbl_Resultado.ForeColor = Color.Green;
            }
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            if (VerSenhaTxt == false)
            {
                Txt_Senha.PasswordChar = '\0';
                VerSenhaTxt = true;
                Btn_Valida.Text = "Esconder  Senha";
            }
            else
            {
                Txt_Senha.PasswordChar = '*';
                VerSenhaTxt = false;
                Btn_Valida.Text = "Ver Senha";
            }
        }
    }
}