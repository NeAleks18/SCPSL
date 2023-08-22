using Sandbox;
using Sandbox.UI;
[Library]
public partial class SandboxHud : HudEntity<RootPanel>
{
	public SandboxHud()
	{
		if ( !Game.IsClient )
			return;

		RootPanel.StyleSheet.Load( "/Styles/sandbox.scss" );

		RootPanel.AddChild<Chat>();
		RootPanel.AddChild<VoiceList>();
		RootPanel.AddChild<VoiceSpeaker>();
		RootPanel.AddChild<Scoreboard<ScoreboardEntry>>();
		RootPanel.AddChild<Health>();
		RootPanel.AddChild<discordLink>();
		RootPanel.AddChild<DevelopStatus>();
		RootPanel.AddChild<InventoryBar>();
		RootPanel.AddChild<CurrentTool>();
		RootPanel.AddChild<Crosshair>();
		
	}
}
