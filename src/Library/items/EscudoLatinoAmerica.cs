using System;

namespace RoleplayGame.Items
{
    public class EscudoLatinoAmerica : IDefenseItem
    {
        public int DefensePower {get;set;}

        public EscudoLatinoAmerica()
        {
            this.DefensePower = 10;
        }
    }
}