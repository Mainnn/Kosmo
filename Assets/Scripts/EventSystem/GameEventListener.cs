using UnityEngine;
using UnityEngine.Events;

namespace CrazyEight
{
	public class GameEventListener : MonoBehaviour
    {
        [SerializeField] private GameEvent _gameEvent;
        [SerializeField] private UnityEvent Action;

        private void OnEnable()
        {
            _gameEvent.RigisterListerner(this);
        }
        private void OnDisable()
        {
            _gameEvent.UnregisterListener(this);
        }

        public void InitEvent()
        {
            Action.Invoke();
        }
    }
}
