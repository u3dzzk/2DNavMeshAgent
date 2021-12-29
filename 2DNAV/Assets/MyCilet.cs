using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PolyNav;

public class MyCilet : MonoBehaviour
{
    public Camera main;
    public PolyNavAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            
            agent.SetDestination(main.ScreenToWorldPoint(Input.mousePosition));
            
        }
    }
}
