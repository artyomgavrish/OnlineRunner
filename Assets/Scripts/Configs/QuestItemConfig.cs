using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Configs / Create QuestItemConfig", fileName = "QuestItemConfig", order = 0)]
public class QuestItemConfig : ScriptableObject
{
    public int QuestID;
    public List<int> questItemColection;


}
