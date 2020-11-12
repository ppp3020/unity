using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //private
    public float speed = 5f;
    public Rigidbody Rigid;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        Rigid.velocity = new Vector3(inputX * speed + Time.deltaTime, 0f, inputZ * speed + Time.deltaTime);

        float OrSizeZ = Camera.main.orthographicSize;
        float OrSizeX = Camera.main.orthographicSize * Screen.width / Screen.height;
        Vector3 playerobj = GetComponent<Collider>().bounds.extents;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -OrSizeX + playerobj.x, OrSizeX - playerobj.x), transform.position.y,
        Mathf.Clamp(transform.position.z, -OrSizeZ + playerobj.z, OrSizeZ - playerobj.z));
    }
}
