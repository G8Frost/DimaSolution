//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace GTAScripts
//{
//	public class TestScript : Script
//	{
//		Ped playerped = Game.Player.Character;
//		Player player = Game.Player;
//		bool modToggle = false;
//		public TestScript()
//		{
//			KeyUp += OnKeyUp;
//			Tick += OnTick;
//		}

//		private void OnTick(object sender, EventArgs e)
//		{
//			if (modToggle)
//			{
//				Vehicle[] vh = World.GetNearbyVehicles(playerped, 700);
//				Ped[] peds = World.GetNearbyPeds(playerped, 700);
//				if (playerped.IsShooting)
//				{
//					for (int i = 0; i < vh.Length; i++)
//					{
//						for (int i1 = 0; i1 < peds.Length; i1++)
//						{
//							if (peds[i1].IsInVehicle())
//							{
//								if (player.IsTargetting(peds[i1]))
//								{
//									peds[i1].Delete();
//								}
//							}
//							else
//							{
//								if (player.IsTargetting(peds[i1]))
//								{
//									peds[i1].ApplyForce(playerped.ForwardVector * 500);
//								}
//							}
//						}
//						if (player.IsTargetting(vh[i]))
//						{
//							vh[i].ApplyForce(playerped.ForwardVector * 500);
//						}
//					}
//				}
//				if (playerped.IsInMeleeCombat)
//				{
//					for (int i2 = 0; i2 < peds.Length; i2++)
//					{
//						if (peds[i2].IsTouching(playerped))
//						{
//							peds[i2].ApplyForce(playerped.ForwardVector * 500);
//						}
//					}
//					for (int i2 = 0; i2 < vh.Length; i2++)
//					{
//						if (vh[i2].IsTouching(playerped))
//						{
//							vh[i2].ApplyForce(playerped.ForwardVector * 500);
//						}
//					}
//				}
//			}
//		}

//		void OnKeyUp(object sender, KeyEventArgs e)
//		{
//			if (e.KeyCode == Keys.F11)
//			{
//				modToggle = !modToggle;
//				if (modToggle)
//				{
//					UI.Notify("Mod has been activated!");
//				}
//				else
//				{
//					UI.Notify("Mod has been deactivated!");
//				}
//			}
//		}
//	}
//}
