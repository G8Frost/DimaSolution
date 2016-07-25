using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	class Program
	{
	    static Arena _100XRay;
	    static Hero[] heroes;
	    static Hero Warrior;
	    static Hero Mage;
	    private static Hero Assassin;
	    private static Hero Archer;
		static void Main( string[] args )
		{
			#region Герои

			Warrior = new StrHero("Dima" , 500);
			Mage = new IntHero("Shang Tsung" , 170);
			var Assassin = new AgiHero("Artem" , 250);
			var Archer = new AgiHero("Arrow" , 225);
			var DeathLord = new AgiHero("Darth Vader" , 400);
			var Paladin = new StrHero("Uther" , 550);
			var DemonicKnight = new StrHero("Archimonde", 600);
			var Destroyer = new StrHero("Arthas" , 500);
			var Nightmare = new StrHero("Nightmare" , 700);
			var Lancer = new StrHero("Kai" , 500);

            #endregion

            #region Оружие

            var LongSword = new Weapon();
			var Staff = new Weapon();
			var Daggers = new Weapon();
			var Bow = new Weapon();
			var Scythe = new Weapon();
			var Sword = new Weapon();
			var Axe = new Weapon();
			var Hammer = new Weapon();
			var ChaosSword = new Weapon();
			var Lance = new Weapon();

			#endregion

			#region Броня

			var MediumGear = new Armor();
			var MagicGear = new Armor();
			var ShadowGear = new Armor();
			var LightGear = new Armor();
			var DeathGear = new Armor();
			var HeavyGear = new Armor();
			var DemonicGear = new Armor();
			var ChaosGear = new Armor();

			#endregion

			#region Параметры брони

			MediumGear.Prot = 10;
			MagicGear.Prot = 2;
			ShadowGear.Prot = 4;
			LightGear.Prot = 5;
			DeathGear.Prot = 9;
			HeavyGear.Prot = 15;
			DemonicGear.Prot = 12;
			ChaosGear.Prot = 17;


			#endregion

			#region Параметры оружия

			LongSword.Dmg = 25;
			Staff.Dmg = 15;
			Daggers.Dmg = 20;
			Bow.Dmg = 20;
			Scythe.Dmg = 25;
			Sword.Dmg = 20;
			Axe.Dmg = 25;
			Hammer.Dmg = 30;
			ChaosSword.Dmg = 30;
			Lance.Dmg = 25;

			#endregion

			#region Параметры героев

			Warrior.Agi = 5;
			Warrior.Str = 9;
			Warrior.Int = 3;
			Warrior.Prot = 7;
			Warrior.Dmg = 84;
			Warrior.MP = 170;
			Warrior.CurrentWeapon = LongSword;
			Warrior.CurrentArmor = MediumGear;
			/*Console.WriteLine("Класс: Воин");
            Console.WriteLine("Осн. Хар.: Сила");
			Console.WriteLine(Warrior.Agi);
			Console.WriteLine(Warrior.Str);
			Console.WriteLine(Warrior.Int);
			Console.WriteLine(Warrior.Prot);
			Console.WriteLine(Warrior.Dmg);
            Console.WriteLine(Warrior.Health);
            Console.WriteLine(Warrior.Mana);*/


			Mage.Agi = 2;
			Mage.Str = 3;
			Mage.Int = 10;
			Mage.Prot = 4;
			Mage.Dmg = 220;
			Mage.MP = 500;
			Mage.CurrentWeapon = Staff;
			Mage.CurrentArmor = MagicGear;
			//Console.WriteLine("Класс: Маг");
			//         Console.WriteLine("Осн. Хар.: Интеллект");
			//         Console.WriteLine(Mage.Agi);
			//Console.WriteLine(Mage.Str);
			//Console.WriteLine(Mage.Int);
			//Console.WriteLine(Mage.Prot);
			//Console.WriteLine(Mage.Dmg);
			//         Console.WriteLine(Mage.Health);
			//         Console.WriteLine(Mage.Mana);

			Assassin.Agi = 9;
			Assassin.Str = 3;
			Assassin.Int = 6;
			Assassin.Prot = 4;
			Assassin.Dmg = 200;
			Assassin.MP = 300;
			Assassin.CurrentWeapon = Daggers;
			Assassin.CurrentArmor = ShadowGear;
			//Console.WriteLine("Класс: Ассассин");
			//         Console.WriteLine("Осн. Хар.: Ловкость");
			//         Console.WriteLine(Assassin.Agi);
			//Console.WriteLine(Assassin.Str);
			//Console.WriteLine(Assassin.Int);
			//Console.WriteLine(Assassin.Prot);
			//Console.WriteLine(Assassin.Dmg);
			//         Console.WriteLine(Assassin.Health);
			//         Console.WriteLine(Assassin.Mana);

			Archer.Agi = 8;
			Archer.Str = 2;
			Archer.Int = 7;
			Archer.Prot = 4;
			Archer.Dmg = 173;
			Archer.MP = 400;
			Archer.CurrentWeapon = Bow;
			Archer.CurrentArmor = LightGear;
			//Console.WriteLine("Класс: Лучник");
			//         Console.WriteLine("Осн. Хар.: Ловкость");
			//         Console.WriteLine(Archer.Agi);
			//Console.WriteLine(Archer.Str);
			//Console.WriteLine(Archer.Int);
			//Console.WriteLine(Archer.Prot);
			//Console.WriteLine(Archer.Dmg);
			//         Console.WriteLine(Archer.Health);
			//         Console.WriteLine(Archer.Mana);


			DeathLord.Agi = 7;
			DeathLord.Str = 7;
			DeathLord.Int = 5;
			DeathLord.Prot = 5;
			DeathLord.Dmg = 90;
			DeathLord.MP = 400;
			DeathLord.CurrentWeapon = Scythe;
			DeathLord.CurrentArmor = DeathGear;
			//Console.WriteLine("Класс: Повелитель Смерти");
			//         Console.WriteLine("Осн. Хар.: Сила, Ловкость");
			//         Console.WriteLine(DeathLord.Agi);
			//Console.WriteLine(DeathLord.Str);
			//Console.WriteLine(DeathLord.Int);
			//Console.WriteLine(DeathLord.Prot);
			//Console.WriteLine(DeathLord.Dmg);
			//         Console.WriteLine(DeathLord.Health);
			//         Console.WriteLine(DeathLord.Mana);

			Paladin.Agi = 4;
			Paladin.Str = 8;
			Paladin.Int = 7;
			Paladin.Prot = 8;
			Paladin.Dmg = 80;
			Paladin.MP = 500;
			Paladin.CurrentWeapon = Sword;
			Paladin.CurrentArmor = HeavyGear;
			//Console.WriteLine("Класс: Паладин");
			//         Console.WriteLine("Осн. Хар.: Сила, Интеллект");
			//         Console.WriteLine(Paladin.Agi);
			//Console.WriteLine(Paladin.Str);
			//Console.WriteLine(Paladin.Int);
			//Console.WriteLine(Paladin.Prot);
			//Console.WriteLine(Paladin.Dmg);
			//         Console.WriteLine(Paladin.Health);
			//         Console.WriteLine(Paladin.Mana);

			DemonicKnight.Agi = 5;
			DemonicKnight.Str = 9;
			DemonicKnight.Int = 4;
			DemonicKnight.Prot = 9;
			DemonicKnight.Dmg = 87;
			DemonicKnight.MP = 200;
			DemonicKnight.CurrentWeapon = Axe;
			DemonicKnight.CurrentArmor = DemonicGear;
			//Console.WriteLine("Класс: Демонический Рыцарь");
			//         Console.WriteLine("Осн. Хар.: Сила");
			//         Console.WriteLine(DemonicKnight.Agi);
			//Console.WriteLine(DemonicKnight.Str);
			//Console.WriteLine(DemonicKnight.Int);
			//Console.WriteLine(DemonicKnight.Prot);
			//Console.WriteLine(DemonicKnight.Dmg);
			//         Console.WriteLine(DemonicKnight.Health);
			//         Console.WriteLine(DemonicKnight.Mana);

			Destroyer.Agi = 4;
			Destroyer.Str = 10;
			Destroyer.Int = 4;
			Destroyer.Prot = 7;
			Destroyer.Dmg = 99;
			Destroyer.MP = 150;
			Destroyer.CurrentWeapon = Axe;
			Destroyer.CurrentArmor = MediumGear;
			//Console.WriteLine("Класс: Разрушитель");
			//         Console.WriteLine("Осн. Хар.: Сила");
			//         Console.WriteLine(Destroyer.Agi);
			//Console.WriteLine(Destroyer.Str);
			//Console.WriteLine(Destroyer.Int);
			//Console.WriteLine(Destroyer.Prot);
			//Console.WriteLine(Destroyer.Dmg);
			//         Console.WriteLine(Destroyer.Health);
			//         Console.WriteLine(Destroyer.Mana);

			Nightmare.Agi = 6;
			Nightmare.Str = 10;
			Nightmare.Int = 5;
			Nightmare.Prot = 8;
			Nightmare.Dmg = 115;
			Nightmare.MP = 300;
			Nightmare.CurrentWeapon = ChaosSword;
			Nightmare.CurrentArmor = ChaosGear;
			//Console.WriteLine("Класс: Кошмар");
			//Console.WriteLine("Осн. Хар.: Сила");
			//Console.WriteLine(Nightmare.Agi);
			//Console.WriteLine(Nightmare.Str);
			//Console.WriteLine(Nightmare.Int);
			//Console.WriteLine(Nightmare.Prot);
			//Console.WriteLine(Nightmare.SharedDmg);
			//Console.WriteLine(Nightmare.Health);
			//Console.WriteLine(Nightmare.Mana);

			Lancer.Agi = 4;
			Lancer.Str = 8;
			Lancer.Int = 5;
			Lancer.Prot = 7;
			Lancer.Dmg = 84;
			Lancer.MP = 150;
			Lancer.CurrentWeapon = Lance;
			Lancer.CurrentArmor = MediumGear;
            //Console.WriteLine("Класс: Копейщик");
            //Console.WriteLine("Осн. Хар.: Сила");
            //Console.WriteLine(Lancer.Agi);
            //Console.WriteLine(Lancer.Str);
            //Console.WriteLine(Lancer.Int);
            //Console.WriteLine(Lancer.Prot);
            //Console.WriteLine(Lancer.Dmg);
            //Console.WriteLine(Lancer.Health);
            //Console.WriteLine(Lancer.Mana);

            #endregion

            #region Арена

            _100XRay = new Arena();

			heroes = new Hero[10];
			heroes[0] = Warrior;
			heroes[1] = Mage;
			heroes[2] = Archer;
			heroes[3] = Assassin;
			heroes[4] = DeathLord;
			heroes[5] = Paladin;
			heroes[6] = DemonicKnight;
			heroes[7] = Destroyer;
			heroes[8] = Nightmare;
			heroes[9] = Lancer;

            Hero[] blueteam = new Hero[5];
            blueteam[0] = Mage;
            blueteam[1] = Archer;
            blueteam[2] = Assassin;
            blueteam[3] = Lancer;
            blueteam[4] = Destroyer;

            Hero[] redteam = new Hero[5];
            redteam[0] = Warrior;
            redteam[1] = DeathLord;
            redteam[2] = Paladin;
            redteam[3] = DemonicKnight;
            redteam[4] = Nightmare;

			#endregion

		    SelectGM();

            #region Выбор героя



            #endregion

            Console.ReadLine();
		}

	    private static void SelectGM()
	    {
            #region Выбор режима

            Console.Write( "Выберите режим(PvP(1),DM(2),TM(3),Tournament(4)): " );

            String gm = Console.ReadLine();

            

            switch ( gm )
            {
                case "PvP":
                case "1":
                    _100XRay.PvP( Assassin, Archer );
                    break;
                case "DM":
                case "2":
                    _100XRay.DeathMatch( heroes );
                    break;
                case "TM":
                case "3":
                    _100XRay.TeamMatch( heroes, null );
                    break;
                case "Tournament":
                case "4":
                    _100XRay.Tournament( heroes.Take(8).ToArray());
                    break;
                default:
                    Console.WriteLine( "Ошибка" );
                    SelectGM();
                    break;
                    
            }


            #endregion
        }
    }


}
