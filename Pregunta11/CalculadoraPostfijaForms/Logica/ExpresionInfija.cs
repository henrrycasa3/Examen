using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

namespace CalculadoraPostfijaForms.Logica
{
    internal class ExpresionInfija
    {
    }
}
*/


namespace CalculadoraPostfija.Logica
{
    public class ExpresionInfija
    {
        private string expresion;

        public ExpresionInfija(string expresion)
        {
            this.expresion = expresion;
        }

        public override string ToString()
        {
            return expresion;
        }
    }
}
