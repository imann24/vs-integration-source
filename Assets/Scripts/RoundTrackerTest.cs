/*
 * Author(s): Isaiah Mann
 * Description: Tests the get and set round calls in the API
 * Usage: [no notes]
 */

using VolunteerScience;

using UnityEngine;
using UnityEngine.UI;

public class RoundTrackerTest : MonoBehaviour 
{
    int currentRound = 0;

    [SerializeField]
    KeyCode getRoundKey = KeyCode.V;
    [SerializeField]
    KeyCode incrementRoundKey = KeyCode.B;

    [SerializeField]
    Text roundDisplay;

    ExperimentController experiment;

	// Use this for initialization
	void Awake() 
	{
        experiment = ExperimentController.Get;
	}

    void Update()
    {
        if(Input.GetKeyDown(getRoundKey))
        {
            getRound();
        }
        if(Input.GetKeyDown(incrementRoundKey))
        {
            incrememntRound();
        }
    }

    void getRound()
    {
        experiment.GetRound(updateRound);
    }
        
    void updateRound(int round)
    {
        roundDisplay.text = string.Format("Round {0}", round);
        this.currentRound = round;
    }

    void incrememntRound()
    {
        this.currentRound++;
        experiment.SetRound(currentRound);
    }

}
