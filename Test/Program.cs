using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var Warrior = new Class();
            var Mage = new Class2();
            var Assassin = new Class3();
            var Archer = new Class4();
            var DeathLord = new Class5();
            Warrior.Agi = 5;
            Warrior.Str = 9;
            Warrior.Int = 3;
            Warrior.Prot = 7;
            Warrior.Dmg = 34;
            Console.WriteLine("Класс: Воин");
            Console.WriteLine(Warrior.Agi);
            Console.WriteLine(Warrior.Str);
            Console.WriteLine(Warrior.Int);
            Console.WriteLine(Warrior.Prot);
            Console.WriteLine(Warrior.Dmg);
            Console.WriteLine("Оружие - Меч");
            Mage.Agi = 2;
            Mage.Str = 3;
            Mage.Int = 9;
            Mage.Prot = 4;
            Mage.Dmg = 53;
            Console.WriteLine("Класс: Маг");
            Console.WriteLine(Mage.Agi);
            Console.WriteLine(Mage.Str);
            Console.WriteLine(Mage.Int);
            Console.WriteLine(Mage.Prot);
            Console.WriteLine(Mage.Dmg);
            Console.WriteLine("Оружие - Посох");
            Assassin.Agi = 9;
            Assassin.Str = 3;
            Assassin.Int = 6;
            Assassin.Prot = 4;
            Assassin.Dmg = 67;
            Console.WriteLine("Класс: Ассассин");
            Console.WriteLine(Assassin.Agi);
            Console.WriteLine(Assassin.Str);
            Console.WriteLine(Assassin.Int);
            Console.WriteLine(Assassin.Prot);
            Console.WriteLine(Assassin.Dmg);
            Console.WriteLine("Оружие - Кинжалы");
            Archer.Agi = 8;
            Archer.Str = 2;
            Archer.Int = 7;
            Archer.Prot = 4;
            Archer.Dmg = 70;
            Console.WriteLine("Класс: Лучник");
            Console.WriteLine(Archer.Agi);
            Console.WriteLine(Archer.Str);
            Console.WriteLine(Archer.Int);
            Console.WriteLine(Archer.Prot);
            Console.WriteLine(Archer.Dmg);
            Console.WriteLine("Оружие - Лук");
            DeathLord.Agi = 5;
            DeathLord.Str = 7;
            DeathLord.Int = 7;
            DeathLord.Prot = 5;
            DeathLord.Dmg = 90;
            Console.WriteLine("Класс: Повелитель Смерти");
            Console.WriteLine(DeathLord.Agi);
            Console.WriteLine(DeathLord.Str);
            Console.WriteLine(DeathLord.Int);
            Console.WriteLine(DeathLord.Prot);
            Console.WriteLine(DeathLord.Dmg);
            Console.WriteLine("Оружие - Коса");
            Console.ReadLine();
            
        }
      
    }
 
    
}
