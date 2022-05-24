namespace Desafio_de_Projeto_Orientação_ao_Objeto.src.Entities
{
    public class BWizard : Hero
    {
        public BWizard (string Name, int Level, string HeroType);
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name + "Atacou com Magia Negra";
        }
        public string Attack(int Bonus){

            if (Bonus > 6){
                return this.Name + " Lançou Magia Negra super efetiva com Bonus " + Bonus;
            }else{
                return this.Name + " Lançou Magia Negra fraca com Bonus " + Bonus;
            }
        }
    }
}