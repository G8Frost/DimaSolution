using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	class StrHero : Hero
	{
		public StrHero( string name , int hp )
			: base( name , hp )
		{
		}
		public override int SharedDmg
		{
			get
			{
				return Dmg + CurrentWeapon.Dmg + Str;
			}
		}

		public override int Health
		{
			get

			{
				return HP + Str * 20;
			}
		}

	}
}
