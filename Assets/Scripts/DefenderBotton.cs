using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderBotton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        var bottons = FindObjectsOfType<DefenderBotton>();
        foreach(var botton in bottons)
        {
            botton.GetComponent<SpriteRenderer>().color = Color.gray;
        }
        GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
    }
}
