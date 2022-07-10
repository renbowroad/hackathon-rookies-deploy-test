using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dead_area : MonoBehaviour
{ 
    HitPoint script;//cube2_hp‚ª“ü‚é•Ï”

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        script = collision.gameObject.GetComponent<HitPoint>();
        script.HP -= 100;

        if (script.HP <= 0)
        {
            if (collision.gameObject.tag == "Player1")
                Debug.Log("P1_dead");

            if (collision.gameObject.tag == "Player2")
                Debug.Log("P2_dead");
        }
    }
}
