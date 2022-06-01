using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosePile : MonoBehaviour
{
    [SerializeField] private GameObject one;
    [SerializeField] private GameObject two;
    [SerializeField] private GameObject three;
    [SerializeField] private GameObject four;
    [SerializeField] private GameObject five;
    [SerializeField] private GameObject six;


    // Start is called before the first frame update
    void Start()
    {
        GameObject stackbase = GameObject.FindWithTag("1");
        Vector3 base_pos = stackbase.transform.position;
        Vector3 spawn_pos = base_pos;
        spawn_pos.y += 20; 
        Instantiate(one, spawn_pos, stackbase.transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        // GetVal();
    }

}