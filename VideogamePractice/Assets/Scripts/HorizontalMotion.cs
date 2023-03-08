/*
Move a GameObject horizontally using the arrow keys or AD

Gilberto Echeverria
2023-03-01
*/

using UnityEngine;

public class HorizontalMotion : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float limit;

    Vector3 move;

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxis("Horizontal");
        //Debug.Log("X motion: " + move.x);

        // Limit the motion to a specific range of coordinates
        if (transform.position.x < -limit && move.x < 0) {
            move.x = 0;
        } else if (transform.position.x > limit && move.x > 0) {
            move.x = 0;
        } 

        // Apply the motion, scaled for the time between frames
        transform.Translate(move * speed * Time.deltaTime);
    }
}