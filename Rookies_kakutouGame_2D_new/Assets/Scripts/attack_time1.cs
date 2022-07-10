using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack_time1 : MonoBehaviour
{
    public Attack atc;
    public SphereCollider col;

    // Start is called before the first frame update

    void Start()
    {
        atc.enabled = false;
        col.enabled = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.F)|| Input.GetKey(KeyCode.G))
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
