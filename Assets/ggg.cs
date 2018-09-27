using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ggg : MonoBehaviour
{

    public bool itschecked;
    public int myintvalue = 10;
    // Use this for initialization
    void Start()
    {

        if (itschecked == true)
        {
            Debug.Log("its true.");
        }
        else
        {
            Debug.Log("kanske");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) == true)
        {
            print("reload");
        }
        if (Input.GetKeyDown(KeyCode.Q) == true)
        {
            Random.Range(0, 10);
            print("lean left");
        }

        if (myintvalue == 10)
        {
            //== lika med
            //!= inte lika med
            //|<= mindre än eller lika med
            //>= större än eller lika med
            //> större än
            //< mindre än
            // && och (and)
            // || eller (or) alt plus gr < )
        }
        else
        {
            print("okänd dag");
        }
    }
}