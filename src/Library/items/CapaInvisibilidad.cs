using System;
namespace RoleplayGame.Items
{
    public class BataInvisibilidad : IDefenseItem
    {
        public int DefensePower
        {
            get
            {
                return 20;
            }
        }

        public override string ToString()
        {
            return "Robes";
        }
    }
}