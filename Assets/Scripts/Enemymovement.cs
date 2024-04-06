using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]List<Waypoint> Waypoints;
    void Start()
    {
        foreach(Waypoint cube in Waypoints)
        {
            Debug.Log(cube.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
