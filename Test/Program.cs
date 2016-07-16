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
			var Warrior = new Hero("Dima");
			var Mage = new Hero("Shang Tsung");
			var Assassin = new Hero("Artem");
			var Archer = new Hero("Arrow");
			var DeathLord = new Hero("Darth Vader");
			var Paladin = new Hero("Uther");
			var DemonicKnight = new Hero("Archimonde");
			var Destroyer = new Hero("Arthas");

			#region Оружие

			var LongSword = new Weapon();
			var Staff = new Weapon();
			var Daggers = new Weapon();
			var Bow = new Weapon();
			var Scythe = new Weapon();
			var Sword = new Weapon();
			var Axe = new Weapon();
			var Hammer = new Weapon();

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

			#endregion

			#region Параметры героев

			Warrior.HP = 500;
			Warrior.Agi = 5;
			Warrior.Str = 9;
			Warrior.Int = 3;
			Warrior.Prot = 7;
			Warrior.Dmg = 84;
			Warrior.CurrentWeapon = LongSword;
			Console.WriteLine( "Класс: Воин" );
			Console.WriteLine( Warrior.Agi );
			Console.WriteLine( Warrior.Str );
			Console.WriteLine( Warrior.Int );
			Console.WriteLine( Warrior.Prot );
			Console.WriteLine( Warrior.Dmg );

			Mage.HP = 170;
			Mage.Agi = 2;
			Mage.Str = 3;
			Mage.Int = 9;
			Mage.Prot = 4;
			Mage.Dmg = 120;
			Mage.CurrentWeapon = Staff;
			Console.WriteLine( "Класс: Маг" );
			Console.WriteLine( Mage.Agi );
			Console.WriteLine( Mage.Str );
			Console.WriteLine( Mage.Int );
			Console.WriteLine( Mage.Prot );
			Console.WriteLine( Mage.Dmg );

			Assassin.HP = 250;
			Assassin.Agi = 9;
			Assassin.Str = 3;
			Assassin.Int = 6;
			Assassin.Prot = 4;
			Assassin.Dmg = 100;
			Assassin.CurrentWeapon = Daggers;
			Console.WriteLine( "Класс: Ассассин" );
			Console.WriteLine( Assassin.Agi );
			Console.WriteLine( Assassin.Str );
			Console.WriteLine( Assassin.Int );
			Console.WriteLine( Assassin.Prot );
			Console.WriteLine( Assassin.Dmg );

			Archer.HP = 225;
			Archer.Agi = 8;
			Archer.Str = 2;
			Archer.Int = 7;
			Archer.Prot = 4;
			Archer.Dmg = 73;
			Archer.CurrentWeapon = Bow;
			Console.WriteLine( "Класс: Лучник" );
			Console.WriteLine( Archer.Agi );
			Console.WriteLine( Archer.Str );
			Console.WriteLine( Archer.Int );
			Console.WriteLine( Archer.Prot );
			Console.WriteLine( Archer.Dmg );


			DeathLord.HP = 400;
			DeathLord.Agi = 5;
			DeathLord.Str = 7;
			DeathLord.Int = 7;
			DeathLord.Prot = 5;
			DeathLord.Dmg = 90;
			DeathLord.CurrentWeapon = Scythe;
			Console.WriteLine( "Класс: Повелитель Смерти" );
			Console.WriteLine( DeathLord.Agi );
			Console.WriteLine( DeathLord.Str );
			Console.WriteLine( DeathLord.Int );
			Console.WriteLine( DeathLord.Prot );
			Console.WriteLine( DeathLord.Dmg );

			Paladin.HP = 550;
			Paladin.Agi = 4;
			Paladin.Str = 8;
			Paladin.Int = 5;
			Paladin.Prot = 8;
			Paladin.Dmg = 80;
			Paladin.CurrentWeapon = Sword;
			Console.WriteLine( "Класс: Паладин" );
			Console.WriteLine( Paladin.Agi );
			Console.WriteLine( Paladin.Str );
			Console.WriteLine( Paladin.Int );
			Console.WriteLine( Paladin.Prot );
			Console.WriteLine( Paladin.Dmg );

			DemonicKnight.HP = 600;
			DemonicKnight.Agi = 5;
			DemonicKnight.Str = 9;
			DemonicKnight.Int = 4;
			DemonicKnight.Prot = 9;
			DemonicKnight.Dmg = 87;
			DemonicKnight.CurrentWeapon = Axe;
			Console.WriteLine( "Класс: Демонический Рыцарь" );
			Console.WriteLine( DemonicKnight.Agi );
			Console.WriteLine( DemonicKnight.Str );
			Console.WriteLine( DemonicKnight.Int );
			Console.WriteLine( DemonicKnight.Prot );
			Console.WriteLine( DemonicKnight.Dmg );

			Destroyer.HP = 500;
			Destroyer.Agi = 4;
			Destroyer.Str = 10;
			Destroyer.Int = 4;
			Destroyer.Prot = 7;
			Destroyer.Dmg = 99;
			Destroyer.CurrentWeapon = Axe;
			Console.WriteLine( "Класс: Разрушитель" );
			Console.WriteLine( Destroyer.Agi );
			Console.WriteLine( Destroyer.Str );
			Console.WriteLine( Destroyer.Int );
			Console.WriteLine( Destroyer.Prot );
			Console.WriteLine( Destroyer.Dmg );

			#endregion

			var _100XRay = new Arena();
			_100XRay.PvP( Warrior, Assassin );

			Hero[] heroes = new Hero[8];
			heroes[0] = Warrior;
			heroes[1] = Mage;
			heroes[2] = Archer;
			heroes[3] = Assassin;
			heroes[4] = DeathLord;
			heroes[5] = Paladin;
			heroes[6] = DemonicKnight;
			heroes[7] = Destroyer;

			//_100XRay.DeathMatch(heroes);

			//_100XRay.TeamMatch(heroes);

			Console.ReadLine();


		}

	}


}
