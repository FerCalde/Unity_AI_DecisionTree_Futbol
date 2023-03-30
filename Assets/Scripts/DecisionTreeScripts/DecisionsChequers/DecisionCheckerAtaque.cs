using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionCheckerAtaque : DecisionNode
{
    public override void Execute()
    {
        //CheckDistances.Instance.CheckDistancias(); //Actualizo el Checker de distancias

        if (CheckDistances.Instance.isAttacking) //Comprueba el bool de isAttacking (si está en zona de Ataque)
        {
            m_isTrue = true;
        }
        else
        {
            m_isTrue = false;
        }

        if (m_isTrue)
            m_true.Execute();
        else
            m_false.Execute();
    }
}
