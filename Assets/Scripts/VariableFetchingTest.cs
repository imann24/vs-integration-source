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

public class VariableFetchingTest : MonoBehaviour 
{
    public Text intTest;
    public Text floatTest;
    public Text boolTest;
    public Text stringTest;
    public Text intListTest;
    public Text floatListTest;
    public Text boolListTest;
    public Text stringListTest;
	public Text consumablesTest;

    void Start() 
    {
        VariableFetcher fetch = VariableFetcher.Get;
        fetch.GetInt("int", incrementInt);
        fetch.GetFloat("float", divideFloatByTwo);
        fetch.GetBool("bool", invertBool);
        fetch.GetString("string", setString);
        fetch.GetIntList("intList", sumInts);
        fetch.GetFloatList("floatList", avgFloats);
        fetch.GetBoolList("boolList", countBools);
        fetch.GetValueList("stringList", concatStrings);
		fetch.GetConsumables("unityTest", "unitySet", 2, pickAndSetConsumables);
    }

	void pickAndSetConsumables(string[] choices)
	{
		string selection = choices[Random.Range(0, choices.Length)];
		VariableFetcher.Get.SetConsumables("unityTest", "unitySet", selection);
		consumablesTest.text = string.Format("Picked {0} from {1}", selection, ArrayUtil.ToString(choices));
	}

    void incrementInt(int num) 
    {
        num++;
        intTest.text = "Incremented Value: " + num.ToString();
    }

    void divideFloatByTwo(float num)
    {
        num /= 2f;
        floatTest.text = "Half Value: " + num.ToString();
    }

    void invertBool(bool value)
    {
        value = !value;
        boolTest.text = "Opposite: " + value.ToString();
    }

    void setString(string str)
    {
        stringTest.text = str;
    }

    void sumInts(int[] nums)
    {
        int sum = 0;
        foreach(int num in nums)
        {
            sum += num;
        }
        intListTest.text = "Sum: " + sum.ToString();
    }

    void avgFloats(float[] nums)
    {
        float avg = 0;
        foreach(float num in nums)
        {
            avg += num;
        }
        avg /= (float) nums.Length;
        floatListTest.text = "Average: " + avg.ToString();
    }

    void countBools(bool[] flags)
    {
        int trueCount = 0;
        int falseCount = 0;
        foreach(bool flag in flags)
        {
            if(flag)
            {
                trueCount++;
            }
            else
            {
                falseCount++;
            }
        }
        boolListTest.text = "True: " + trueCount + ", False: " + falseCount;
    }

    void concatStrings(string[] strings)
    {
        string final = string.Empty;
        foreach(string str in strings)
        {
            final += str;
        }
        stringListTest.text = final;
    }

}
