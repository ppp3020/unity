using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5.0f;
    public Vector2 Margin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, v, 0);

        transform.Translate(dir * speed * Time.deltaTime);

        //MoveInScreen();
    }

    void MoveInScreen()
    {
        Vector3 position = Camera.main.WorldToViewportPoint(transform.position);
        position.x = Mathf.Clamp(position.x, 0.0F + Margin.x, 1.0F - Margin.x);
        position.y = Mathf.Clamp(position.y, 0.0F + Margin.y, 1.0F - Margin.y);
        transform.position = Camera.main.ViewportToScreenPoint(position);
    }
}
