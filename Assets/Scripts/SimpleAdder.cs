/*
 * Author(s): Isaiah Mann
 * Description: [to be added]
 * Usage: [no notes]
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VolunteerScience;

public class SimpleAdder : MonoBehaviour 
{
	const string NUMBER_1 = "number1";
	const string NUMBER_2 = "number2";

	public Text number1;
	public Text number2;
	public Text result;

	public int num1 = 2;
	public int num2 = 2;

	bool gotNumber1Input = false;
	bool gotNumber2Input = false;

	// Use this for initialization
	void Start() 
	{
		VariableFetcher fetcher = VariableFetcher.Get;
		fetcher.GetValue(NUMBER_1, setNumber1);
		fetcher.GetValue(NUMBER_2, setNumber2);
	}

	void Update()
	{
		if(gotNumber1Input && gotNumber2Input)
		{
			setResult();
		}
	}

	void setResult()
	{
		int sum = num1 + num2;
		result.text = sum.ToString();
		DataCollector collector = DataCollector.Get;
		collector.SetActiveExperiment("test");
		string message = "The sum is " + sum;
		collector.AddDataRow(message);
		Debug.Log(message);
		// Sends to Volunteer Science:
		collector.SubmitLastDataRow();

	}

	void setNumber1(object value)
	{
		try
		{
			num1 = int.Parse(value.ToString());
			number1.text = num1.ToString();
			gotNumber1Input = true;
		}
		catch
		{
			Debug.LogError("Unable to parse number 1");
		}
	}

	void setNumber2(object value)
	{
		try
		{
			num2 = int.Parse(value.ToString());
			number2.text = num2.ToString();
			gotNumber2Input = true;
		}
		catch
		{
			Debug.LogError("Unable to parse number 2");
		}
	}
}
