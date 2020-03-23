using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiffedersSpawner : MonoBehaviour
{
    DefenderSet diffender;

    void Update()
    {
        getSquareClicked();
    }
    public void setSelectedDefender(DefenderSet selectedDefender)
    {
        diffender = selectedDefender;
    }

    private void attemptToPlaceDefenderAt(Vector2 gridPos)
    {
        StarsDisplay starDisplay = FindObjectOfType<StarsDisplay>();
        int defenderCost = diffender.cost;
        if (starDisplay.haveEnoughStars(defenderCost))
        {
            spawnDefender(gridPos);
            starDisplay.spendingStarts(defenderCost);
        }
    }

    void OnMouseDown()
    {
        attemptToPlaceDefenderAt(getSquareClicked());
    }
    private Vector2 getSquareClicked()
    {
        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 mouseClickedInWorld = Camera.main.ScreenToWorldPoint(mousePos);
        float xPos = Mathf.RoundToInt(mouseClickedInWorld.x);
        float yPos = Mathf.RoundToInt(mouseClickedInWorld.y);
        Vector2 snapPos = new Vector2(xPos, yPos);
        return snapPos;
    }

    private void spawnDefender(Vector2 pos)
    {
        DefenderSet defender = Instantiate(diffender, pos, Quaternion.identity) as DefenderSet;
    }
}
