using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class LevelStart : MonoBehaviour
{
	public UnityEvent OnEndEvent;

	public void OnTriggerEnter2D(Collider2D collision)
	{
		GameObject collisonGameObject = collision.gameObject;

		if (collisonGameObject.name == "Player")
		{
			OnEndEvent.Invoke();
		}
	}
}
