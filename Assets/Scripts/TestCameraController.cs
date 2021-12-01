using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCameraController : MonoBehaviour
{
    public float speedH = 2f;
	public float speedV = 2f;

	private float yaw = 0f;
	private float pitch = 0f;
    void Update()
    {
		yaw += speedH * Input.GetAxis("Mouse X");

		pitch -= speedV * Input.GetAxis("Mouse Y");

		transform.eulerAngles = new Vector3(pitch, yaw, 0);
    }
}
