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
    public partial class FormCalculadora : Form
    {

        Operando num1;
        Operando num2;
        public FormCalculadora()
        {
            this.num1 = new Operando();
            this.num2 = new Operando();
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperador.Items.Add("");
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add("*");
            this.cmbOperador.Items.Add("/");
            this.cmbOperador.SelectedIndex = 0;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.num1 = new Operando(txtNumber1.Text);
            this.num2 = new Operando(txtNumber2.Text);

            double resultado = Calculadora.Operar(num1, num2, char.Parse(cmbOperador.Text));
            lblResultado.Text = resultado.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnABin_Click(object sender, EventArgs e)
        {
            double resultado = double.Parse(lblResultado.Text);
            if (!String.IsNullOrEmpty (lblResultado.Text)) 
            { 
                lblResultado.Text = Operando.DecimalBinario(resultado);
            }
            
        }

        private void btnADec_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(lblResultado.Text)) 
            {
                lblResultado.Text = Operando.BinarioDecimal(lblResultado.Text);
            }
        }

        private void Limpiar() 
        {
            txtNumber1.Text = "";
            txtNumber2.Text = "";
            cmbOperador.Text = "";
            cmbOperador.Text = "";
            lvlError.Visible = false;
            lvlError2.Visible = false;
            lblRequeridos.Visible = false;

        }

        private static double Operar(string numero1, string numero2, string operador) 
        {
            return 3;
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado = MessageBox.Show("¿Seguro de querer salir?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void txtNumber1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.lvlError.Visible = false;
            if (char.IsLetter(e.KeyChar)) 
            { 
                e.Handled = true;
                this.lvlError.Visible = true;
            }
        }

        private void txtNumber2_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.lvlError2.Visible = false;
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                this.lvlError2.Visible = true;
            }
        }

      
    }
}
