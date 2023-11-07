using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Cv2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj nazwę postaci");
            string name = Console.ReadLine();
            Console.WriteLine("--------");

            Gracz gracz = new Gracz(2, 1, 100, 1, name, 150, 15);
            Console.WriteLine(gracz.getInfo());
            Console.WriteLine("--------");

            NPC[] npcs = new NPC[4];
            npcs[0] = new NPC(2, 1);
            npcs[1] = new NPC("Kowal", 250, 30, 2, 5);
            npcs[2] = new NPC("Kowal 2", 100, 30, 2, 5);
            npcs[3] = new NPC("Giermek", 1, 30, 2, 5);

            Console.WriteLine(npcs[1].chat());
            Console.WriteLine("--------");

            npcs[0].getDamage(gracz.attac());
            Console.WriteLine(npcs[0].getHp());
            Console.WriteLine("--------");

            gracz.levelUp();
            Console.WriteLine(gracz.getInfo());
            Console.WriteLine("--------");


            npcs[0].getDamage(gracz.attac());
            Console.WriteLine(npcs[0].getHp());
            Console.WriteLine("--------");

            foreach (NPC npc in npcs)
            {
                Console.WriteLine(npc.Nazwa);
            }
            Console.WriteLine("--------");

            gracz.getDamage(npcs[2].attac());


            Console.ReadKey();

        }
    }
}
