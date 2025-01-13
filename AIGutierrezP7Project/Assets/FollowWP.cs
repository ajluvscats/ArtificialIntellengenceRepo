using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWP : MonoBehaviour
{
    public GameObject[] waypoints;
    int currentWP = 0;

    public float speed = 5.0f;
    public float rotSpeed = 1.0f;
    public float lookAhead = 2.0f;

    public GameObject wpManager;
    GameObject[] wps;
    GameObject currentNode;
    int currentWP = 0;
    Graph g;;
    
    // Start is called before the first frame update
    void Start()
    {
        wps = wpManager.GetComponent<wpManager>().waypoints;
        g = wpManager.GetComponent<wpManager>().graph;
        currentNode = wps[0];
    }
  
    public void GoToHeli()
    {
        g.AStar(currentNode, wps[0]);
        currentWP = 0;
    }

    pblic void GoToRuin()
    {
        g.AStar(currentNode, wps[1]):
            currentWP = 0;
    }
    // Update is called once per frame
    void Update()
    {
      
    }
}
