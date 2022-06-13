using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While1 : MonoBehaviour
{
    public GameObject objectToClone;
    public int cloneAmount;
    public void CloneObject()
    {
        int contador = 0;
        while (contador < cloneAmount)
        {
            Instantiate(objectToClone);
            contador++;
        }
    }
}
