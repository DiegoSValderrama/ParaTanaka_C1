using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E5_Arreglo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] values = new int[6];
        values[0] = 12;
        values[1] = 123;
        values[2] = -125;
        values[3] = 132;
        values[4] = 122;
        values[5] = -1223;
        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] < 0)
            {
                Debug.Log(values[i]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
