namespace RoleplayGame.Items
{
    public class Coraza : IDefenseItem
    {
        public int DefensePower
        {
            get
            {
                return 15;
            }
        }

        public override string ToString()
        {
            return "es como una una bata de invisibilidad pero sin la invisibilidad";
        }
    }
}