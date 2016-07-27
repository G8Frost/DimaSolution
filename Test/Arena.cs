using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	class Arena
	{
        public ITournament TournamentInterface { get; set; }

		public static void PvP( Hero player1, Hero player2 )
		{
			if (!player1.IsLive)
			{
				Console.WriteLine( "Победил: " + player2.Name );
				return;
			}
			if (!player2.IsLive)
			{
				Console.WriteLine( "Победил: " + player1.Name );
				return;
			}

			Battle( player1, player2 );

			PvP( player1, player2 );
		}

		private static void Battle( Hero player1, Hero player2 )
		{
			if ( player1.IsLive )
				player2.GetDamage( player1.SharedDmg );
			if ( player2.IsLive )
				player1.GetDamage(player2.SharedDmg);
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
			Console.WriteLine("В разработке");
		}


		private int AliveHeroCount( Hero[] heroes )
		{
			int Count = 0;
			foreach ( Hero hero in heroes )
			{
				if ( hero.IsLive )
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
        public void Tournament(Hero[] heroes)
        {
            TournamentInterface.Run(heroes);

        }

	}
}


