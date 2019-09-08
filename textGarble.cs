using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Text))]
public class textGarble : MonoBehaviour {

    public int inSpeed = 20;
    public int spread = 80;

    private Text mytext;
    private string contents;
    private string remainder;
    private bool garbleIn;
    private bool garbleOut;

	// Use this for initialization
	void Start () {
        mytext = gameObject.GetComponent<Text>();
        contents = mytext.text;
        garbleIn = false;
        garbleOut = false;
	}
	
	void Update () {

        if (garbleIn)
        {
            int progress = remainder.Length;
            int garbleStart = progress - spread;
            progress += inSpeed;

            if (progress > contents.Length)
            {
                mytext.text = contents;
                garbleIn = false;
            }
            else
            {

                if (garbleStart < 0)
                {
                    garbleStart = 0;
                }

                remainder = getStringRange(contents, 0, progress);
                remainder = randomizeWithRange(remainder, garbleStart, progress);

                mytext.text = remainder;
            }
        }

        if (garbleOut)
        {
            mytext.text = replaceLettersWithRandoms(contents);
        }

	}

    public void GarbleIn(string newContent)
    {
        contents = newContent;
        GarbleIn();
    }

    [ContextMenu("Garble In")]
    public void GarbleIn()
    {
        garbleIn = true;
        remainder = "";
    }

    [ContextMenu("Garble Out")]
    public void GarbleOut()
    {
        garbleOut = true;
        remainder = contents;
    }

    string getRandomCharacter()
    {
        string sampleSpace =
            "abcdefghijklmnopqrstuvwxyz" +
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
            "1234567890";// +
            //"!@#$%^&*()_+{}:<>?][-='.,";
        return sampleSpace[Mathf.RoundToInt(Random.Range(0, sampleSpace.Length - 1))].ToString();
    }

    string getStringRange(string theString,  int start, int finish)
    {
        string answer = "";
        try
        {
            for (int a = start; a < finish; a++)
            {
                answer += theString[a];
            }
        }
        catch
        {
            Debug.Log("string range invalid");
        }
        return answer;
    }

    string replaceRangeOfLetters(string oldString, string newString, int start, int end)
    {
        string answer = "";
        answer += getStringRange(oldString, 0, start - 1);
        answer += newString;
        answer += getStringRange(oldString, end + 1, oldString.Length);
        return answer;
    }

    string replaceOneLetter(string oldString, string newString, int index)
    {
        string answer = "";
        answer += getStringRange(oldString, 0, index - 1);
        answer += newString;
        answer += getStringRange(oldString, index + 1, oldString.Length);
        return answer;
    }

    string randomizeWithRange(string oldString, int start, int end)
    {
        string answer = "";
        answer += getStringRange(oldString, 0, start - 1);
        answer += replaceLettersWithRandoms(getStringRange(oldString, start, end));
        answer += getStringRange(oldString, end + 1, oldString.Length);
        return answer;
    }

    string replaceLettersWithRandoms(string original)
    {
        string answer = "";
        foreach(char i in original)
        {
            if(i != ' ')
            {
                answer += getRandomCharacter();
            }
            else
            {
                answer += " ";
            }
        }
        return answer;
    }

}
