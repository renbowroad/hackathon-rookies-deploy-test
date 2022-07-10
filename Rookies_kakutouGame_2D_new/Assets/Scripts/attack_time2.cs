using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack_time2 : MonoBehaviour
{
    public Attack atc;
    public SphereCollider col;

    public int c = 0;

    // Start is called before the first frame update

    void Start()
    {
        atc.enabled = false;
        col.enabled = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.J)|| Input.GetKey(KeyCode.K))
        {
            atc.enabled = true;
            col.enabled = true;
        }
        else
        {
            atc.enabled = false;
            col.enabled = false;
        }
    }

} 
