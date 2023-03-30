using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionCheckerDisparo : DecisionNode
{
    public override void Execute()
    {

        if (CheckDistances.Instance.distancePenaltyPoint <= CheckDistances.Instance.distanceCornerIzq) //Compruebo más cerca Penalti que  CornerIzq
        {
            if (CheckDistances.Instance.distancePenaltyPoint <= CheckDistances.Instance.distanceCornerDer) //Compruebo más cerca Penalti que  CornerDer
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
