using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gambler_simulation
{
    public class gambler_variables
    {
       
        public const int STAKE = 100;
        public const int BET = 1;
        static int stakeValue;
        static int result;
        public static void Main()
        {
            Console.WriteLine("Welcome to GamblerSimulation program");
        }
       // uc2
        public static int Gamestarted()
        {
            Random random = new Random();
            int Bet = random.Next(0, 2);
            if (Bet == 1)
            {
                stakeValue = STAKE + BET;
                Console.WriteLine("Gambler Won the Game" + stakeValue);
            }
            else
            {
                stakeValue = STAKE - BET;
                Console.WriteLine("Gambler loss the Game" + stakeValue);
            }
            return result;
        }
    }
}


