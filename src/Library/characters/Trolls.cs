using System;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    public class Troll : Character
    {
        public Troll(string name)
            : base(name)
        {
            this.Health = 200;
            this.AddItem(new Palo());
            this.AddItem(new Coraza());

        }
        
        public override void Curar()
        {
            this.Health = 200;
        }
    }
}