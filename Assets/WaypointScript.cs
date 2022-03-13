using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointScript : MonoBehaviour
{
    public BotAI ai;

    public int count = 0;

    public Collider col;

    private void Start()
    {
        col = this.GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        col = this.GetComponent<BoxCollider>();
        StartCoroutine(WaypointDisable());
        ai.count++;
        Debug.Log("La rata llegó al waypoint");
    }

    private void OnTriggerExit(Collider other)
    {
        ai.count++;
        Debug.Log("La rata esta en el waypoint");
    }

    private void OnTriggerStay(Collider other)
    {
        ai.count++;
        Debug.Log("La rata esta en el waypoint");
    }

    IEnumerator WaypointDisable()
    {
        col.enabled = false;
        yield return new WaitForSeconds(0.4f);
        col.enabled = true;
    }
}
