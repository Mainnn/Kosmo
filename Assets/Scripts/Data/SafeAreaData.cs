using UnityEngine;

namespace CrazyEight
{
	public class SafeAreaData 
	{
		private const string KeyMaxX = "MaxX";
		private const string KeyMaxY = "MaxY";
		private const string KeyMinX = "MinX";
		private const string KeyMinY = "MinY";

		public void SetMax(Vector2 vector)
        {
            PlayerPrefs.SetFloat(KeyMaxX, vector.x);
			PlayerPrefs.SetFloat(KeyMaxY, vector.y);
			PlayerPrefs.Save();
		}

		public Vector2 GetMax()
        {
			Vector2 vector = Vector2.zero;
            if (PlayerPrefs.HasKey(KeyMaxX))
            {
				vector.x = PlayerPrefs.GetFloat(KeyMaxX);
            }
            if (PlayerPrefs.HasKey(KeyMaxY))
            {
				vector.y = PlayerPrefs.GetFloat(KeyMaxY);
            }
			return vector;
        }

		public void SetMin(Vector2 vector)
        {
			PlayerPrefs.SetFloat(KeyMinX, vector.x);
			PlayerPrefs.SetFloat(KeyMinY, vector.y);
			PlayerPrefs.Save();
        }

		public Vector2 GetMin()
        {
			Vector2 vector = Vector2.zero;
			if (PlayerPrefs.HasKey(KeyMinX))
			{
				vector.x = PlayerPrefs.GetFloat(KeyMinX);
			}
			if (PlayerPrefs.HasKey(KeyMinY))
			{
				vector.y = PlayerPrefs.GetFloat(KeyMinY);
			}
			return vector;
		}
    }
}
