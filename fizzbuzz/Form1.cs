using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fizzbuzz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Testa se é número e está entre -1000 e 1000       
        public static bool isNumeric1000(string input)
        {
            int result;
            if (int.TryParse(input.Trim(), out result))
            {
                if (result >= -1000 & result <= 1000)
                    return true;
                else return false;
            }
            else return false;
        }

        //Evento alterar o texto de uma das caixas
        private void textChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            TextBox caixa = (TextBox) sender;

            if (caixa.Text.Trim() != "")
            {
                if (isNumeric1000(caixa.Text)) lblMessage.Text = "Numero correcto";                   
                else lblMessage.Text = "Numero fora dos limites ou letras";                               
            }
            else
            {
                lblMessage.Text = "Campo vazio";
            }
        }
        //Evento clicar numa das caixas de texto
        private void mouseclicked(object sender, MouseEventArgs e)
        {
            textChanged(sender, e);
        }

        //Evento clicar em mostrar resultado
        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            if (testBox(textBox1) & testBox(textBox2))
            {
                int num1 = int.Parse(textBox1.Text.Trim());
                int num2 = int.Parse(textBox2.Text.Trim());
                FizBuzz novo = new FizBuzz(num1, num2);
                textBox3.Text = novo.output;
            } else
            {
                lblMessage.Text = "Os números não estão dentro dos limites ou contêm letras";
            }                        
        }

        //Teste à caixa de texto para ver se o numero cumpre os requesitos
        private bool testBox(TextBox t)
        {
            if (t.Text.Trim() != "")
            {
                if (isNumeric1000(t.Text)) return true;
                else return false;
            }
            else
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
