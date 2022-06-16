using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestGiver : MonoBehaviour
{
    public Quest quest;
    public Player player;

    public Text titleText;
    public Text healthBonusText;
    public void Start()
	{
        titleText.text = quest.title;
        healthBonusText.text = quest.healthBonus.ToString();
        quest.isActive = true;
        player.quest = quest;
        quest.timer.isActive = true;
	}
}
