using System;
using System.Collections.Generic;

namespace RoleplayGame.Items
{
    public class GuanteleteDelInfinito : IAttackItem, IDefenseItem
    {
        public List<Gema> listaGemas = new List<Gema>();
        public int AttackPower
        {
            get
            {
                int attackPower = 0;
                foreach(Gema gema in this.listaGemas)
                {
                    attackPower += gema.AttackPower;
                }
                return attackPower;
            }
        }
        public int DefensePower
        {
            get
            {
                int defensePower = 0;
                foreach(Gema gema in this.listaGemas)
                {
                    defensePower += gema.DefensePower;
                }
                return defensePower;
            }
        }

        public override string ToString()
        {
            return "es como el guante de thanos pero usa espadas con forma de gema";
        }

        public void AgregarGema(Gema gema)
        {
            this.listaGemas.Add(gema);
        }
    }
}