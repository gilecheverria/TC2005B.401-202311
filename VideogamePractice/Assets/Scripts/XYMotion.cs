/*
Move a GameObject in 2D using the arrow keys or WASD

Gilberto Echeverria
2023-03-01
*/

using UnityEngine;

public class XYMotion : MonoBehaviour
{
    [SerializeField] float speed;

    Vector3 move;
    Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
    }

    void Move()
    {
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");

        // Apply the motion, scaled for the time between frames
        rb2D.velocity = move * speed;
    }

    void Rotate()
    {
        // Convert the mouse location into coordinates of the game world
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // Get a verctor in the direction the player should be pointing
        Vector2 direction = mousePos - transform.position;
        // Get the angle in degrees
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        // Apply the rotation to the object
        transform.localEulerAngles = new Vector3(0, 0, angle - 90);
    }
}