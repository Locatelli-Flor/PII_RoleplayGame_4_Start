namespace RoleplayGame.Items
{
    public class EspadaFuego : IAttackItem
    {
        public int AttackPower
        {
            get
            {
                return 75;
            }
        }

        public override string ToString()
        {
            return "Espada de fuego";
        }
    }
}