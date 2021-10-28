using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GirlBehaviour : MonoBehaviour {

    public SpriteRenderer spriteRenderer;
    public Sprite girlYes;
    public Sprite girlNo;
    public Transform bola;
    private Transform girl;


    // Start is called before the first frame update
    void Start()
    {
        girl = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(girl.position.x - bola.position.x);
        spriteRenderer.sprite = girlNo;
        if (girl.position.x - bola.position.x < 1.0 && girl.position.x - bola.position.x > -1.0)
        {
            spriteRenderer.sprite = girlYes;
        }
    }
}
