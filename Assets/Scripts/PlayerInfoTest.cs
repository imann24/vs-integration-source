/*
 * Author(s): Isaiah Mann
 * Description: 
 * Usage: [no notes]
 */

using VolunteerScience;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoTest : MonoBehaviour 
{
	[SerializeField]
	Text playerIDDisplay;
	[SerializeField]
	Text seedDisplay;

	void Awake()
	{
		PlayerController.Get.GetMyID(showPlayerID);
		ExperimentController.Get.GetSeed(showSeed);
	}

	void showPlayerID(int id)
	{
		playerIDDisplay.text = string.Format("Player ID: {0}", id);
	}

	void showSeed(int seed)
	{
		seedDisplay.text = string.Format("Seed: {0}", seed);
	}

}
