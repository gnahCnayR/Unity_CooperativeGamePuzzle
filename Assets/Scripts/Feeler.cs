using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feeler : MonoBehaviour
{
    public bool isValid = false;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GridSpace")
        {
            isValid = true;
            gameObject.GetComponent<Renderer>().enabled = true;
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "GridSpace")
        {
            isValid = false;
            gameObject.GetComponent<Renderer>().enabled = false;
            gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
