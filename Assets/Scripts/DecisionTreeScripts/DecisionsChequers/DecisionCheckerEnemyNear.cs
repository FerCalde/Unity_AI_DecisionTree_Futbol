using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionCheckerEnemyNear : DecisionNode
{
    //[SerializeField] float distanciaEnemyNear = 3f;
    public override void Execute() {

        if (CheckDistances.Instance.distanceEnemy <= CheckDistances.Instance.distanceEnemyNear)
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
