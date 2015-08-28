﻿using UnityEngine;
using System.Collections;

public class InputScript : MonoBehaviour
{
	public bool getInput = true;
	public bool getControllerInput = true;

	public KeyCode leftInput = KeyCode.A;
	public KeyCode rightInput = KeyCode.D;
	public KeyCode upInput = KeyCode.W;
	public KeyCode downInput = KeyCode.S;
	public KeyCode jumpInput = KeyCode.Space;
	public KeyCode dashInput = KeyCode.LeftShift;
	public KeyCode rollInput = KeyCode.LeftControl;
	public KeyCode fireInput = KeyCode.Mouse0;
	public KeyCode secondaryFireInput = KeyCode.Mouse1;
	public KeyCode reloadInput = KeyCode.R;

	public float leftJoystickX;
	public float leftJoystickY;
	public float rightJoystickX;
	public float rightJoystickY;

	public bool leftInputPressed;
	public bool rightInputPressed;
	public bool upInputPressed;
	public bool downInputPressed;
	public bool jumpInputPressed;
	public bool fireInputPressed;
	public bool secondaryFireInputPressed;
	public bool reloadInputPressed;

	public bool leftInputDown;
	public bool rightInputDown;
	public bool upInputDown;
	public bool downInputDown;
	public bool jumpInputDown;
	public bool fireInputDown;
	public bool secondaryFireInputDown;
	public bool reloadInputDown;

	public bool leftInputUp;
	public bool rightInputUp;
	public bool upInputUp;
	public bool downInputUp;
	public bool jumpInputUp;
	public bool fireInputUp;
	public bool secondaryFireInputUp;
	public bool reloadInputUp;

	// Update is called once per frame
	void Update ()
	{
		leftInputPressed = false;
		rightInputPressed = false;
		upInputPressed = false;
		downInputPressed = false;
		jumpInputPressed = false;
		fireInputPressed = false;
		secondaryFireInputPressed = false;
		reloadInputPressed = false;
		leftInputDown = false;
		rightInputDown = false;
		upInputDown = false;
		downInputDown = false;
		jumpInputDown = false;
		fireInputDown = false;
		secondaryFireInputDown = false;
		reloadInputDown = false;
		leftInputUp = false;
		rightInputUp = false;
		upInputUp = false;
		downInputUp = false;
		jumpInputUp = false;
		fireInputUp = false;
		secondaryFireInputUp = false;
		reloadInputUp = false;

		if (getInput)
		{
			//Left input section
			if (Input.GetKey(leftInput))
			{
				leftInputPressed = true;
			}
			if (Input.GetKeyDown(leftInput))
			{
				leftInputDown = true;
			}
			else if (Input.GetKeyUp(leftInput))
			{
				leftInputUp = true;
			}

			//Right input section
			if (Input.GetKey(rightInput))
			{
				rightInputPressed = true;
			}
			if (Input.GetKeyDown(rightInput))
			{
				rightInputDown = true;
			}
			else if (Input.GetKeyUp(leftInput))
			{
				rightInputUp = true;
			}

			//Up input section
			if (Input.GetKey(upInput))
			{
				upInputPressed = true;
			}
			if (Input.GetKeyDown(upInput))
			{
				upInputDown = true;
			}
			else if (Input.GetKeyUp(upInput))
			{
				upInputUp = true;
			}

			//Down input section
			if (Input.GetKey(downInput))
			{
				downInputPressed = true;
			}
			if (Input.GetKeyDown(downInput))
			{
				downInputDown = true;
			}
			else if (Input.GetKeyUp(downInput))
			{
				downInputUp = true;
			}

			//Jump input section
			if (Input.GetKey(jumpInput))
			{
				jumpInputPressed = true;
			}
			if (Input.GetKeyDown(jumpInput))
			{
				jumpInputDown = true;
			}
			else if (Input.GetKeyUp(jumpInput))
			{
				jumpInputUp = true;
			}

			//Fire input section
			if (Input.GetKey(fireInput))
			{
				fireInputPressed = true;
			}
			if (Input.GetKeyDown(fireInput))
			{
				fireInputDown = true;
			}
			else if (Input.GetKeyUp(fireInput))
			{
				fireInputUp = true;
			}

			//Secondary Fire input section
			if (Input.GetKey(secondaryFireInput))
			{
				secondaryFireInputPressed = true;
			}
			if (Input.GetKeyDown(secondaryFireInput))
			{
				secondaryFireInputDown = true;
			}
			else if (Input.GetKeyUp(secondaryFireInput))
			{
				secondaryFireInputUp = true;
			}

			//Reload Input section
			if (Input.GetKey(reloadInput))
			{
				reloadInputPressed = true;
			}
			if (Input.GetKeyDown(reloadInput))
			{
				reloadInputDown = true;
			}
			else if (Input.GetKeyUp(reloadInput))
			{
				reloadInputUp = true;
			}

			//Controller input section
			if (getControllerInput)
			{
				leftJoystickX = Input.GetAxis("Horizontal");
				leftJoystickY = Input.GetAxis("Vertical");

				if (Input.GetButton("Jump"))
				{
					jumpInputPressed = true;
				}
				if (Input.GetButtonDown("Jump"))
				{
					jumpInputDown = true;
				}
				if (Input.GetButtonUp("Jump"))
				{
					jumpInputUp = true;
				}
			}
		}
	}
}
