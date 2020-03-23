using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarsDisplay : MonoBehaviour
    {
    [SerializeField] int starsCount = 100;
    Text starText;
    void Start()
    {
        starText = GetComponent<Text>();
        displatStarts();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void displatStarts()
    {
        starText.text = starsCount.ToString();

    }
    public bool haveEnoughStars(int amount)
    {
        return starsCount >= amount;
    }
    public void addingStarts(int cost)
    {
        this.starsCount += cost;
        displatStarts();
    }
    public void spendingStarts(int cost)
    {
        if (starsCount >= cost)
        {
            this.starsCount -= cost;
            displatStarts();
        }
    }
}
