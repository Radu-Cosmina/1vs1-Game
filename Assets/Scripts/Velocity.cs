using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;
    // Start is called before the first frame update
    [SerializeField]
    KeyCode keyPositive;
    [SerializeField]
    KeyCode keyNegative;
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(keyPositive))
            GetComponent<Rigidbody>().velocity += v3Force;
        if (Input.GetKey(keyNegative))
            GetComponent<Rigidbody>().velocity -= v3Force;

    }
}
