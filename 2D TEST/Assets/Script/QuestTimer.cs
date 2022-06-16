using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class QuestTimer : MonoBehaviour
{
	public bool isActive;

	public float startMinute = 5f;
	float currentTime = 0f;

	Player player;

	[SerializeField] Text countdownText;
    void Start()
	{
		currentTime = startMinute * 60;
	}

	void Update()
	{
		if (isActive)
		{
			currentTime = currentTime - Time.deltaTime;
			TimeSpan time = TimeSpan.FromSeconds(currentTime);
			countdownText.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();

			if (currentTime <= 0)
			{
				currentTime = 0;

			}

			player = Player.FindObjectOfType<Player>();
			//Debug.Log(player.playerHealth);

			if (player.playerHealth == 1)
			{
				currentTime = 0;
			}
		}
	}
}
