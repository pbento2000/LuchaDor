using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaMovelController : MonoBehaviour
{

    float dirX, speed = 3f;
    bool moveRight = true;
    bool moveUp = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name.Equals("PlataformaMovel"))
        {
            if (transform.position.x > 47.0f)
            {
                moveRight = false;
            }
            if (transform.position.x < 33.0f)
            {
                moveRight = true;
            }
            if (moveRight)
            {
                transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
            }
            else
            {
                transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
            }
        }
        if (gameObject.name.Equals("PlataformaMovel2"))
        {
            if (transform.position.y > 27.0f)
            {
                moveUp = false;
            }
            if (transform.position.y < 13.0f)
            {
                moveUp = true;
            }
            if (moveUp)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
            }
            else
            {
                transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
            }
        }
    }
}
