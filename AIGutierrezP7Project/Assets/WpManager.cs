using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public struct Link
{
    public enum direction { Uni,Bi }
    public GameObject nodel1;
    public GameObject nodel2;
    public direction dir;
}
public class WpManager : MonoBehaviour
{
    public GameObject[] waypoints;
    public Link[] links;
    public Graph graph = new Graph();

    // Start is called before the first frame update
    void Start()
    {
       if (waypoints.Length > 0)
        {
            foreach (GameObject wp in waypoints)
            {
                graph.AddNode(wp);
            }
            foreach (Link 1 in Links)
            {
                graph.AddEdge(wp);
            }
            foreach (Link l in links)
            {
                graph.AddEdge(l.node1, l.node2);
                if(l.dir == Link.direction.Bi)
                {
                    graph.AddEdge(l.nodel2, l.nodel1);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
