using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Hero
    {
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
            if ( player1.HP > 0 )
                player2.HP = player2.HP - ( player1.Dmg + player1.CurrentWeapon.Dmg );
            if ( player2.HP > 0 )
                player1.HP -= player2.Dmg + player2.CurrentWeapon.Dmg;
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
                        Battle( heroes[0], heroes[heroes.Length - 1] );
                    }
                    else
                    {
                        Battle( heroes[i], heroes[i + 1] );
                    }
                }
            }
            heroes = AliveHero( heroes );
            Console.WriteLine( "Победитель смертельного поединка: " + heroes[0].Name );
        }

        public void TeamMatch(Hero[] red, Hero[] blue)
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
            return heroes.Where( h => h.HP > 0 ).ToArray();
        }

    }

}

