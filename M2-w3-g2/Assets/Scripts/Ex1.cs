using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = Random.Range(0, 50);
        int b= Random.Range(0, 50);
        int c;
        Debug.Log("A ="+a+" B= "+b);
        c = a;
        a = b;
        b = c;
        Debug.Log("A =" + a + " B= " + b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
