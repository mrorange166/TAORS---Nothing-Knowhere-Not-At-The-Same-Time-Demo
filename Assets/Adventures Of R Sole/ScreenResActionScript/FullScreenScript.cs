using UnityEngine;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace AC
{

	[System.Serializable]
	public class FullScreenScript : Action
	{
		
		// Declare properties here
		public override ActionCategory Category { get { return ActionCategory.Engine; }}
		public override string Title { get { return "Apply Screen Change"; }}

		// Declare variables here
		
			
override public float Run ()
{
    bool isFullScreen = GlobalVariables.GetBooleanValue (58); // Replace '0' with your own variable's ID number
    if (isFullScreen)
    {
	Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, isFullScreen);
	Debug.Log(Screen.currentResolution.width + " : " + Screen.currentResolution.height + " : " + isFullScreen);
	Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
	Debug.Log(Screen.fullScreenMode);
    }
    else
   {
	Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, isFullScreen);
	Debug.Log(Screen.currentResolution.width + " : " + Screen.currentResolution.height + " : " + isFullScreen);
	Screen.fullScreenMode = FullScreenMode.Windowed;
	Debug.Log(Screen.fullScreenMode);
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