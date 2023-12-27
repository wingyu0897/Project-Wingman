using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform target;

	private void Update()
	{
		transform.position = new Vector3(target.position.x, target.position.y, -10);
	}
}
