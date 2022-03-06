using System;

namespace DesafioDioJogoRPG.Entities
{
    abstract class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string CharacterType { get; set; }

        public Character()
        {

        }

        public Character(string Name, int Level, string CharacterType)
        {
            this.Name = Name;
            this.Level = Level;
            this.CharacterType = CharacterType;
        }

        public virtual string Actions()
        {
            return ("Este personagem faz....");
        }

    }
}
