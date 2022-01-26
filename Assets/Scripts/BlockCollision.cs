using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Debug.Log(
            "Object ("
            + col.gameObject.name
            + ") collided with ("
            + this.gameObject.name
            + ")");

        if (col.gameObject.name.Contains("Block"))
        {
            if (col.gameObject.name.StartsWith("Blue") && this.gameObject.name.StartsWith("Blue"))
            {
                Debug.Log("Destroying " + col.gameObject.name);
                Destroy(col.gameObject);
            }
            if (col.gameObject.name.StartsWith("Red") && this.gameObject.name.StartsWith("Red"))
            {
                Debug.Log("Destroying " + col.gameObject.name);
                Destroy(col.gameObject);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
        //////// TEST CODE - CLICK ON A CYLINDER TO DELETE
        //////// https://docs.unity3d.com/ScriptReference/Debug.Log.html

        //// Process a mouse button click.
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            Debug.Log("MouseButtonDown detected!");

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Raycast hit (" + hit.collider.gameObject.name + ")!");

                if (hit.collider.gameObject.name.EndsWith("Cylinder"))
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
