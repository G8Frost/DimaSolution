namespace Test
{
	abstract class Hero
	{
		public Hero(string name, int hp)
		{
			Name = name;
			HP = hp + Str * 10;
		}
		public string Name;
		public int Agi;
		public int Str;
		public int Int;
		public int Prot;
		public int Dmg;
		protected int HP;
		public int MP;
		public Weapon CurrentWeapon;
		public Armor CurrentArmor;


		public bool IsLive
		{
			get
			{
				return HP > 0;
			}
		}

		public abstract int SharedDmg { get; }

		public virtual int SharedProt
		{
			get
			{
				return (((CurrentArmor.Prot + Prot)*2) + Agi*2);

			}

		}
		public virtual int Health
		{
			get
			{
				return HP;
			}
		}

		public virtual int Mana
		{
			get
			{
				return MP + Int * 5;
			}
		}

		public void GetDamage(int CountDamage)
		{
			HP -= CountDamage + SharedProt;
		}
	}
}