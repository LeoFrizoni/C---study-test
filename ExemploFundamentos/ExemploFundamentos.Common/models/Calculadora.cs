using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} X {y} = {x * y}");
        }
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Potencia(int x,int y)
        {
            double pot = Math.Pow(x,y);//Classe Math engloba diversos cálculos complexos
            Console.WriteLine($"{x}^{y} = {pot}");
        }
        public void Raiz(int x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"A raíz quadrade de {x} é: {raiz}");
        }
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno do {angulo}° = {Math.Round(seno, 4)}");
        }
        public void Cosseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double cossen = Math.Cos(radiano);
            Console.WriteLine($"Cosseno do {angulo}° = {Math.Round(cossen, 4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tan = Math.Tan(radiano);
            Console.WriteLine($"Tangente do {angulo}° = {Math.Round(tan, 4)}");
        }
    }
}