/*
Keep track of the points scored in the game

Gilberto Echeverria
2023-03-01
*/

using UnityEngine;

public class Score : MonoBehaviour
{
    int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    public void AddPoints(int amount)
    {
        score += amount;
        Debug.Log("New score: " + score);
    }
}
