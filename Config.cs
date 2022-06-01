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

		[Label("Hide own player vanity")]
		[Tooltip("Toggle vanity on own player")]
		[BackgroundColor(50, 50, 255)]
		[DefaultValue(true)]
		public bool HideOwnVanity;

		[Label("Hide other player vanity")]
		[Tooltip("Toggle vanity on other players")]
		[BackgroundColor(255, 100, 100)]
		[DefaultValue(false)]
		public bool HideOtherVanity;

		[Header("== Toggle All ==")]

		[Label("Hide All Equips")]
		[Tooltip("Toggle if all equips should be hidden (if on, takes precedence over the separate toggles)")]
		[BackgroundColor(200, 0, 0)]
		[DefaultValue(true)]
		public bool HideAllEquips;

		[Header("== Separate toggles ==")]

		[Label("Hide Helmet")]
		[BackgroundColor(100, 100, 255)]
		[DefaultValue(true)]
		public bool HideHead;

		[Label("Hide Chestplate")]
		[BackgroundColor(100, 100, 255)]
		[DefaultValue(true)]
		public bool HideBody;

		[Label("Hide Leggings")]
		[BackgroundColor(100, 100, 255)]
		[DefaultValue(true)]
		public bool HideLegs;

		[Label("Hide Balloon")]
		[DefaultValue(true)]
		public bool HideBalloon;

		[Label("Hide Balloon (Front)")]
		[DefaultValue(true)]
		public bool HideBalloonFront;

		[Label("Hide Main Hand")]
		[DefaultValue(true)]
		public bool HideHandOn;

		[Label("Hide Back Hand")]
		[DefaultValue(true)]
		public bool HideHandOff;

		[Label("Hide Neck")]
		[DefaultValue(true)]
		public bool HideNeck;

		[Label("Hide Shield")]
		[DefaultValue(true)]
		public bool HideShield;

		[Label("Hide Wings")]
		[DefaultValue(true)]
		public bool HideWings;

		[Label("Hide Waist")]
		[DefaultValue(true)]
		public bool HideWaist;

		[Label("Hide Shoe")]
		[DefaultValue(true)]
		public bool HideShoe;

		[Label("Hide Front")]
		[DefaultValue(true)]
		public bool HideFront;

		[Label("Hide Back")]
		[DefaultValue(true)]
		public bool HideBack;

		[Label("Hide Backpack")]
		[DefaultValue(true)]
		public bool HideBackpack;

		[Label("Hide Tail")]
		[DefaultValue(true)]
		public bool HideTail;

		[Label("Hide Face")]
		[DefaultValue(true)]
		public bool HideFace;

		[Label("Hide Beard")]
		[DefaultValue(true)]
		public bool HideBeard;

		[Label("Hide Face (Head)")]
		[DefaultValue(true)]
		public bool HideFaceHead;

		[Label("Hide Face (Flower)")]
		[DefaultValue(true)]
		public bool HideFaceFlower;

		[Label("Hide Yoyo String Color")]
		[DefaultValue(true)]
		public bool HideStringColor;

		[Header("== Special toggles ==")]
		[Label("Hide Yoraiz0r's Spell")]
		[DefaultValue(true)]
		public bool HideYoraiz0rEye;

		[Label("Hide Yoraiz0r's Scowl")]
		[DefaultValue(true)]
		public bool HideYoraiz0rDarkness;

		[Label("Hide Leinfors' Luxury Shampoo")]
		[DefaultValue(true)]
		public bool HideLeinforsHair;

		[Label("Hide Inner Tube")] //
		[DefaultValue(true)]
		public bool HideFloatingTube;

		[Label("Hide Fake Unicorn Horn")]
		[DefaultValue(true)]
		public bool HideUnicornHorn;

		[Label("Hide Angel Halo")]
		[DefaultValue(true)]
		public bool HideAngelHalo;

		[Label("Hide Rainbow Cursor")]
		[DefaultValue(true)]
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
