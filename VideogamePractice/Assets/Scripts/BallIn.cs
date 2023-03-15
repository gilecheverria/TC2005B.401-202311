/*
Detect when the ball goes inside the net

Gilberto Echeverria
2023-03-01
*/

using UnityEngine;

public class BallIn : MonoBehaviour
{
    [SerializeField] Score scoreObj;

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Detect two elements in contact, one of them marked as trigger, one of them marked as trigger
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Ball") {
            scoreObj.AddPoints(1); 
            audioSource.Play();
        }
    }
}