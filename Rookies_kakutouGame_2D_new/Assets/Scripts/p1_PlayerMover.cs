using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class p1_PlayerMover  : MonoBehaviour
{
    // RigidBody使う。
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speed = 3;
    [SerializeField] private Vector3 _move;

    private bool _pushAttack;
    private int rorate_frag = 0;
    private float quo = 90.0f;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _move = Vector3.zero;

        var rotate = new Vector3(0.0f, 90.0f, 0.0f);


        // move
        if (Input.GetKey(KeyCode.W)) { _move.y += 1; }
        if (Input.GetKey(KeyCode.A)) {_move.x -= 1; quo = -90.0f;}
        if (Input.GetKey(KeyCode.S)) { _move.y -= 1; }
        if (Input.GetKey(KeyCode.D)) {_move.x += 1; quo = 90.0f; }

        _rigidbody.MovePosition(transform.position + _move * _speed * Time.fixedDeltaTime);
        _rigidbody.MoveRotation(Quaternion.AngleAxis(quo, rotate));
    }


}