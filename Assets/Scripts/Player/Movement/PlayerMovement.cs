using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private MovementSO movementSO;

	public float velocity = 0;
	public int rollDir = 0;

	private void Start()
	{
		velocity = movementSO.speed;
	}

	private void Update()
	{
		rollDir = 1;
		if (Input.GetKey(KeyCode.A))
			rollDir = 1;
		if (Input.GetKey(KeyCode.D))
			rollDir = -1;

		Rolling(rollDir);
		//Move();
	}

	private void Move()
	{
		Vector3 position = transform.position + transform.up * Time.deltaTime;
		position.z = 0;
		transform.position = position;
	}

	/// <summary>
	/// 동체 회전(=Roll)
	/// </summary>
	/// <param name="dir">dir은 -1 또는 1입니다. 1은 왼쪽, -1은 오른쪽으로 회전합니다.</param>
	private void Rolling(int dir)
	{
		rollDir = dir;
		if (dir == 0)
			rollDir = transform.localEulerAngles.y < 180 && transform.localEulerAngles.z < 90 ? -1 : 1;

		if (Mathf.Abs(transform.localEulerAngles.y) < 1f && dir == 0 && rollDir != 0)
			rollDir = 0;

		//transform.Rotate(Vector3.forward, 30 * Time.deltaTime);
		//transform.Rotate(transform.up, movementSO.rollingSpeed * rollDir * Time.deltaTime);

		Vector3 origin = transform.localEulerAngles;
		if 
		origin.y = 90;
		print(transform.localEulerAngles.y);
		//if (origin.y >= 90 && origin.y < 180)
		//	origin.y = 90;
		//if (origin.y > 180 && origin.y <= 270)
		//	origin.y = 270;
		transform.localEulerAngles = origin;
	}
}
