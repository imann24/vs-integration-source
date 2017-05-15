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
	Text playerNameDisplay;
	[SerializeField]
	Text playerCountDisplay;
	[SerializeField]
	Text seedDisplay;

	void Awake()
	{
		PlayerController player = PlayerController.Get;
		player.GetMyID(showPlayerID);
		player.GetName(showPlayerName);
		player.GetPlayerCount(showPlayerCount);
		ExperimentController.Get.GetSeed(showSeed);
	}

	void showPlayerID(int id)
	{
		playerIDDisplay.text = string.Format("Player ID: {0}", id);
	}
		
	void showPlayerName(string playerName)
	{
		playerNameDisplay.text = string.Format("Player Name: {0}", playerName);
	}

	void showPlayerCount(int playerCount)
	{
		playerCountDisplay.text = string.Format("Player Count: {0}", playerCount);
	}

	void showSeed(int seed)
	{
		seedDisplay.text = string.Format("Seed: {0}", seed);
	}

}
