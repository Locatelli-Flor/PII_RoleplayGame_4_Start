
namespace RoleplayGame.Items
{
    public class Pelota : IAttackItem
    {
        public int AttackPower
        {
            get
            {
                return 20;
            }
        }

        public override string ToString()
        {
            return "Es como una boleadore, pero con forma de pelota y se patea.";
        }
    }
}