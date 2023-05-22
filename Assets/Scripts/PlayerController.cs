using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public KeyCode upInput = KeyCode.UpArrow;
    public KeyCode downInput = KeyCode.DownArrow;
    public KeyCode leftInput = KeyCode.LeftArrow;
    public KeyCode rightInput = KeyCode.RightArrow;

    public GameObject frontFeeler = null;
    public GameObject backFeeler = null;
    public GameObject leftFeeler = null;
    public GameObject rightFeeler = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(upInput))
        {
            if (frontFeeler.GetComponent<Feeler>().isValid == true)
            {
                transform.Translate(Vector3.forward);
            }
        }
        if (Input.GetKeyDown(downInput))
        {
            if (backFeeler.GetComponent<Feeler>().isValid == true)
            {
                transform.Translate(Vector3.back);
            }
        }
        if (Input.GetKeyDown(leftInput))
        {
            if (leftFeeler.GetComponent<Feeler>().isValid == true)
            {
                transform.Translate(Vector3.left);
            }
        }
        if (Input.GetKeyDown(rightInput))
        {
            if (rightFeeler.GetComponent<Feeler>().isValid == true)
            {
                 transform.Translate(Vector3.right);
            }
        }
    }
}
