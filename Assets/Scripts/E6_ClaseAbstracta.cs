using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E6_ClaseAbstracta : MonoBehaviour
{
    C1 clase1;
    C2 clase2;
    void Start()
    {
        clase1 = new C1();
        clase2 = new C2();

        clase1.SeleccionarClase();
        clase2.SeleccionarClase();
    }
    void Update()
    {

    }

    public abstract class Clases
    {
        public abstract void SeleccionarClase(); 
    }

    public class C1 : Clases
    {
        public override void SeleccionarClase()
        {
            Debug.Log("Activa 1");
        }
    }
    public class C2 : Clases
    {
        public override void SeleccionarClase()
        {
            Debug.Log("Activa 2");
        }
    }

}
