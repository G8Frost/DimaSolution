using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	class Arena
	{
		public void PvP( Hero player1, Hero player2 )
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

		private void Battle( Hero player1, Hero player2 )
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
	        int countHero = heroes.Length;

	        int mid = countHero/2;

			var x = Math.Log(countHero, 2);

			if ( !(( int )x == x) )
            {
                Console.WriteLine("Недопустимое кол-во героев");
                return;
            }

			Console.WriteLine( mid + " раунд" );

			Hero[] winners = new Hero[mid];

	        for (int i = 0; i < mid; i++)
	        {
				PvP( heroes[i], heroes[mid+i] );
				if ( heroes[i].IsLive )
				{
					winners[i] = heroes[i];
				}
				else
				{
					winners[i] = heroes[mid + i];
				}
			}
	        if (mid != 1)
	        {
		        Tournament( winners );
		        
	        }
		}
	}
}


