using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using Rookies.Inputs;

namespace Rookies.Players
{
    public class PlayerMover : MonoBehaviour
    {
        // RigidBody使う。
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private float _speed = 3;


        // [SerializeField]private Vector3 moveDirection;

        /// <summary>
        /// _move 移動ベクトル保管用のvector3
        /// </summary>
        private Vector3 _move;

        private bool _pushAttack;
        private int rorate_frag = 0;


        void Start()
        {
            // interfaceを取ってくる
            // interfaceを使う理由は キーボードだったりgamepad操作だったりしてもinterface返すと
            // 同じ関数で扱える-> 便利！！。
            var input = GetComponent<IInputProvider>();
            //input 情報をサブスクライブ
            input.MoveDirection.Subscribe(move => _move = move);


            //rigidbodyは fixedUpdateじゃないと 上手く動かないとのこと。
            //fixedUpdate は、1フレーム間のいろんな計算の中で、物理演算の前に呼ばれる処理なので、rigidbodyはここで呼ぶ。
            this.FixedUpdateAsObservable()
                .Subscribe(_ =>
                {
                    _rigidbody.MovePosition(transform.position + _move * _speed * Time.fixedDeltaTime);
                });


            // 向き切り替え。
            var rotate = new Vector3(0.0f, 90.0f, 0.0f);
            this.FixedUpdateAsObservable()
                .Subscribe(_ =>
                {
                    if (_move.x == 1.0)
                    {
                        _rigidbody.MoveRotation(Quaternion.AngleAxis(90.0f, rotate));
                    }
                    else if (_move.x == -1.0)
                    {
                        _rigidbody.MoveRotation(Quaternion.AngleAxis(-90.0f, rotate));
                    }
                });


        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
