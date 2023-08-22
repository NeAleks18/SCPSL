using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

public class discordLink : Panel
{
	public Label Label;

	public discordLink()
	{
		Label = Add.Label( "dsc.gg/scpsbox", "value" );
		
	}

	public override void Tick()
	{
		var player = Game.LocalPawn;
		if ( player == null ) return;
	}
}
