// (c) Copyright HutongGames, LLC 2010-2014. All rights reserved.
/*--- __ECO__ __ACTION__ ---*/

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Vector2")]
	[Tooltip("Multiplies a Vector2 variable by a Float.")]
	[HelpUrl("https://hutonggames.fogbugz.com/default.asp?W1018")]
	public class Vector2Multiply : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The vector to Multiply")]
		public FsmVector2 vector2Variable;
		
		[RequiredField]
		[Tooltip("The multiplication factor")]
		public FsmFloat multiplyBy;
		
		[Tooltip("Repeat every frame")]
		public bool everyFrame;

		public override void Reset()
		{
			vector2Variable = null;
			multiplyBy = 1;
			everyFrame = false;
		}

		public override void OnEnter()
		{
			vector2Variable.Value = vector2Variable.Value * multiplyBy.Value;
			
			if (!everyFrame)
				Finish();		
		}

		public override void OnUpdate()
		{
			vector2Variable.Value = vector2Variable.Value * multiplyBy.Value;
		}
	}
}

