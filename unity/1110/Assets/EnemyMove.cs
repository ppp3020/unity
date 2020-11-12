using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    //private
    public GameObject EnemyObject;
    public GameObject EnemyPoint;

    float count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;

        if (count > 1)
        {
            GameObject Enemy = Instantiate(EnemyObject, EnemyPoint.transform.position, Quaternion.identity);

            count = 0;
        }
    }
}
