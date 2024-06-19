using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPostfijaForms.Logica
{
    internal class CalculadoraPostfija
    {


        public static string ConvertirAPostfijo(string expresion)
        {
            Dictionary<char, int> precedencia = new Dictionary<char, int>
            {
                {'+', 1},
                {'-', 1},
                {'*', 2},
                {'/', 2},
                {'(', 0}
            };

            Stack<char> operadores = new Stack<char>();
            string postfijo = "";
            string numero = "";

            foreach (char caracter in expresion)
            {
                if (char.IsDigit(caracter) || caracter == '.')
                {
                    numero += caracter;
                }
                else
                {
                    if (numero != "")
                    {
                        postfijo += numero + " ";
                        numero = "";
                    }
                    if (caracter == '(')
                    {
                        operadores.Push(caracter);
                    }
                    else if (caracter == ')')
                    {
                        while (operadores.Count > 0 && operadores.Peek() != '(')
                        {
                            postfijo += operadores.Pop() + " ";
                        }
                        if (operadores.Count == 0 || operadores.Peek() != '(')
                        {
                            throw new InvalidOperationException("La expresión contiene paréntesis desbalanceados.");
                        }
                        operadores.Pop(); // Eliminar el parentesis izq
                    }
                    else if (precedencia.ContainsKey(caracter))
                    {
                        while (operadores.Count > 0 && precedencia[operadores.Peek()] >= precedencia[caracter])
                        {
                            postfijo += operadores.Pop() + " ";
                        }
                        operadores.Push(caracter);
                    }
                }
            }

            if (numero != "")
            {
                postfijo += numero + " ";
            }

            while (operadores.Count > 0)
            {
                if (operadores.Peek() == '(')
                {
                    throw new InvalidOperationException("La expresión contiene paréntesis desbalanceados.");
                }
                postfijo += operadores.Pop() + " ";
            }

            return postfijo.Trim();
        }

        public static double EvaluarPostfijo(string expresion)
        {
            Stack<double> pila = new Stack<double>();

            string[] elementos = expresion.Split(' ');

            foreach (string elemento in elementos)
            {
                if (double.TryParse(elemento, out double numero))
                {
                    pila.Push(numero);
                }
                else
                {
                    if (pila.Count < 2)
                    {
                        throw new InvalidOperationException("La expresión postfija no está bien formulada.");
                    }

                    double operando2 = pila.Pop();
                    double operando1 = pila.Pop();
                    double resultado = 0;
                    switch (elemento)
                    {
                        case "+":
                            resultado = operando1 + operando2;
                            break;
                        case "-":
                            resultado = operando1 - operando2;
                            break;
                        case "*":
                            resultado = operando1 * operando2;
                            break;
                        case "/":
                            resultado = operando1 / operando2;
                            break;
                    }
                    pila.Push(resultado);
                }
            }

            if (pila.Count != 1)
            {
                throw new InvalidOperationException("La expresión postfija no está bien formulada.");
            }

            return pila.Pop();
        }





    }
}
