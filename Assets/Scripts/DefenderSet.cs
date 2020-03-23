using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSet : MonoBehaviour
{
    [SerializeField] public int cost = 100;

    public int setStarCost()
    {
        return cost;
    }
}
