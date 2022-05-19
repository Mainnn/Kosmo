using UnityEngine;

namespace CrazyEight
{
	public class BorderVerticalPosition : MonoBehaviour
	{
		[SerializeField] private Camera _camera;

		[SerializeField] private bool _isUp;

        private void Start()
        {
            SetPosition();
        }

        private void SetPosition()
        {
            Vector2 safeAreaPotion = _isUp ? Screen.safeArea.max : Screen.safeArea.min;
            float positionY = _camera.ScreenToWorldPoint(safeAreaPotion).y;
            transform.position = new Vector2(transform.position.x, positionY);
        }
    }
}
