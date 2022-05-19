using UnityEngine;

namespace CrazyEight
{
	public class StartEveny : MonoBehaviour
	{
		[SerializeField] private GameEvent _startScene;
        [SerializeField] private GameEvent _gamplay;

        private void Start()
        {
            _startScene.Init();
            _gamplay.Init();
        }
    }
}
