using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E4_While : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int n;
        int count;
        n = 233;
        count = 0;
        while (n >= 1)
        {
            count = count + 1;
            n = n / 10;
        }
        Debug.Log(count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
