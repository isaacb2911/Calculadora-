using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrograIV.Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var laLogica = new LogicaCalculadora();
            txtResultado.Text= laLogica.RealizarOperacion((Convert.ToDouble(txtOperador1.Text),
              Convert.ToDouble(txtOperador2.Text),cbOperador.Text).ToString();
           
            /*  switch (cbOperador.Text)
             {
                 case "Suma":
                      {
                          txtResultado.Text = (Convert.ToDouble(txtOperador1.Text)
                              + Convert.ToDouble(txtOperador2.Text)).ToString();
                          break;
                      }
                  case "Resta":
                      {
                          txtResultado.Text = (Convert.ToDouble(txtOperador1.Text) -
                               Convert.ToDouble(txtOperador2.Text)).ToString();
                          break;
                      }
                  case "Multiplicacion":
                      {
                          txtResultado.Text = (Convert.ToDouble(txtOperador1.Text)
                              * Convert.ToDouble(txtOperador2.Text)).ToString();
                          break;
                      }
                  case "Division":
                      {
                          txtResultado.Text = (Convert.ToDouble(txtOperador1.Text)
                              / Convert.ToDouble(txtOperador2.Text)).ToString();
                          break;
                      }

              }
      */

        }
    }
    }



