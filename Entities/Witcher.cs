

namespace DesafioDioJogoRPG.Entities
{
    class Witcher : Character
    {
        public Witcher(string Name, int Level, string CharacterType)
            :base(Name, Level, CharacterType)
        {
            
        }

        public override string Actions()
        {
            return "Caça monstros";
        }

        public override string ToString()
        {
            return $"{this.Name}, {this.Level}, {this.CharacterType}";
        }
    }
}
