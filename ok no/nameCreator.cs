using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class nameCreator : MonoBehaviour
{
    public Button randomLetter;
    public Button nextLetter;
    public Button erase;
    public string randomString;
    List<string> lettersName = new List<string>();
    string[] alphabet = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", " " };
    public GameObject texto;
    public GameObject currentLetter;

    private void Start()
    {
        ListToText(lettersName);
        currentLetter.GetComponent<TMPro.TextMeshProUGUI>().text = "";
    }

    private void Update()
    {
        if (lettersName != null)
        {
            texto.GetComponent<TMPro.TextMeshProUGUI>().text = "";
            foreach (string item in lettersName)
                texto.GetComponent<TMPro.TextMeshProUGUI>().text += item.ToString() + "";

        }
        if (randomString != null)
        {
                currentLetter.GetComponent<TMPro.TextMeshProUGUI>().text = randomString.ToString();
        }
    }

    public void genRandomLetter()
    {
        randomString = alphabet[Random.Range(0, (alphabet.Length - 1))];
        Debug.Log(randomLetter);
        //lettersName.Add(randomString);
        //foreach (var x in lettersName)
        //{
        //    Debug.Log(x.ToString());
        //}
    }

    public void goNextLetter()
    {
        if (randomString != null)
        {
            lettersName.Add(randomString);
            foreach (var x in lettersName)
            {
                Debug.Log(x.ToString());
            }
        }
    }

    public void eraseAll()
    {
        if (lettersName != null)
        {
            lettersName.Clear();
        }
    }

    private string ListToText(List<string> lettersName)
    {
        string result = "";
        foreach (var listMember in lettersName)
        {
            result += listMember.ToString() + "\n";
        }
        return result;
    }
}
