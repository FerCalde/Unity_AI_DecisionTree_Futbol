using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDistances : SingletonPersistent<CheckDistances>
{
    [SerializeField]Transform cornerIzq, cornerDer, penaltyPoint;
    GameObject enemy, playerCompany;

    public float distanceCornerIzq, distanceCornerDer, distancePenaltyPoint, distanceEnemy, distancePlayerCompany;
    public bool isAttacking = false;

    public float distanceEnemyNear = 3f;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        playerCompany= GameObject.FindGameObjectWithTag("Company");
    }
 
    void OnTriggerStay(Collider other) //Está en zona de Ataque
    {
        if (other.gameObject.name == "AttackZone")
        {
            isAttacking = true;
        }
    }
    void OnTriggerExit(Collider other) //Sale de la Zona de Ataque
    {
        if (other.gameObject.name == "AttackZone")
        {
            isAttacking = false;
        }
    }

    public void CheckDistancias()
    {
        //GameElementsDistance
        distanceEnemy = Vector3.Distance(this.transform.position, enemy.transform.position);
        distancePlayerCompany = Vector3.Distance(this.transform.position, playerCompany.transform.position);
       
        //HotZonesDistances
        distanceCornerDer = Vector3.Distance(this.transform.position, cornerDer.position);
        distanceCornerIzq = Vector3.Distance(this.transform.position, cornerIzq.position);
        distancePenaltyPoint= Vector3.Distance(this.transform.position, penaltyPoint.position);
    }
}
