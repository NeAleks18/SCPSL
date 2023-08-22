using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

public class DevelopStatus : Panel
{
	public Label Label;

	public DevelopStatus()
	{
		Label = Add.Label( "[CURRENTLY DEVELOPMENT]", "value" );
		
	}

	public override void Tick()
	{
		var player = Game.LocalPawn;
		if ( player == null ) return;
	}
}
