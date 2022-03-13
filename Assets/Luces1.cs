using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luces1 : MonoBehaviour
{
    public Light Light;
    public Light Light1;

    private void Start()
    {
        Light.enabled = false;
        Light1.enabled = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!Light.enabled)
            {
                Light.enabled = true;
                Light1.enabled = true;
            }
            else
            {
                Light.enabled = false;
                Light1.enabled = false;
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
                Light1.enabled = true;
            }
            else
            {
                Light.enabled = false;
                Light1.enabled = false;
            }
        }
    }
}
