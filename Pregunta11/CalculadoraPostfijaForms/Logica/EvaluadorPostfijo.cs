using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
namespace CalculadoraPostfijaForms.Logica
{
    internal class EvaluadorPostfijo
    {
    }
}
*/

namespace CalculadoraPostfija.Logica
{
    public class EvaluadorPostfijo
    {
        private string expresionInfija;

        public decimal Evaluar(string expresionPostfija)
        {
            if (expresionPostfija == null)
            {
                throw new ArgumentNullException(nameof(expresionPostfija), "La expresión no puede ser nula.");
            }

            Stack<ExpresionInfija> pilaInfija = new Stack<ExpresionInfija>();
            Stack<decimal> pilaOperandos = new Stack<decimal>();

            string[] elementos = expresionPostfija.Split(' ');

            foreach (string elemento in elementos)
            {
                if (EsNumero(elemento))
                {
                    pilaOperandos.Push(decimal.Parse(elemento));
                    pilaInfija.Push(new ExpresionInfija(elemento));
                }
                else if (EsOperador(elemento))
                {
                    if (pilaOperandos.Count < 2)
                    {
                        throw new InvalidOperationException("La expresión postfija no está bien formada.");
                    }

                    decimal operando2 = pilaOperandos.Pop();
                    decimal operando1 = pilaOperandos.Pop();

                    string infijo2 = pilaInfija.Pop().ToString();
                    string infijo1 = pilaInfija.Pop().ToString();

                    string infijo = $"({infijo1} {elemento} {infijo2})";

                    pilaInfija.Push(new ExpresionInfija(infijo));

                    decimal resultado = RealizarOperacion(operando1, operando2, elemento);

                    pilaOperandos.Push(resultado);
                }
                else
                {
                    throw new InvalidOperationException("Elemento desconocido en la expresión.");
                }
            }

            if (pilaOperandos.Count != 1)
            {
                throw new InvalidOperationException("La expresión postfija no está bien formada.");
            }

            decimal resultadoFinal = pilaOperandos.Pop();
            expresionInfija = pilaInfija.Peek().ToString();

            return resultadoFinal;
        }

        private decimal RealizarOperacion(decimal operando1, decimal operando2, string operador)
        {
            switch (operador)
            {
                case "+":
                    return operando1 + operando2;
                case "-":
                    return operando1 - operando2;
                case "*":
                    return operando1 * operando2;
                case "/":
                    if (operando2 == 0)
                    {
                        throw new DivideByZeroException("No se puede dividir por cero.");
                    }
                    return operando1 / operando2;
                default:
                    throw new InvalidOperationException("Operador no soportado.");
            }
        }

        private bool EsNumero(string elemento)
        {
            return decimal.TryParse(elemento, out _);
        }

        private bool EsOperador(string elemento)
        {
            return elemento == "+" || elemento == "-" || elemento == "*" || elemento == "/";
        }

        public string ObtenerExpresionInfija()
        {
            return expresionInfija;
        }
    }
}
