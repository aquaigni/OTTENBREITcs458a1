using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject red_block;
    public GameObject blue_block;


    // Start is called before the first frame update
    void Start()
    {
        // Starting in 1 second, a projectile will be launched every 0.5 seconds
        InvokeRepeating("LaunchProjectile", 1.0f, 0.5f);
    }

    //// Update is called once per frame
    //void Update()
    //{

    //}

    void LaunchProjectile()
    {

        GameObject instance;


        Vector3 start = this.transform.position;
        Vector3 end = Camera.main.transform.position;

        //start += this.transform.forward.normalized * 10;

        Vector3 start_to_end = (end - start).normalized;


        if (Random.value > 0.5)
        {
            instance = Instantiate(blue_block); //, start, this.transform.rotation);
        }
        else
        {
            instance = Instantiate(red_block);
        }

        instance.transform.position = this.transform.position;

        //instance.GetComponent<Rigidbody>().AddForce(1, 0, 0);
        //var target: Vector3 = Camera.main.ScreenToWorldPoint(Vector3())

        //instance.GetComponent<Rigidbody>().velocity = start_to_end * 1.0f;

    }
}