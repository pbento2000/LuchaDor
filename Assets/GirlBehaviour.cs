using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GirlBehaviour : MonoBehaviour {

    public SpriteRenderer spriteRenderer;
    public Sprite girlYes;
    public Sprite girlNo;
    public Sprite girlMad;
    public Transform bola;
    private Transform girl;
    public CharacterBehaviour characterBehaviour;
    private int giveJuice;
    private bool mad;
    private int madMeter;
    private Sprite currentState;

    // Start is called before the first frame update
    void Start()
    {
        currentState = girlNo;
        giveJuice = 0;
        madMeter = 50;
        girl = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(girl.position.x - bola.position.x);
        spriteRenderer.sprite = currentState;
        if (girl.position.x - bola.position.x < 1.0 && girl.position.x - bola.position.x > -1.0 && !mad)
        {
            currentState = girlYes;
            if(Input.GetButton("Gather")){
                giveJuice = (giveJuice + 1)%10;
                if(giveJuice == 0){
                    characterBehaviour.IncreaseComplimentJuice(1.0f);
                }
                madMeter += Random.Range(-1,2);
                if(madMeter == 0){
                    mad = true;
                    currentState = girlNo;
                }else if(madMeter == 100){
                    mad = true;
                    currentState = girlMad;
                    characterBehaviour.decreaseTier();
                }
            }
        }else if(!mad){
            currentState = girlNo;
        }
        Debug.Log(madMeter);
    }
}
