using UnityEngine;

namespace CrazyEight
{
	public class LevelNameData 
	{
		private const string Key = "SceneName";

		private void SetName(string name)
        {
			PlayerPrefs.SetString(Key, name);
			PlayerPrefs.Save();
        }

		public string GetName()
        {
            if (PlayerPrefs.HasKey(Key))
            {
				return PlayerPrefs.GetString(Key);
            }
			return null;
        }
	}
}
