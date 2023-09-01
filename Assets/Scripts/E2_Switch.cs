using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E2_Switch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int semana;
        semana = 1;
        switch (semana)
        {
            case 1:
                Debug.Log("Lunes");
                break;
            case 2:
                Debug.Log("Martes");
                break;
            case 3:
                Debug.Log("Miercoles");
                break;
            case 4:
                Debug.Log("Jueves");
                break;
            case 5:
                Debug.Log("Viernes");
                break;
            case 6:
                Debug.Log("Sabado");
                break;
            case 7:
                Debug.Log("Domingo");
                break;
        }
    }
    void Update()
    {
        
    }
}
