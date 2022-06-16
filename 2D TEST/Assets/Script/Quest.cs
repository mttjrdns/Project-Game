using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Quest
{
    public bool isActive;

    public string title;
    public int healthBonus;

    public QuestGoal goal;
    public QuestTimer timer;
    public void Complete()
	{
        timer.isActive = false;
        isActive = false;
        Debug.Log(title + " was completed");
	}
}
