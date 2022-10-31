using System;

namespace RoleplayGame.Items
{
    public class Gema : IAttackItem, IDefenseItem
    {
        public int AttackPower
        {
            get
            {
                return 10;
            }
        }
        public int DefensePower
        {
            get
            {
                return 20;
            }
        }

        public override string ToString()
        {
            return "es como una espada pero con forma de gema";
        }
    }
}