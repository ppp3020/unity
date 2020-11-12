using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClone : MonoBehaviour
{
    public GameObject clone;
    public GameObject bulletFactory;
    public float fireTime = 1.0f;
    float curTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CreateClone();
        AutoFire();
    }

    private void CreateClone()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (clone.activeSelf)
            {
                clone.SetActive(false);
            }
            else
            {
                clone.SetActive(true);
            }
        }
    }

    private void AutoFire()
    {
        if (clone.activeSelf)
        {
            curTime += Time.deltaTime;

            if(curTime > fireTime)
            {
                curTime = 0.0f;

                GameObject[] bullet = new GameObject[clone.transform.childCount];

                for(int i = 0; i < clone.transform.childCount; i++)
                {
                    bullet[i] = Instantiate(bulletFactory);
                    bullet[i].transform.position = clone.transform.GetChild(i).position;
                }
            }
        }
    }
}
