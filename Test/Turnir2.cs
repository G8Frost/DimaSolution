using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Turnir2:ITournament
    {
        public void Run(Hero[] heroes)
        {
            int countHero = heroes.Length;

            int mid = countHero/2;

            var x = Math.Log(countHero, 2);

            if ( !( ( int )x == x ) )
            {
                Console.WriteLine( "Недопустимое кол-во героев" );
                return;
            }

            Console.WriteLine( mid + " раунд" );

            Hero[] winners = new Hero[mid];
            int y = 0;
            for ( int i = 0; i < countHero; i=i+2 )
            {
                Arena.PvP( heroes[i], heroes[i+1] );
                if ( heroes[i].IsLive )
                {
                    winners[y] = heroes[i];
                }
                else
                {
                    winners[y] = heroes[i+1];
                }
                y++;
            }
            if ( mid != 1 )
            {
                Run( winners );

            }
        }
    }
}
