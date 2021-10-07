using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Configs / Create QuestStoryConfig", fileName = "QuestStoryConfig", order = 0)]
public class QuestStoryConfig : ScriptableObject
{
    public QuestConfig[] quests;
    public QuestStoryType questStoryType;

}

public enum QuestStoryType
{
    common,
    Resettable
}