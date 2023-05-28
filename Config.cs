using System.ComponentModel;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace HiddenVanity
{
	public class Config : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ClientSide;

		public static Config Instance => ModContent.GetInstance<Config>();

		[BackgroundColor(50, 50, 255)]
		[DefaultValue(true)]
		public bool HideOwnVanity;

		[BackgroundColor(255, 100, 100)]
		[DefaultValue(false)]
		public bool HideOtherVanity;

		[Header("ToggleAll")]

		[BackgroundColor(200, 0, 0)]
		[DefaultValue(true)]
		public bool HideAllEquips;

		[Header("SeparateToggles")]

		[BackgroundColor(100, 100, 255)]
		[DefaultValue(false)]
		public bool HideHead;

		[BackgroundColor(100, 100, 255)]
		[DefaultValue(false)]
		public bool HideBody;

		[BackgroundColor(100, 100, 255)]
		[DefaultValue(false)]
		public bool HideLegs;

		[DefaultValue(false)]
		public bool HideBalloon;

		[DefaultValue(false)]
		public bool HideBalloonFront;

		[DefaultValue(false)]
		public bool HideHandOn;

		[DefaultValue(false)]
		public bool HideHandOff;

		[DefaultValue(false)]
		public bool HideNeck;

		[DefaultValue(false)]
		public bool HideShield;

		[DefaultValue(false)]
		public bool HideWings;

		[DefaultValue(false)]
		public bool HideWaist;

		[DefaultValue(false)]
		public bool HideShoe;

		[DefaultValue(false)]
		public bool HideFront;

		[DefaultValue(false)]
		public bool HideBack;

		[DefaultValue(false)]
		public bool HideBackpack;

		[DefaultValue(false)]
		public bool HideTail;

		[DefaultValue(false)]
		public bool HideFace;

		[DefaultValue(false)]
		public bool HideBeard;

		[DefaultValue(false)]
		public bool HideFaceHead;

		[DefaultValue(false)]
		public bool HideFaceFlower;

		[DefaultValue(false)]
		public bool HideStringColor;

		[Header("SpecialToggles")]

		[DefaultValue(false)]
		public bool HideYoraiz0rEye;

		[DefaultValue(false)]
		public bool HideYoraiz0rDarkness;

		[DefaultValue(false)]
		public bool HideLeinforsHair;

		[DefaultValue(false)]
		public bool HideFloatingTube;

		[DefaultValue(false)]
		public bool HideUnicornHorn;

		[DefaultValue(false)]
		public bool HideAngelHalo;

		[DefaultValue(false)]
		public bool HideRainbowCursor;

		/// <summary>
		/// Check if vanity are hidden for this player (clientside)
		/// </summary>
		public bool HiddenVanity(Player player)
		{
			if (Main.myPlayer == player.whoAmI)
			{
				return HideOwnVanity;
			}
			else
			{
				return HideOtherVanity;
			}
		}
	}
}
