/*
Use the sine function to make an object move back and forth

Gilberto Echeverria
2023-03-08
*/

using UnityEngine;

public class SineMotion : MonoBehaviour
{
    [SerializeField] float amplitude;
    [SerializeField] float speed;

    Vector3 initialPosition;
    Vector3 offset;
    float angle;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        angle += speed * Time.deltaTime;
        offset = new Vector3(Mathf.Sin(angle) * amplitude, 0, 0);
        transform.position = initialPosition + offset; 
    }
}
