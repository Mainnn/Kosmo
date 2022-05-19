using UnityEngine;

namespace CrazyEight
{
	public class SaveSafeArea : MonoBehaviour
	{
		[SerializeField] private Camera _camera;

        private void Start()
        {
            SafeAreaData safeAreaData =new SafeAreaData();
            safeAreaData.SetMax(_camera.ScreenToWorldPoint(Screen.safeArea.max));
            safeAreaData.SetMin(_camera.ScreenToWorldPoint(Screen.safeArea.min));
        }
    }
}
