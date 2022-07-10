using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch_Sound : MonoBehaviour
{
    public int c = 0;
    public AudioClip sound1;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //Component‚ðŽæ“¾
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag != this.gameObject.tag)
            c = 1;
            audioSource.PlayOneShot(sound1);
    }
}
