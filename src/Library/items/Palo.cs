namespace RoleplayGame.Items
{
    public class Palo : IAttackItem
    {
        public int AttackPower
        {
            get
            {
                return 5;
            }
        }

        public override string ToString()
        {
            return "es como una espada pero es un palo";
        }
    }
}