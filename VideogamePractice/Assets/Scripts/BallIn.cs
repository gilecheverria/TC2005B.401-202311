/*
Detect when the ball goes inside the net

Gilberto Echeverria
2023-03-01
*/

using UnityEngine;

public class BallIn : MonoBehaviour
{
    [SerializeField] Score scoreObj;

    // Detect two elements in contact
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Ball") {
            scoreObj.AddPoints(1); 
        }
    }
}