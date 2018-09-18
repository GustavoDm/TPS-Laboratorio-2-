using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class Calculadora : Form
    {

        public Calculadora()
        {
            InitializeComponent();
        }  

        
        private void btnOperar_Click(object sender, EventArgs e)
        {
            Numero num1 = new Numero(txtNumero1.Text);
            Numero num2 = new Numero(txtNumero2.Text);
            string operador = cmbOperador.Text;
            double resultado;
            resultado = Entidades.Calculadora.Operar(num1, num2, operador);
            lblResultado.Text = resultado + "";
        }   


        private void btnLimpiar_Click(object sender, EventArgs e)
        { 
            Limpiar();
        }

        private void Limpiar()
        {
            cmbOperador.Text = "";
            lblResultado.Text = "";
            txtNumero1.Text = "";
            txtNumero2.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Desea Salir?", "Continuar", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(respuesta == DialogResult.Yes)
                this.Close();
        }
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);
        }

      


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
