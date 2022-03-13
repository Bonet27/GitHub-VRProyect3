using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luces : MonoBehaviour
{
    public Light Light;

    private void Start()
    {
        Light.enabled = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if (!Light.enabled)
            {
                Light.enabled = true;
            }
            else
            {
                Light.enabled = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (!Light.enabled)
            {
                Light.enabled = true;
            }
            else
            {
                Light.enabled = false;
            }
        }
    }
}
