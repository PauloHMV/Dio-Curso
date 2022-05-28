namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public int Salario { get; set; }

        public virtual void Apresentar ()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome} e sou um Professor, e ganho {Salario} ");
        }
    }
}