using System;

namespace RoleplayGame.Items
{
    public class PelotaMesi : IAttackItem, IDefenseItem
    {
        Pelota pelota = new Pelota();
        Magic mesi = new Magic();
        public int AttackPower
        {
            get
            {
                return pelota.AttackPower + mesi.AttackPower;
            }
        }
        public int DefensePower
        {
            get
            {
                return mesi.DefensePower;
            }
        }

        public override string ToString()
        {
            return "Es como pelota pero con el espitiru de mesi";
        }
    }
}