/*
 * Author(s): Isaiah Mann
 * Description: Tests the init callback
 * Usage: [no notes]
 */

using VolunteerScience;
using UnityEngine;
using UnityEngine.UI;

public class InitTest : MonoBehaviour 
{
	[SerializeField]
	Text statusDisplay;

	// Use this for initialization
	void Awake() 
	{
		ExperimentController.Get.SubscribeToInitialize(initCallback);	
	}

	void initCallback()
	{
		statusDisplay.text =  string.Format("Status: Initialized");
	}

}
