using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    public int hejsan;
    public int UserValue;

    public string sentence1;

    public string sentence2;

    public string sentence3;

    public int Number;

    // Use this for initialization
    void Start()
    {
        Uppgift1();
        Uppgift2();
        Uppgift3();


        Uppgift1();
    }

    void Update()
    {

    }
    void uppgifthasse()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            UserValue = UserValue * 2;
    }

    // Update is called once per frame


    void Uppgift1()
    {
        Debug.Log(string.Format("svaret på (963 * 421) - (175463 / 87) är {0}", (963 * 421) - (175463 / 87)));
    }

    void Uppgift2()
    {
        Sentence1();
        Sentence2();
        Sentence3();
    }

    void Uppgift3()
    {
        Debug.Log(string.Format("talet {0} upphöjt med 2 blir {1} och kvadratroten ur {0} blir {2}", Number, Mathf.Pow(Number, 2), Mathf.Sqrt(Number)));
    }




    void Sentence1()
    {
        Debug.Log(sentence1);
    }

    void Sentence2()
    {
        Debug.Log(sentence2);
    }

    void Sentence3()
    {
        Debug.Log(sentence3);
    }
}