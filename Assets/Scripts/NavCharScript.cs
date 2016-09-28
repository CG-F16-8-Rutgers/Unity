﻿using UnityEngine;
using System.Collections;

public class NavCharScript : MonoBehaviour
{

    NavMeshAgent agent;
    
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    agent = hit.collider.gameObject.GetComponent<NavMeshAgent>();
                    hit.collider.gameObject.GetComponent<Selected>().select = true; 
                }
                agent.SetDestination(hit.point);
            }
        }


    }
}
