using UnityEngine;

namespace PlatformerMVC
{
    public class KiwiQuestModel : IQuestModel
    {

        public const string TargetTag = "Player";

        public bool TryComplete (GameObject player)
        {
            return player.CompareTag(TargetTag);
        }


    }
}