namespace dioPOO.Entities
{
    public class Hero
    {
        public string? Name;

        public int Level;

        public string? HeroType;

        public Hero(string name, int level, string heroType){
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public Hero(){

        }

        public override string ToString()
        {
            return $"Name: {this.Name} \n Level: {this.Level} \n Type: {this.HeroType}";
        }

        public virtual string Attack(){
            return $"Hero {this.Name} use his sword";
        }
        public virtual string Attack(int bonus){
            return $"Hero {this.Name} use his sword with {bonus} of bonus";
        }
    }
}