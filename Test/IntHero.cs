using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	class IntHero:Hero
	{
		public IntHero(string name,int hp) 
			: base(name,hp)
		{
		}

		public override int SharedDmg {
			get
			{
				return Dmg + CurrentWeapon.Dmg + Int;
			} }
		public override int Mana
		{
			get

			{
				return MP + Int*10;
			}
		}
	}

}
