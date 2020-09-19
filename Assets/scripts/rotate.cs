using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
  
{
    Vector3 movments;
    // Start is called before the first frame update
    void Start()
    {
        movments = new Vector3(0,1,0);
    }

    // Update is called once per frame
    void Update()
    {
            transform.Rotate(movments);
    }
}
