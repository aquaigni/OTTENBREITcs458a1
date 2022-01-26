using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour
{

    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = transform.TransformDirection(0, 0, -20);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Time.deltaTime);
    }
}
