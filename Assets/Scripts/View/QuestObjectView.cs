using UnityEngine;

namespace PlatformerMVC
{
    public class QuestObjectView : LevelObjectView
    {
        [SerializeField] public int ID;
        [SerializeField] private Color _completeColor;
        private Color _defaeultColor;

        void Awake()
        {
            _defaeultColor = _spriteRenderer.color;


        }

        public void Complete()
        {
            _spriteRenderer.color = _completeColor; 
        }

        public void Activate()
        {
            _spriteRenderer.color = _defaeultColor; 
        }

    }
}