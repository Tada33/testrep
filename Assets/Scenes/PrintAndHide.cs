using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
  

    public int i = 4;

    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Red";
        gameObject.tag = "Blue";
    }

    // Update is called once per frame
    void Update()
    {

        if (i > 1)
        {
            Debug.Log(gameObject.name + " : " + i);
            i++;
        }

    }
}