/*
 * Author(s): Isaiah Mann
 * Description: Used to test loading images in VS
 * Usage: [no notes]
 */

using UnityEngine;
using UnityEngine.UI;

using VolunteerScience;

public class ImageLoadingTest : MonoBehaviour 
{
	[SerializeField]
	Image display;
	[SerializeField]
	string fileName;

	// Use this for initialization
	void Start() 
	{
		FileLoader.Get.LoadImage(fileName, setImage);
	}

	void setImage(Sprite sprite)
	{
		display.sprite = sprite;
	}

}
