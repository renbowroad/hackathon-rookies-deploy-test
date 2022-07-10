using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    GameObject Cube2;//Cube2そのものが入る変数

    HitPoint script;//cube2_hpが入る変数
    public AudioClip sound1;
    AudioSource audioSource;

    public int x = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 0.1f;
        //  Cube2 = GameObject.Find("Cube2");//Cube2をオブジェクト名から取得して変数に格納
        // script = Cube2.GetComponent<HitPoint>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag != this.gameObject.tag)
        {
            x = 1;
            script = collision.gameObject.GetComponent<HitPoint>();
            script.HP -= 10;
            audioSource.PlayOneShot(sound1);
        }


        if (script.HP == 0)
        {
            if (collision.gameObject.tag == "Player1") 
                Debug.Log("P1_dead");

            if (collision.gameObject.tag == "Player2")
                Debug.Log("P2_dead");
        }
    }
}
