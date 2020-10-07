using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision1 : MonoBehaviour
{
    Rigidbody rb;
    Vector3 fwd, bwd, lft, rgt, up, dwn;
    public float pushingforce;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        fwd = new Vector3(0f, 0f, 1f);
        bwd = new Vector3(0f, 0f, -1f);
        lft = new Vector3(-1f, 0f, 0f);
        rgt = new Vector3(1f, 0f, 0f);
        up = new Vector3(0f, 1f, 0f);
        dwn = new Vector3(0f, -1f, 0f);







    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
