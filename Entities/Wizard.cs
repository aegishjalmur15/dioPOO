namespace dioPOO.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType):base(name,level,heroType){}
        public override string Attack()
        {
            return $"Hero: {this.Name} use his magic";
        }
        public override string Attack(int bonus)
        {
            if(bonus > 6){
            return $"Hero: {this.Name} use his magic with {bonus} of bonus";
            }
            return $"Hero: {this.Name} use his magic";
        }
    }
}