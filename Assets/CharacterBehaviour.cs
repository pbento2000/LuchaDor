using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehaviour : MonoBehaviour
{

    public float complimentJuice;

    // Start is called before the first frame update
    void Start()
    {
        complimentJuice = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void IncreaseComplimentJuice(float multiplier){
        if(complimentJuice < 1000.0f){
            complimentJuice += 1.0f * multiplier;
        }
    }

    public void decreaseTier(){
        if(complimentJuice < 333.3f){
            complimentJuice = 0f;
        }else if(complimentJuice < 666.6f){
            complimentJuice = 333.3f;
        }else{
            complimentJuice = 666.6f;
        }
    }

    public float GetComplimentJuice(){
        return complimentJuice;
    }
}
