using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	class Program
	{
		static void Main( string[] args )
		{
            #region Герои
            var Warrior = new Hero("Dima");
			var Mage = new Hero("Shang Tsung");
			var Assassin = new Hero("Artem");
			var Archer = new Hero("Arrow");
			var DeathLord = new Hero("Darth Vader");
			var Paladin = new Hero("Uther");
			var DemonicKnight = new Hero("Archimonde");
			var Destroyer = new Hero("Arthas");
            var Nightmare = new Hero("Nightmare");
            var Lancer = new Hero("Kai");
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


            Warrior.HP = 500;
			Warrior.Agi = 5;
			Warrior.Str = 9;
			Warrior.Int = 3;
			Warrior.Prot = 7;
			Warrior.Dmg = 84;
            Warrior.MP = 170;
			Warrior.CurrentWeapon = LongSword;
            Warrior.CurrentArmor = MediumGear;
			Console.WriteLine("Класс: Воин");
            Console.WriteLine("Осн. Хар.: Сила");
			Console.WriteLine(Warrior.Agi);
			Console.WriteLine(Warrior.Str);
			Console.WriteLine(Warrior.Int);
			Console.WriteLine(Warrior.Prot);
			Console.WriteLine(Warrior.Dmg);
            Console.WriteLine(Warrior.Health);
            Console.WriteLine(Warrior.Mana);
           

			Mage.HP = 170;
			Mage.Agi = 2;
			Mage.Str = 3;
			Mage.Int = 10;
			Mage.Prot = 4;
			Mage.Dmg = 120;
            Mage.MP = 500;
			Mage.CurrentWeapon = Staff;
            Mage.CurrentArmor = MagicGear;
			Console.WriteLine("Класс: Маг");
            Console.WriteLine("Осн. Хар.: Интеллект");
            Console.WriteLine(Mage.Agi);
			Console.WriteLine(Mage.Str);
			Console.WriteLine(Mage.Int);
			Console.WriteLine(Mage.Prot);
			Console.WriteLine(Mage.Dmg);
            Console.WriteLine(Mage.Health);
            Console.WriteLine(Mage.Mana);

            Assassin.HP = 250;
			Assassin.Agi = 9;
			Assassin.Str = 3;
			Assassin.Int = 6;
			Assassin.Prot = 4;
			Assassin.Dmg = 100;
            Assassin.MP = 300;
			Assassin.CurrentWeapon = Daggers;
            Assassin.CurrentArmor = ShadowGear;
			Console.WriteLine("Класс: Ассассин");
            Console.WriteLine("Осн. Хар.: Ловкость");
            Console.WriteLine(Assassin.Agi);
			Console.WriteLine(Assassin.Str);
			Console.WriteLine(Assassin.Int);
			Console.WriteLine(Assassin.Prot);
			Console.WriteLine(Assassin.Dmg);
            Console.WriteLine(Assassin.Health);
            Console.WriteLine(Assassin.Mana);

            Archer.HP = 225;
			Archer.Agi = 8;
			Archer.Str = 2;
			Archer.Int = 7;
			Archer.Prot = 4;
			Archer.Dmg = 73;
            Archer.MP = 400;
			Archer.CurrentWeapon = Bow;
            Archer.CurrentArmor = LightGear;
			Console.WriteLine("Класс: Лучник");
            Console.WriteLine("Осн. Хар.: Ловкость");
            Console.WriteLine(Archer.Agi);
			Console.WriteLine(Archer.Str);
			Console.WriteLine(Archer.Int);
			Console.WriteLine(Archer.Prot);
			Console.WriteLine(Archer.Dmg);
            Console.WriteLine(Archer.Health);
            Console.WriteLine(Archer.Mana);


            DeathLord.HP = 400;
			DeathLord.Agi = 5;
			DeathLord.Str = 7;
			DeathLord.Int = 7;
			DeathLord.Prot = 5;
			DeathLord.Dmg = 90;
            DeathLord.MP = 400;
			DeathLord.CurrentWeapon = Scythe;
            DeathLord.CurrentArmor = DeathGear;
			Console.WriteLine("Класс: Повелитель Смерти");
            Console.WriteLine("Осн. Хар.: Сила, Ловкость");
            Console.WriteLine(DeathLord.Agi);
			Console.WriteLine(DeathLord.Str);
			Console.WriteLine(DeathLord.Int);
			Console.WriteLine(DeathLord.Prot);
			Console.WriteLine(DeathLord.Dmg);
            Console.WriteLine(DeathLord.Health);
            Console.WriteLine(DeathLord.Mana);

            Paladin.HP = 550;
			Paladin.Agi = 4;
			Paladin.Str = 8;
			Paladin.Int = 7;
			Paladin.Prot = 8;
			Paladin.Dmg = 80;
            Paladin.MP = 500;
			Paladin.CurrentWeapon = Sword;
            Paladin.CurrentArmor = HeavyGear;
			Console.WriteLine("Класс: Паладин");
            Console.WriteLine("Осн. Хар.: Сила, Интеллект");
            Console.WriteLine(Paladin.Agi);
			Console.WriteLine(Paladin.Str);
			Console.WriteLine(Paladin.Int);
			Console.WriteLine(Paladin.Prot);
			Console.WriteLine(Paladin.Dmg);
            Console.WriteLine(Paladin.Health);
            Console.WriteLine(Paladin.Mana);

            DemonicKnight.HP = 600;
			DemonicKnight.Agi = 5;
			DemonicKnight.Str = 9;
			DemonicKnight.Int = 4;
			DemonicKnight.Prot = 9;
			DemonicKnight.Dmg = 87;
            DemonicKnight.MP = 200;
			DemonicKnight.CurrentWeapon = Axe;
            DemonicKnight.CurrentArmor = DemonicGear;
			Console.WriteLine("Класс: Демонический Рыцарь");
            Console.WriteLine("Осн. Хар.: Сила");
            Console.WriteLine(DemonicKnight.Agi);
			Console.WriteLine(DemonicKnight.Str);
			Console.WriteLine(DemonicKnight.Int);
			Console.WriteLine(DemonicKnight.Prot);
			Console.WriteLine(DemonicKnight.Dmg);
            Console.WriteLine(DemonicKnight.Health);
            Console.WriteLine(DemonicKnight.Mana);

            Destroyer.HP = 500;
			Destroyer.Agi = 4;
			Destroyer.Str = 10;
			Destroyer.Int = 4;
			Destroyer.Prot = 7;
			Destroyer.Dmg = 99;
            Destroyer.MP = 150;
			Destroyer.CurrentWeapon = Axe;
            Destroyer.CurrentArmor = MediumGear;
			Console.WriteLine("Класс: Разрушитель");
            Console.WriteLine("Осн. Хар.: Сила");
            Console.WriteLine(Destroyer.Agi);
			Console.WriteLine(Destroyer.Str);
			Console.WriteLine(Destroyer.Int);
			Console.WriteLine(Destroyer.Prot);
			Console.WriteLine(Destroyer.Dmg);
            Console.WriteLine(Destroyer.Health);
            Console.WriteLine(Destroyer.Mana);

            Nightmare.HP = 700;
            Nightmare.Agi = 6;
            Nightmare.Str = 10;
            Nightmare.Int = 5;
            Nightmare.Prot = 8;
            Nightmare.Dmg = 115;
            Nightmare.MP = 300;
            Nightmare.CurrentWeapon = ChaosSword;
            Nightmare.CurrentArmor = ChaosGear;
            Console.WriteLine("Класс: Кошмар");
            Console.WriteLine("Осн. Хар.: Сила");
            Console.WriteLine(Nightmare.Agi);
            Console.WriteLine(Nightmare.Str);
            Console.WriteLine(Nightmare.Int);
            Console.WriteLine(Nightmare.Prot);
            Console.WriteLine(Nightmare.Dmg);
            Console.WriteLine(Nightmare.Health);
            Console.WriteLine(Nightmare.Mana);

            Lancer.HP = 500;
            Lancer.Agi = 4;
            Lancer.Str = 8;
            Lancer.Int = 5;
            Lancer.Prot = 7;
            Lancer.Dmg = 84;
            Lancer.MP = 150;
            Lancer.CurrentWeapon = Lance;
            Lancer.CurrentArmor = MediumGear;
            Console.WriteLine("Класс: Копейщик");
            Console.WriteLine("Осн. Хар.: Сила");
            Console.WriteLine(Lancer.Agi);
            Console.WriteLine(Lancer.Str);
            Console.WriteLine(Lancer.Int);
            Console.WriteLine(Lancer.Prot);
            Console.WriteLine(Lancer.Dmg);
            Console.WriteLine(Lancer.Health);
            Console.WriteLine(Lancer.Mana);

            #endregion

            #region Арена
            var _100XRay = new Arena();
			//_100XRay.PvP( Warrior, Lancer);

			Hero[] heroes = new Hero[10];
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

			_100XRay.DeathMatch(heroes);

			//_100XRay.TeamMatch(heroes);

			Console.ReadLine();
            #endregion
        }

    }


}
