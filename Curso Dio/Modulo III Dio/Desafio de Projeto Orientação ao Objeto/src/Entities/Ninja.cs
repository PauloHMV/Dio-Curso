namespace Desafio_de_Projeto_Orientação_ao_Objeto.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja (string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;            
        }
        public override string Attack(){
            return this.Name + "Atacou com Shuriken";
        }
        public string Attack(int Bonus){
            
            if (Bonus > 6){
                return this.Name + " Lançou Shurikens super efetiva com bonus de " + Bonus;
            }else{
                return this.Name + " Lançou Shurikens com força fraca com bonus de " + Bonus;
            }
        }
    }  
}