﻿using UnityEngine;
using System.Collections;

public class movePlayer : MonoBehaviour {
    private Animator _animator;
    private Rigidbody2D _rigidbody2d;
     private bool canMove = true;
    private SpriteRenderer spButtonA;
    public GameObject AButton;

    public float speed = 1f;

    // Use this for initialization
    void Start()
    {
        _animator = GetComponent<Animator>();
        _rigidbody2d = GetComponent<Rigidbody2D>();
        this.spButtonA = this.AButton.GetComponent<SpriteRenderer>();
        this.activeButtonA(false);
    }

    // Update is called once per frame
    void Update()
    {
         if (this.canMove) {
            CheckDirection();
         }
    }

    void CheckDirection()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetAxis("DPADX") == -1))
        {
            WalkAnimation(-1, 0, true);

        }
        else if (Input.GetKey(KeyCode.RightArrow) || (Input.GetAxis("DPADX") == 1))
        {
            WalkAnimation(1, 0, true);

        }
        else if (Input.GetKey(KeyCode.UpArrow) || (Input.GetAxis("DPADY") == -1))
        {
            WalkAnimation(0, 1, true);

        }
        else if (Input.GetKey(KeyCode.DownArrow) || (Input.GetAxis("DPADY") == 1))
        {
            WalkAnimation(0, -1, true);
        }
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
        float dirY = _animator.GetFloat("VelY");
        bool moving = _animator.GetBool("Moving");

        if (moving)
        {
            _rigidbody2d.velocity = new Vector2(dirX, dirY) * speed;
        }
        else
        {
            _rigidbody2d.velocity = Vector2.zero;
        }

    }

    void WalkAnimation(float x, float y, bool moving)
    {
        _animator.SetFloat("VelX", x);
        _animator.SetFloat("VelY", y);
        _animator.SetBool("Moving", moving);
    }

	/*void Update ()
	{
		if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetAxis("DPADX") == -1))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.RightArrow) || (Input.GetAxis("DPADX") == 1))
        {
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.UpArrow) || (Input.GetAxis("DPADY") == -1))
        {
			transform.position += Vector3.up * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DownArrow) || (Input.GetAxis("DPADY") == 1))
        {
			transform.position += Vector3.down * speed * Time.deltaTime;
		}
	}*/

    public void setCanMove(bool b)
    {
        this.canMove = b;
    }

    public bool getCanMove()
    {
        return this.canMove;
    }

    public void activeButtonA(bool b)
    {
        this.spButtonA.enabled = b;
    }
}