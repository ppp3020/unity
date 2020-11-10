using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //private
    public float speed = 5f;
    public Rigidbody Rigid;
    public Vector2 v1;
    public Vector2 v2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    gameObject.transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    gameObject.transform.position += new Vector3(-speed * Time.deltaTime, 0f, 0f);
        //}
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    gameObject.transform.position += new Vector3(0f, 0f, speed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    gameObject.transform.position += new Vector3(0f, 0f, -speed * Time.deltaTime);
        //}
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        Rigid.velocity = new Vector3(inputX * speed + Time.deltaTime, 0f, inputZ * speed + Time.deltaTime);

        //if (transform.position.x < v1.x)
        //{
        //    transform.position = new Vector3(v1.x, transform.position.y, transform.position.z);
        //}
        //if (transform.position.z > v1.y)
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y, v1.y);
        //}
        //if (transform.position.x > v2.x)
        //{
        //    transform.position = new Vector3(v2.x, transform.position.y, transform.position.z);
        //}                           
        //if (transform.position.z < v2.y)
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y, v2.y);
        //}

        float OrSizeZ = Camera.main.orthographicSize;
        float OrSizeX = Camera.main.orthographicSize * Screen.width / Screen.height;
        Vector3 playerobj = GetComponent<Collider>().bounds.extents;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -OrSizeX + playerobj.x, OrSizeX - playerobj.x), transform.position.y,
        Mathf.Clamp(transform.position.z, -OrSizeZ + playerobj.z, OrSizeZ - playerobj.z));
    }
}
