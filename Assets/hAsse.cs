using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hAsse : MonoBehaviour
{
    public int UserValue;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        uppgifthasse();
        Uppgifthasse1();
        uppgifthasse2();
    }


    void uppgifthasse()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            UserValue = UserValue += 2;
    }

    void Uppgifthasse1()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            UserValue = UserValue /= 2;
    }
    void uppgifthasse2()

    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            UserValue = UserValue * 2;
    }
}
  
                    
