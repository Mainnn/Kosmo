using UnityEngine;

namespace CrazyEight
{
	public class CameraWidth : MonoBehaviour
	{
		private const float Width = 1080f;
		private const float HalfSizeInPixels = 200f;

        private void Awake()
        {
            GetComponent<Camera>().orthographicSize = Width * Screen.height / Screen.width / HalfSizeInPixels;
        }
    }
}
