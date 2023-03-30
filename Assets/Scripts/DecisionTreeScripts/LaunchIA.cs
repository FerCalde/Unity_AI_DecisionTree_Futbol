using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchIA : MonoBehaviour
{
    public DecisionNode tree;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            CheckDistances.Instance.CheckDistancias();  //Actualizo el Checker de Distancias 
            tree.Execute();                             //Ejecuta el Arbol
        }
    }
}
