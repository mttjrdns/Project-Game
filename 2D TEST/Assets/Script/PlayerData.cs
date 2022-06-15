using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
	public int health;
	public int arrow;
	public int heartSize;
	public int numArrow;
	public float[] position;

	public PlayerData (Player player)
	{
		health = player.playerHealth;
		arrow = player.playerArrow;
		heartSize = player.numOfHearths;
		numArrow = player.arrowSize;

		//position = new float[3];
		//position[0] = player.transform.position.x;
		//position[1] = player.transform.position.y;
		//position[2] = player.transform.position.z;
	}
}
