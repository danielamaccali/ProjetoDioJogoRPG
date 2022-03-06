namespace DesafioDioJogoRPG.Entities
{
    class Sorcerers : Character
    {
        public Sorcerers(string Name, int Level, string CharacterType)
            :base(Name, Level, CharacterType)
        {

        }

        public override string Actions()
        {
            return "Feitiçaria";
        }

        public override string ToString()
        {
            return $"{this.Name}, {this.Level}, {this.CharacterType}";
        }
    }
}
