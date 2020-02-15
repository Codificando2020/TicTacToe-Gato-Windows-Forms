using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gato
{
    public partial class Form1 : Form
    {
        string Primer_Jugador = "", Segundo_Jugador = ""; short Actual = 1; int Ganar = 0;string Ganador = "";
        public Form1()
        {
            InitializeComponent();
            
            var resultado = MessageBox.Show("¿Desea ser 'X' ?","Seleccion",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
            if (resultado==DialogResult.No)
            {
                Turno_Jugador("X", "O");
                Primer_Jugador = "X";
                Segundo_Jugador = "O";
            }
            else if (resultado == DialogResult.Cancel)
            {
                this.Close();
            }
            else
            {
                Turno_Jugador("O", "X");
                Primer_Jugador = "O";
                Segundo_Jugador = "X";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "")
            {
                var Letra = Turno_Jugador(Primer_Jugador, Segundo_Jugador);
                btn1.Text = Letra.ToString(); Validar_Jugada();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text == "")
            {
                var Letra = Turno_Jugador(Primer_Jugador, Segundo_Jugador);
                btn2.Text = Letra.ToString(); Validar_Jugada();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text=="")
            {
                var Letra = Turno_Jugador(Primer_Jugador, Segundo_Jugador);
                btn3.Text = Letra.ToString(); Validar_Jugada();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Text=="")
            {
                var Letra = Turno_Jugador(Primer_Jugador, Segundo_Jugador);
                btn4.Text = Letra.ToString(); Validar_Jugada();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.Text == "")
            {
                var Letra = Turno_Jugador(Primer_Jugador, Segundo_Jugador);
                btn5.Text = Letra.ToString(); Validar_Jugada();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.Text == "")
            {
                var Letra = Turno_Jugador(Primer_Jugador, Segundo_Jugador);
                btn6.Text = Letra.ToString(); Validar_Jugada();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.Text== "")
            {
                var Letra = Turno_Jugador(Primer_Jugador, Segundo_Jugador);
                btn7.Text = Letra.ToString(); Validar_Jugada();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.Text == "")
            {
                var Letra = Turno_Jugador(Primer_Jugador, Segundo_Jugador);
                btn8.Text = Letra.ToString(); Validar_Jugada();
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.Text == "")
            {
                var Letra = Turno_Jugador(Primer_Jugador, Segundo_Jugador);
                btn9.Text = Letra.ToString(); Validar_Jugada();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public string Turno_Jugador(string Primer_Jugador,string Segundo_Jugador)
        {
            
            if (Actual==1)
            {
                Actual--;
                label1.Text = "Turno : "+Segundo_Jugador.ToString();
                return Primer_Jugador;
            }
            else
            {
                Actual++;
                label1.Text = "Turno : " + Primer_Jugador.ToString();
                return Segundo_Jugador;
            }
        }

        public void Validar_Jugada()
        {
            if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X" || btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X" || btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                Ganador = "X";
                Ganar = 1;
            }
            else if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O" || btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O" || btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                Ganador = "O";
                Ganar = 1;
            }
            else if (btn1.Text=="X"&& btn2.Text == "X" && btn3.Text == "X" || btn4.Text == "X" && btn5.Text == "X"&& btn6.Text == "X"|| btn7.Text == "X"&& btn8.Text == "X"&& btn9.Text == "X")
            {
                Ganador = "X";
                Ganar = 1;
            }
            else if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O" || btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O" || btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                Ganador = "O";
                Ganar = 1;
            }
            else if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X" || btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X" )
            {
                Ganador = "X";
                Ganar = 1;
            }
            else if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O" || btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                Ganador = "O";
                Ganar = 1;
            }
            else
            {
                Empate();
            }
            if (Ganar==1)
            {
                label2.Text = "Ganador : " + Ganador.ToString();
                MessageBox.Show("Ganador : " + Ganador.ToString(), "Fin del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Application.Restart();
            }
        }
        public void Empate()
        {
            if (btn1.Text!=""&& btn2.Text != ""&& btn3.Text != ""&& btn4.Text != ""&& btn5.Text != ""&& btn6.Text != ""&& btn7.Text != ""&& btn8.Text != ""&& btn9.Text != "")
            {
                MessageBox.Show("Empate!", "Fin del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Application.Restart();
            }
        }
    }
}
