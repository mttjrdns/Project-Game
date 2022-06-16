using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestGoal
{
    public GoalType goalType;

    public int requiredArrow;
    public int currentArrow;

    public bool isReached()
	{
        return (currentArrow >= requiredArrow);
	}

    public void ArrowCollected()
	{
        if(goalType == GoalType.Arrow)
            currentArrow++;
	}
}

public enum GoalType
{
    Arrow
}