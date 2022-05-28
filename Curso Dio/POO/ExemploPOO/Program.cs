using System;
using ExemploPOO.Models;


    class Program
    {
        static void Main(string[] args)
        {   
            Corrente c = new Corrente();
            c.Creditar(100);
            c.ExibirSaldo();
            
            
            
                //Polimorfismo
            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10));
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10, 10));


            //        //Herança
            // Aluno p1 = new Aluno();            
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Documento = "123456";
            // p1.Nota = 10;
            // p1.Apresentar();

            // Professor p2 = new Professor();            
            // p2.Nome = "Paulo";
            // p2.Idade = 30;
            // p2.Documento = "123456";
            // p2.Salario = 10000;            
            // p2.Apresentar();
            
            
            
                //Encapsulamento
            // //Valores validos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 30);

            // System.Console.WriteLine($"Area: {r.ObterArea()}");

            // //Valores invalidos
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0, 0);

            // System.Console.WriteLine($"Area: {r2.ObterArea()}");



                    //Abstração
            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // p1.Apresentar();
        }
    }
