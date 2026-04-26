using UnityEngine;
using AC;

public class SetupOptionsMenu : MonoBehaviour
{

	void Start ()
	{
		GenerateResolutionCycleOptions ();
		InitResolutionVariable ();
	}

	void GenerateResolutionCycleOptions ()
	{
		MenuCycle resolutionCycle = PlayerMenus.GetElementWithName ("Options", "ScreenResolution") as AC.MenuCycle;

		resolutionCycle.optionsArray.Clear ();
		foreach (Resolution resolution in Screen.resolutions)
		{
			string optionLabel = resolution.width.ToString () + " x " + resolution.height.ToString () + " (" + resolution.refreshRateRatio.ToString () + ")";
			resolutionCycle.optionsArray.Add (optionLabel);
		}
	}

	void InitResolutionVariable ()
	{
		GVar variable = GlobalVariables.GetVariable (57); // Replace '0' with your own variable's ID number
		if (variable.IntegerValue == -1)
		{
			for (int i=0; i<Screen.resolutions.Length; i++)
			{
				if (Screen.resolutions[i].width == Screen.currentResolution.width &&
					Screen.resolutions[i].height == Screen.currentResolution.height &&
					Screen.resolutions[i].refreshRateRatio.value == Screen.currentResolution.refreshRateRatio.value)
				{
					variable.IntegerValue = i;

					return;
				}
			}
			variable.IntegerValue = 0;
		}
	}

}