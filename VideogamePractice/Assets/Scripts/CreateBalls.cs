/*
Generate copies of a prefab, at random positions

Gilberto Echeverria
2023-03-01
*/

using UnityEngine;

public class CreateBalls : MonoBehaviour
{
    // Class variables to be changed from the Unity inteface
    // Reference to the object to copy
    [SerializeField] GameObject ball;
    // Time to wait between balls
    [SerializeField] float delay;
    // Horizontal limit (positive) where initial positions can be generated
    [SerializeField] float limit;

    // Start is called before the first frame update
    void Start()
    {
        // Call the 'DropBall' function after 0.5 seconds
        // and then keep calling it every set time
        InvokeRepeating("DropBall", 0.5f, delay);
    }

    void DropBall()
    {
        // Generate a new random position
        Vector3 pos = new Vector3(Random.Range(-limit, limit), 10, 0);
        // Create a copy of the prefab
        GameObject obj = Instantiate(ball, pos, Quaternion.identity);
        // Doom the object to die in 5 seconds
        //Destroy(obj, 5);
    }

    public void StopBalls()
    {
        // Stop calling the 'DropBall' function
        CancelInvoke("DropBall");
    }
}