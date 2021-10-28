using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float bounce = 15f;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("Body"))
        {
            col.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
        }
    }

}
