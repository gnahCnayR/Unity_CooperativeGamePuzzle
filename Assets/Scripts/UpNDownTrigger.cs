using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpNDownTrigger : MonoBehaviour
{
    private Vector3 pos1 = new Vector3(-2.18f, -4, -11);
    private Vector3 pos2 = new Vector3(-2.18f, 4, -11);
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}
