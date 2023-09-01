using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1_If : MonoBehaviour
{
    void Start()
    {
        int a;
        a = 0;

        if (a > 0)
        {
            Debug.Log("Positivo");
        }

        else if (a < 0)
        {
            Debug.Log("Negativo");
        }

        else if (a == 0)
        {
            Debug.Log("Es cero");
        }

        else
        {
            Debug.Log("Valor desconocido");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
