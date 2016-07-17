using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	class AgiHero:Hero
	{
		public AgiHero( string name, int hp ) 
			: base(name,hp)
		{
		}
		public override int SharedDmg
		{
			get
			{
				return Dmg + CurrentWeapon.Dmg + Agi;
			}
		}
		public override int SharedProt
		{
			get
			{
				return ( ( ( CurrentArmor.Prot + Prot ) * 2 ) + Agi * 4 );
			}
		}
	}

}
