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
            var Warrior = new Hero("Dima");
            var Mage = new Hero("Shang Tsung");
            var Assassin = new Hero("Artem");
            var Archer = new Hero("Arrow");
            var DeathLord = new Hero("Darth Vader");

            var Sword = new Weapon();
            var Staff = new Weapon();
            var Daggers = new Weapon();
            var Bow = new Weapon();
            var Scythe = new Weapon();

            Sword.Dmg = 20;
            Staff.Dmg = 10;
            Daggers.Dmg = 15;
            Bow.Dmg = 20;
            Scythe.Dmg = 25;

            Warrior.HP = 500;
            Warrior.Agi = 5;
            Warrior.Str = 9;
            Warrior.Int = 3;
            Warrior.Prot = 7;
            Warrior.Dmg = 34;
            Warrior.CurrentWeapon = Sword;
            Console.WriteLine("Класс: Воин");
            Console.WriteLine(Warrior.Agi);
            Console.WriteLine(Warrior.Str);
            Console.WriteLine(Warrior.Int);
            Console.WriteLine(Warrior.Prot);
            Console.WriteLine(Warrior.Dmg);

            Mage.HP = 130;
            Mage.Agi = 2;
            Mage.Str = 3;
            Mage.Int = 9;
            Mage.Prot = 4;
            Mage.Dmg = 53;
            Mage.CurrentWeapon = Staff;
            Console.WriteLine("Класс: Маг");
            Console.WriteLine(Mage.Agi);
            Console.WriteLine(Mage.Str);
            Console.WriteLine(Mage.Int);
            Console.WriteLine(Mage.Prot);
            Console.WriteLine(Mage.Dmg);

            Assassin.HP = 250;
            Assassin.Agi = 9;
            Assassin.Str = 3;
            Assassin.Int = 6;
            Assassin.Prot = 4;
            Assassin.Dmg = 67;
            Assassin.CurrentWeapon = Daggers;
            Console.WriteLine("Класс: Ассассин");
            Console.WriteLine(Assassin.Agi);
            Console.WriteLine(Assassin.Str);
            Console.WriteLine(Assassin.Int);
            Console.WriteLine(Assassin.Prot);
            Console.WriteLine(Assassin.Dmg);

            Archer.HP = 200;
            Archer.Agi = 8;
            Archer.Str = 2;
            Archer.Int = 7;
            Archer.Prot = 4;
            Archer.Dmg = 70;
            Archer.CurrentWeapon = Bow;
            Console.WriteLine("Класс: Лучник");
            Console.WriteLine(Archer.Agi);
            Console.WriteLine(Archer.Str);
            Console.WriteLine(Archer.Int);
            Console.WriteLine(Archer.Prot);
            Console.WriteLine(Archer.Dmg);


            DeathLord.HP = 400;
            DeathLord.Agi = 5;
            DeathLord.Str = 7;
            DeathLord.Int = 7;
            DeathLord.Prot = 5;
            DeathLord.Dmg = 90;
            DeathLord.CurrentWeapon = Scythe;
            Console.WriteLine("Класс: Повелитель Смерти");
            Console.WriteLine(DeathLord.Agi);
            Console.WriteLine(DeathLord.Str);
            Console.WriteLine(DeathLord.Int);
            Console.WriteLine(DeathLord.Prot);
            Console.WriteLine(DeathLord.Dmg);

            var _100XRay = new Arena();
            _100XRay.PvP(Warrior, DeathLord);
            
            Hero[] heroes = new Hero[5];
            heroes[0] = Warrior;
            heroes[1] = Mage;
            heroes[2] = Archer;
            heroes[3] = Assassin;
            heroes[4] = DeathLord;

            _100XRay.DeathMatch(heroes);

            Console.ReadLine();

            
        }
      
    }
 
    
}
