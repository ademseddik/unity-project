using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_earth : MonoBehaviour
{
    public float speed = 0.001f;
    public Transform t;
    public float radius = 5.0f; // Radius of the circular path

    private float angle = 0f; // Angle for circular movement
    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Transform>();
        t.position = new Vector3(t.position.x, t.position.y,t.position.z);
    }

  

    // Update is called once per frame
    void Update()
    {

        t.position = new Vector3(t.position.x, t.position.y, t.position.z+1);
    }
}
