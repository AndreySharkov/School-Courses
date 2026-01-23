namespace Weapons
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Sword sword = new Sword("Excalibur", 50, 40);
            Bow bow = new Bow("Longbow", 30, 100);
            Gun gun = new Gun("Pistol", 70, 6);

            sword.Attack();
            bow.Attack();
            gun.Attack();
            gun.Attack();
        }
    }
}
