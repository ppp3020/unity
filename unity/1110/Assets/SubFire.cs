using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubFire : MonoBehaviour
{
    //private
    public GameObject SubLeftBullet;
    public GameObject SubRightBullet;
    public GameObject LeftPoint;
    public GameObject RightPoint;

    float count = 0;

    bool isFire = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 
        if(Input.GetKeyDown(KeyCode.Space))
        {
            isFire = !isFire;
        }

        if (isFire)
        {
            count += Time.deltaTime;

            if (count > 1)
            {
                GameObject LeftBullet = Instantiate(SubLeftBullet, LeftPoint.transform.position, Quaternion.identity);
                GameObject RightBullet = Instantiate(SubRightBullet, RightPoint.transform.position, Quaternion.identity);

                count = 0;
            }
        }
    }
}
