using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	class Hero
	{
		/// <summary>
		/// иппшлни
		/// </summary>
		/// <param name="name"></param>
		public Hero( string name )
		{
			Name = name;
		}
		public string Name;
		public int Agi;
		public int Str;
		public int Int;
		public int Prot;
		public int Dmg;
		public int HP;
		public Weapon CurrentWeapon;
		public Weapon[] Weapons;

		public bool IsLive
		{
			get
			{
				return HP > 0;
			}
		}

		public int SharedDmg
		{
			get
			{
				return Dmg + CurrentWeapon.Dmg;
			}
		}

		public int SharedProt
		{
			get
			{
				return Prot*2; 
				
			}
		}
	}

	class Weapon
	{
		public int Dmg;
	}

	class Arena
	{
		public void PvP( Hero player1, Hero player2 )
		{

			if ( player1.HP < 0 )
			{
				Console.WriteLine( "Победил: " + player2.Name );
				return;
			}
			if ( player2.HP < 0 )
			{
				Console.WriteLine( "Победил: " + player1.Name );
				return;
			}

			Battle( player1, player2 );

			PvP( player1, player2 );
		}

		private void Battle( Hero player1, Hero player2 )
		{
			if ( player1.IsLive )
				player2.HP -= (player1.SharedDmg - player2.SharedProt);
			if ( player2.IsLive )
				player1.HP -= (player2.SharedDmg - player1.SharedProt);
		}

		public void DeathMatch( Hero[] heroes )
		{
			while ( AliveHeroCount( heroes ) > 1 )
			{
				heroes = AliveHero( heroes );

				for ( int i = 0; i < heroes.Length; i++ )
				{
					if ( i == heroes.Length - 1 )
					{
						Battle( heroes[heroes.Length - 1], heroes[0] );
					}
					else
					{
						if (heroes[i].IsLive && heroes[i + 1].IsLive)
						{
							Battle( heroes[i], heroes[i + 1]);
						}

						
					}
				}
			}
			heroes = AliveHero( heroes );
			Console.WriteLine( "Победитель смертельного поединка: " + heroes[0].Name );
		}

		public void TeamMatch( Hero[] red, Hero[] blue )
		{

		}


		private int AliveHeroCount( Hero[] heroes )
		{
			int Count = 0;
			foreach ( Hero hero in heroes )
			{
				if ( hero.HP > 0 )
				{
					Count++;
				}

			}
			return Count;
		}

		private Hero[] AliveHero( Hero[] heroes )
		{
			return heroes.Where( h => h.IsLive ).ToArray();
		}

	}

}

