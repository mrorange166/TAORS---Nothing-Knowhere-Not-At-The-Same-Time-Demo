using UnityEngine;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace AC
{

	[System.Serializable]
	public class ActionApplyResolution : Action
	{
		
		// Declare properties here
		public override ActionCategory Category { get { return ActionCategory.Engine; }}
		public override string Title { get { return "Apply Resolution"; }}
		public override string Description { get { return "This is a blank Action template."; }}


		// Declare variables here
		
			
		override public float Run ()
		{
			int chosenIndex = GlobalVariables.GetIntegerValue (57); // Replace '0' with your own variable's ID number
			if (chosenIndex >= 0)
		{
			Resolution chosenResolution = Screen.resolutions [chosenIndex];

			Screen.SetResolution (chosenResolution.width, chosenResolution.height, Screen.fullScreen);
			KickStarter.playerMenus.RecalculateAll ();

		}
		return 0f;
		}

		public override void Skip ()
		{

			 Run ();
		}

		
		#if UNITY_EDITOR

		public override void ShowGUI ()
		{
			// Action-specific Inspector GUI code here
		}
		

		public override string SetLabel ()
		{
			// (Optional) Return a string used to describe the specific action's job.
			
			return string.Empty;
		}

		#endif
		
	}

}