using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderBotton : MonoBehaviour
{

    [SerializeField] DefenderSet defenderPref;
    void OnMouseDown()
    {
        var bottons = FindObjectsOfType<DefenderBotton>();
        foreach(var botton in bottons)
        {
            botton.GetComponent<SpriteRenderer>().color = Color.gray;
        }
        GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
        FindObjectOfType<DiffedersSpawner>().setSelectedDefender(defenderPref);
    }
}
