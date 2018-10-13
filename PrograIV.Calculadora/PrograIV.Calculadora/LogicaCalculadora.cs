using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograIV.Calculadora
{
    public class LogicaCalculadora
    {
        public string RealizarOperacion (string elPrimerOperando,string elSegundoOperando, string elOperador)
        {
            return string.Empty;

        }
        public double RealizarOperacion (double elPrimerOperando, 
            double elSegundoOperando, string elOperador)
        {
            double elResultado =  0;
            switch (elOperador)
            {
                case "Suma":
                    {
                        elResultado = (elPrimerOperando
                            + elSegundoOperando);
                        break;
                    }
                case "Resta":
                    {
                        elResultado = (elPrimerOperando -
                             elSegundoOperando);
                        break;
                    }
                case "Multiplicacion":
                    {
                        elResultado = (elPrimerOperando
                            * elSegundoOperando);
                        break;
                    }
                case "Division":
                    {
                        elResultado = (elPrimerOperando
                            / elSegundoOperando);
                        break;
                    }
            }
            return elResultado; 
        }
    }
}
