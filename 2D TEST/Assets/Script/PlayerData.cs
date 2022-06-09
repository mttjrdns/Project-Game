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

	public PlayerData (Player player)
	{
		health = player.playerHealth;
		arrow = player.playerArrow;
		heartSize = player.numOfHearths;
		numArrow = player.arrowSize;
	}
}
