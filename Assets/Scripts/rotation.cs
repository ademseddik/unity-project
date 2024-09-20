using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public Transform target;
    public float speed;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, target.transform.up,speed*Time.deltaTime) ;
      //  transform.RotateAround(target.transform.position, target.transform.forward, 2 * Time.deltaTime);
    }
}
