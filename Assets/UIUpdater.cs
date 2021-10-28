using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIUpdater : MonoBehaviour
{
    public CharacterBehaviour characterBehaviour;
    public Text complimentJuiceText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;
        complimentJuiceText.text = characterBehaviour.GetComplimentJuice().ToString();
    }
}
