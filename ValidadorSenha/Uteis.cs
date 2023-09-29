using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ValidadorSenha
{
    public class Uteis
    {

        int simbolo;
        int maiscula;
        int minuscula;
        int tamanho;
        public enum Força
        {
            Fraca,
            Forte,
            Valida,
            Invalida
        }

        public Força GetForcaHora(string num)
        {
            string inputSemMasc = num.Replace(":", "");
            inputSemMasc = inputSemMasc.Trim();
            if (inputSemMasc == "")
            {
                MessageBox.Show("Voce nao digitou uma hora");
                return Força.Invalida;
            }
            else
            {
                string horas2 = num.Substring(0, 2);
                string minutos2 = num.Substring(3, 2);

                int horas = int.Parse(horas2);
                int minutos = int.Parse(minutos2);

                if (horas >= 0 && horas <= 23 && minutos >= 0 && minutos <= 59)
                {
                    return Força.Valida;
                }
                else
                {
                    return Força.Invalida;
                }
            }
        }
        public Força GetForcaData(string num )
        {
            string semmascara = num.Replace("/", "");
            semmascara = semmascara.Trim();
            if (semmascara == "")
            {
                MessageBox.Show("Voce nao digitou data");
                return Força.Invalida;
            }
            if (num.Length != 10) return Força.Invalida;
            int dia = int.Parse(num.Substring(0, 2));
            int mes = int.Parse(num.Substring(3, 2));
            int ano = int.Parse(num.Substring(6, 4));

            if (dia >= 1 && dia <= 31 && mes >= 1 && mes <= 12 && ano <= 2100)
            {
                if (mes == 2 && dia > 28) return Força.Invalida;
                if (mes == 2 || mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    if (dia >= 31)
                    {
                        return Força.Invalida;
                    }
                    else
                    {
                        return Força.Valida;
                    }
                }
                else
                {
                    return Força.Valida;
                }
            }
            else
            {
                return Força.Invalida;
            }
        }



        public Força GetForcaSenha(string ent)
        {
            List<string> especiais = new List<string> { "@", "#", "$" };
            List<int> letras = new List<int>();


            foreach (char letra in ent)
            {
                int letr = (int)letra;
                letras.Add(letr);
            }
           
           

          
            

            if (ent.Length >= 8 && ent.Length < 16)
            {
                tamanho += 1;
                if (Regex.IsMatch(ent, "[a-z]"))
                {
                    minuscula = 1;
                    if (Regex.IsMatch(ent, "[A-Z]"))
                    {
                        maiscula = 1;
                        foreach (char letra in ent)
                        {
                            string letr = Convert.ToString(letra);

                            if (especiais.Contains(letr))
                            {
                                simbolo += 1;
                            }
                        }
                        if (simbolo != 1)
                        {
                            MessageBox.Show("Necessita de caracter especial");

                        }
                        else {
                           
                        }
                    }
                    else { MessageBox.Show("Senha necessita de letra maiuscula"); }

                }
                else { MessageBox.Show("Senha necessita de letra minuscula"); }
            }
            else
            {
                MessageBox.Show("Senha não possui entre 8 e 15 caracteres");
            }

           

            if (maiscula >= 1 && minuscula >= 1 && tamanho >= 1 && simbolo >= 1)
            {
                MessageBox.Show("Senha Aceita");
                return Força.Forte;
            }
            else
            {
                return Força.Fraca;
            }
        }
    }
}
