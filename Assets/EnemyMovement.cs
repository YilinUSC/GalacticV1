using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 5.0f; // Adjust this to control the speed of movement
    public float maxY = 10.0f; // Adjust this to set the maximum Y position
    public float minY = -10.0f; // Adjust this to set the minimum Y position
    void Start()
    {
        
    }


    void Update()
    {
        // Move the object along the Y-axis
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        // If the object reaches the maximum Y position, reset it to the minimum Y position
        if (transform.position.y >= maxY)
        {
            transform.position = new Vector3(transform.position.x, minY, transform.position.z);
        }
    }
}
