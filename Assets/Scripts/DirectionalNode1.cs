using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalNode1 : MonoBehaviour
{
    SpriteRenderer sr;
    public Sprite none;
    public Sprite left;
    public Sprite right;
    public string current;

    // Start is called before the first frame update
    void Start()
    {
        //get our sprite renderer
        sr = GetComponent<SpriteRenderer>();
        SwitchSprite();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SwitchSprite()
    {
        {
            if (current == "left")
            {
                Debug.Log("Choose Left");
                sr.sprite = left;
            }
            else if (current == "right")
            {
                Debug.Log("Choose Right");
                sr.sprite = right;
            }
            else
            {
                Debug.Log("Choose None");
                sr.sprite = none;
            }
        }
    }
}
