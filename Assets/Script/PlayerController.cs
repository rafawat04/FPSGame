using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector = new Vector3();

        vector.x = Input.GetAxis("Horizontal");
        vector.z = Input.GetAxis("Vertical");
    }
}