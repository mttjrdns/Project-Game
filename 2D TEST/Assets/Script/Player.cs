using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public int playerHealth;
    public int numOfHearths;
    
    public Image[] arrows;
    public Sprite arrow;
    public Sprite empty;
    public int arrowSize;
    public int playerArrow;
	//public GameObject deathEffect;

	private void Update()
    {
		//Hearts

		for (int i = 0; i < hearts.Length; i++)
		{
			if (playerHealth > numOfHearths)
			{
				playerHealth = numOfHearths;
			}
			if (i < playerHealth)
			{
				hearts[i].sprite = fullHeart;
			}
			else
			{
				hearts[i].sprite = emptyHeart;
			}

			if (i < numOfHearths)
			{
				hearts[i].enabled = true;
			}
			else
			{
				hearts[i].enabled = false;
			}
			//Debug.Log(playerHealth);
		}

		//Arrow
		for (int i = 0; i < arrows.Length; i++)
		{
			if (playerArrow > arrowSize)
			{
				playerArrow = arrowSize;
			}

			if (i < arrowSize)
			{
				arrows[i].sprite = arrow;
			}

			if (i < playerArrow)
			{
				arrows[i].sprite = arrow;
			}
			else
			{
				arrows[i].sprite = empty;
			}

			if (i < arrowSize)
			{
				arrows[i].enabled = true;
			}
			else
			{
				arrows[i].enabled = false;
			}
		}
	}

    public void AddHealth(int health)
    {
        if (playerHealth == numOfHearths)
        {
            if(playerHealth != 5) { 
                numOfHearths += health;
                playerHealth += health;
            }
            else
            {
                
                playerHealth = playerHealth;
            }
        }
        else
        {
            playerHealth += health;
        }
		//Debug.Log(playerHealth);
    }

	public void AddArrow(int arrow)
	{
		if (playerArrow == arrowSize)
		{
			if (playerArrow != 5)
			{
				arrowSize += arrow;
				playerArrow += arrow;
			}
			else
			{

				playerArrow = arrowSize;
			}
		}
		else
		{
			playerArrow += arrow;
		}
		Debug.Log(playerArrow);
	}

	public void TakeDamage(int damage)
    {
        playerHealth -= damage;
        Debug.Log(playerHealth);
        if (playerHealth == 0)
        {
            Die();
        }
    }

    void Die()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        //Debug.Log(gameObject);
        Destroy(gameObject);
    }

	public void SavePlayer()
	{
		SaveSystem.SavePlayer(this);
		//Debug.Log("Saved " + playerHealth);
	}

	public void LoadPlayer()
	{
		PlayerData data = SaveSystem.LoadPlayer();

		playerHealth = data.health;
		playerArrow = data.arrow;
		numOfHearths = data.heartSize;
		arrowSize = data.numArrow;

		//Vector3 position;
		//position.x = data.position[0];
		//position.y = data.position[1];
		//position.z = data.position[2];
		//transform.position = position;
		//Debug.Log("Loaded " + playerHealth);
	}
}
