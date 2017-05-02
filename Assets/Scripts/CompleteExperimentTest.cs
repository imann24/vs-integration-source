/*
 * Author(s): Isaiah Mann
 * Description: [to be added]
 * Usage: [no notes]
 */

using UnityEngine;
using VolunteerScience;

public class CompleteExperimentTest : MonoBehaviour 
{
    [SerializeField]
    KeyCode completeExperimentKey = KeyCode.C;

    bool experimentIsComplete = false;

    void Update()
    {
        if(Input.GetKeyDown(completeExperimentKey) && !experimentIsComplete)
        {
            ExperimentController.Get.CompleteExperiment();
            experimentIsComplete = true;
        }
    }

}
