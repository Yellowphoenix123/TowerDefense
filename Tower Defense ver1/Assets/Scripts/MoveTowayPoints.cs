using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowayPoints : MonoBehaviour
{
    public float Speed;
    public Transform[] waypoints;
    int curWaypointIndex = 0;
    public string gateTag = "gate1";
    public GameObject hp;
    public GameObject Controller;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Controller = GameObject.Find("Main Camera");

        if (curWaypointIndex < waypoints.Length)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[curWaypointIndex].position, Time.deltaTime * Speed);
            transform.LookAt(waypoints[curWaypointIndex].position);
            if (Vector3.Distance(transform.position, waypoints[curWaypointIndex].position) < 0.5f)
            {
                curWaypointIndex++;
            }
            if (GetComponent<HealthBar>().fill <= 0f)
            {
                Destroy(gameObject);
                Controller.GetComponent<GameController>().Gold += 10;
                Controller.GetComponent<GameController>().score += 10;

            }
        }
    }
}
