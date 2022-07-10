using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_change2 : MonoBehaviour
{

	// Animator コンポーネント
	private Animator animator;

	// 設定したフラグの名前
	private const string key_isRun = "isRun";
	private const string key_isJump = "isJump";
	private const string key_isPunch = "isPunch";
	private const string key_isKick = "isKick";

	// 初期化メソッド
	void Start()
	{
		// 自分に設定されているAnimatorコンポーネントを習得する
		this.animator = GetComponent<Animator>();
	}

	// 1フレームに1回コールされる
	void Update()
	{

		// 矢印下ボタンを押下している
		if (Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.RightArrow))
		{
			// WaitからRunに遷移する
			this.animator.SetBool(key_isRun, true);
		}
		else
		{
			// RunからWaitに遷移する
			this.animator.SetBool(key_isRun, false);
		}

		// Wait or Run からJumpに切り替える処理
		// スペースキーを押下している
		if (Input.GetKey(KeyCode.UpArrow))
		{
			this.animator.SetBool(key_isRun, false);
			// Wait or RunからJumpに遷移する
			this.animator.SetBool(key_isJump, true);
		}
		else
		{
			// JumpからWait or Runに遷移する
			this.animator.SetBool(key_isJump, false);
		}

		////////////////////
		if (Input.GetKey(KeyCode.J))
		{
			this.animator.SetBool(key_isRun, false);
			// WaitからPunchに遷移する
			this.animator.SetBool(key_isPunch, true);
		}
		else
		{
			// PunchからWaitに遷移する
			this.animator.SetBool(key_isPunch, false);
		}

		// Wait or Run からKickに切り替える処理
		// スペースキーを押下している
		if (Input.GetKey(KeyCode.K))
		{
			this.animator.SetBool(key_isRun, false);

			this.animator.SetBool(key_isKick, true);
		}
		else
		{
			// KickからWait or Runに遷移する
			this.animator.SetBool(key_isKick, false);
		}
	}
}