using System;

namespace HealthStatus
{
    internal class Program
    {
        static int health;
        static int currHealth;
        static string healthStatus;

        static void Main()
        {
            health = 100;
            currHealth = health;
            //healthStatus = "Healthy";

            //Console.WriteLine("Hello world.");

            ////Debug
            //currHealth = 100;
            //HUD();
            //currHealth = 75; //Hurt
            //HUD();
            //currHealth = 10; //Imminent danger
            //HUD();
            //currHealth = 0; //Dead
            //HUD();

            Console.ForegroundColor = ConsoleColor.Gray;
            //Simulated game play
            HUD();
            TakeDamage(25);
            HUD();
            TakeDamage(65);
            HUD();
            TakeDamage(10);
            HUD();
            TakeDamage(10);
            HUD();

        }

        static void TakeDamage(int dmg)
        {
            currHealth = currHealth - dmg;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nYou took " + dmg + " damage.");
            Console.ForegroundColor = ConsoleColor.Gray;

            //make sure health doesnt go under 0, if it does set it to 0
            if (currHealth < 0)
            {
                currHealth = 0;
                Console.WriteLine("Set health to 0.");
            }
        }

        static void HUD()
        {
            //Check health stataus first then...
            UpdateHealthStatus();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            //HUD
            Console.WriteLine("\n---- HUD ----");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Health: " + currHealth);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Health Status: " + healthStatus);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void UpdateHealthStatus()
        {
            // [][---][---------------------------][------------]
            // 0    10                            75          100
            // [------------------------------------------------]

            //// if health is between 100-75 healthy
            if (currHealth > 75)
            {
                healthStatus = "Healthy";
            }
            else if (currHealth > 10)
            {
                healthStatus = "Hurt";
            }
            else if (currHealth > 0)
            {
                healthStatus = "Imminent Danger";
            }
            else
            {
                healthStatus = "Dead";
            }
        }
    }
}
