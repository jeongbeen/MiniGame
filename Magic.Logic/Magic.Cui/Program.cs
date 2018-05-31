using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic.Logic;

namespace Magic.Cui
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            int num = 1;
            while (true)
            {
                Console.WriteLine(game.GetNum(1)+"|"+ game.GetNum(2) + "|" + game.GetNum(3) + "\n" + game.GetNum(4) + "|" + game.GetNum(5) + "|" + game.GetNum(6) + "\n" + game.GetNum(7) + "|" + game.GetNum(8) + "|" + game.GetNum(9)+"\n=====");
                //Console.WriteLine(num+"번에 들어갈 큐브 번호 입력");
                string input = Console.ReadLine();

                if (input.Length != 2)
                    continue;

                game.Put(Int32.Parse(input[0].ToString()), Int32.Parse(input[1].ToString()));

                num++;
                if (num == 10)
                {
                    if (game.IsCompleted())
                    {
                        Console.WriteLine("Finish!");
                        break;
                    }
                    else
                    {
                        num = 1;
                        game.Restart();
                    }
                }
                
            }
        }
    }
}
