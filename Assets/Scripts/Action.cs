using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{   
    public float maximumSpeed;
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vert = Input.GetAxis("Horizontal");
        float horiz = -Input.GetAxis("Vertical");
        Vector3 movDir = new Vector3(horiz, 0, vert);
        Player.Translate(movDir*maximumSpeed*Time.deltaTime);
    }
}
