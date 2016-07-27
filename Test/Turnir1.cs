using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Turnir1 : ITournament
    {
        public void Run( Hero[] heroes )
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

            for ( int i = 0; i < mid; i++ )
            {
                Arena.PvP( heroes[i], heroes[mid + i] );
                if ( heroes[i].IsLive )
                {
                    winners[i] = heroes[i];
                }
                else
                {
                    winners[i] = heroes[mid + i];
                }
            }
            if ( mid != 1 )
            {
                Run( winners );

            }
        }
    }
}
