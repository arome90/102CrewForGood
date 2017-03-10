﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveGirl : MonoBehaviour {

	private Animator _animator;
	private Rigidbody2D _rigidbody2d;

	public float speed = 1f;

	// Use this for initialization
	void Start()
	{
		_animator = GetComponent<Animator>();
		_rigidbody2d = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		CheckDirection();
	}

	void CheckDirection()
	{
		if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetAxis("DPADX") == -1))
		{
			WalkAnimation(-1, true);

		}
		else if (Input.GetKey(KeyCode.RightArrow) || (Input.GetAxis("DPADX") == 1))
		{
			WalkAnimation(1, true);

		}
		/*else if (Input.GetKey(KeyCode.UpArrow) || (Input.GetAxis("DPADY") == -1))
		{
			WalkAnimation(0, 1, true);

		}
		else if (Input.GetKey(KeyCode.DownArrow) || (Input.GetAxis("DPADY") == 1))
		{
			WalkAnimation(0, -1, true);
		}*/
		else
		{
			_animator.SetBool("Moving", false);
		}
	}

	void FixedUpdate()
	{
		Move();

	}

	void Move()
	{
		float dirX = _animator.GetFloat("VelX");
		//float dirY = _animator.GetFloat("VelY");
		bool moving = _animator.GetBool("Moving");

		if (moving)
		{
			_rigidbody2d.velocity = new Vector2(dirX, 0) * speed;
		}
		else
		{
			_rigidbody2d.velocity = Vector2.zero;
		}

	}

	void WalkAnimation(float x,  bool moving)
	{
		_animator.SetFloat("VelX", x);
		//_animator.SetFloat("VelY", y);
		_animator.SetBool("Moving", moving);
	}

}