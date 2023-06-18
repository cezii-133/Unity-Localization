using System.Collections.Generic;
using UnityEngine;

public class LanguageManager : MonoBehaviour
{
    public static List<string> Words = new List<string>();
    private void Start()
    {
        string systemLanguage = GetSystemLanguage();
        string allText = GetAllText(systemLanguage);
        ParseAllText(allText);
    }
    private string GetSystemLanguage(){
        return Application.systemLanguage.ToString();
    }
    private string GetAllText(string systemLanguage){
        return Resources.Load($"Words/{systemLanguage}").ToString();
    }
    private void ParseAllText(string allText){
        List<string> words = new List<string>(allText.Split('\n'));
        foreach(string word in words){
            string [] text = word.Split(" : ");
            Words.Add(text[1]);
        }
        Debug.Log(Words[2]);
    }
}
