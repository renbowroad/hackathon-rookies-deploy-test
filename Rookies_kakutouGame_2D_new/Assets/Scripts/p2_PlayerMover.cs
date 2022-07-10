using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class p2_PlayerMover : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speed = 3;
    [SerializeField] private Vector3 _move;

    private bool _pushAttack;
    private int rorate_frag = 0;
    private float quo = -90.0f;


    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        _move = Vector3.zero;

        var rotate = new Vector3(0.0f, 90.0f, 0.0f);
        //move
        if (Input.GetKey(KeyCode.UpArrow))  { _move.y += 1; }
        if (Input.GetKey(KeyCode.LeftArrow)) {_move.x -= 1; quo = -90.0f;  }
        if (Input.GetKey(KeyCode.DownArrow)) {_move.y -= 1; }
        if (Input.GetKey(KeyCode.RightArrow)) {_move.x += 1; quo = 90.0f; }

        _rigidbody.MovePosition(transform.position + _move * _speed * Time.fixedDeltaTime);
        _rigidbody.MoveRotation(Quaternion.AngleAxis(quo, rotate));

        // //向き

        //         if (_move.x == 1)
        //         {
        //             ;
        //         }
        //         else if (_move.x == -1)
        //         {
        //             _rigidbody.MoveRotation(Quaternion.AngleAxis(-90.0f, rotate));
        //         }
        //     });
    }


}