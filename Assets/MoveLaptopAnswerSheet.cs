using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLaptopAnswerSheet : MonoBehaviour
{
    static bool isLTSolved = false;
    static bool eventIsInitial = true;
    static bool set_lBooltrue()
    {
        isLTSolved = true;
        return isLTSolved;
    }
    public bool isFanAnsSolved_M()
    {
        return isLTSolved;
    }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (isLTSolved == true && eventIsInitial == true)
        {
            //Debug.Log("laptop solve true!");
            gameObject.GetComponent<Renderer>().enabled = !gameObject.GetComponent<Renderer>().enabled;
            eventIsInitial = false;
        }
    }
    public void setlaptopANStrue()
    {
        ///aaa;
        //Debug.Log("lt off");
        set_lBooltrue();//
    }
}
