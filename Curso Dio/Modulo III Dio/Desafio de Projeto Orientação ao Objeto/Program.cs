using System;
namespace Desafio_de_Projeto_Orientação_ao_Objeto.src.Entities;

    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            Ninja ninja = new Ninja("Wedge", 23, "Ninja");
            BWizard BlackWizard = new BWizard ("Topapa", 23 "Black Wizard");
            
            
            Console.Write(arus.Attack());
            Console.Write(wizard.Attack());
            Console.Write(ninja.Attack());
            Console.Write(ninja.Attack());
            
        }
    }
