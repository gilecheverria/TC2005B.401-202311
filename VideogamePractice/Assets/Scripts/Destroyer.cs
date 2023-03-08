/*
Destroy rigid body objects that collide with this object

Gilberto Echeverria
2023-03-07
*/

using UnityEngine;

public class Destroyer : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(col.gameObject);
    }
}