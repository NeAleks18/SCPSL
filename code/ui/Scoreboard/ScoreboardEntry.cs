using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;
using System;
using System.Collections.Generic;


namespace Sandbox.UI
{
	public partial class ScoreboardEntry : Panel
	{
		public IClient Client;

		public Label PlayerName;
		public Label Kills;
		public Label Deaths;
		public Label Ping;
		public Label isDeveloper;

		public ScoreboardEntry()
		{
			AddClass( "entry" );

			PlayerName = Add.Label( "PlayerName", "name" );
			Kills = Add.Label( "", "kills" );
			Deaths = Add.Label( "", "deaths" );
			Ping = Add.Label( "", "ping" );
			isDeveloper = Add.Label( "No", "isdeveloper" );
		}

		RealTimeSince TimeSinceUpdate = 0;

		public override void Tick()
		{
			base.Tick();

			if ( !IsVisible )
				return;

			if ( !Client.IsValid() )
				return;

			if ( TimeSinceUpdate < 0.1f )
				return;

			TimeSinceUpdate = 0;
			UpdateData();
		}

		public virtual void UpdateData()
		{
			PlayerName.Text = Client.Name;
			Kills.Text = Client.GetInt( "kills" ).ToString();
			Deaths.Text = Client.GetInt( "deaths" ).ToString();
			Ping.Text = Client.Ping.ToString();
			if ( Client.SteamId == 76561198103612122 )
			{
				isDeveloper.Text = "Yes";
			}
			else
			{
				isDeveloper.Text = "No";
			}
			SetClass( "me", Client == Game.LocalClient );
		}

		public virtual void UpdateFrom( IClient client )
		{
			Client = client;
			UpdateData();
		}
	}
}
