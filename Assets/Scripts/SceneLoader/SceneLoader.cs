using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CrazyEight
{
	public class SceneLoader : MonoBehaviour
	{
		[SerializeField] private string _sceneNameSaved;

        private readonly LevelNameData _levelName = new LevelNameData();

        private void Start()
        {
            if (!string.IsNullOrEmpty(_sceneNameSaved))
            {
                StartCoroutine((IEnumerator)AddScene(_sceneNameSaved));
            }
        }

        public void Load()
        {
            if (!string.IsNullOrEmpty(_levelName.GetName()))
            {
                StartCoroutine((IEnumerator)ScenesContoller(_levelName.GetName()));
            }
        }

        private IEnumerable ScenesContoller(string sceneName)
        {
            if (!string.IsNullOrEmpty(_sceneNameSaved))
            {
                yield return StartCoroutine(nameof(RemoveOldScene));
                yield return StartCoroutine(nameof(UnLoadResources));
            }
            yield return StartCoroutine(AddScene(name));
        }


		private IEnumerator AddScene(string name)
        {
			AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(name, LoadSceneMode.Additive);
            while (!asyncOperation.isDone)
            {
                yield return null;
            }

            _sceneNameSaved = name;
            SceneManager.SetActiveScene(SceneManager.GetSceneByName(name));
        }

        private IEnumerable RemoveOldScene()
        {
            AsyncOperation asyncOperation = SceneManager.UnloadSceneAsync(_sceneNameSaved);
            while (!asyncOperation.isDone)
            {
                yield return null;
            }
        }

        private IEnumerable UnLoadResources()
        {
            AsyncOperation asyncOperation = Resources.UnloadUnusedAssets();
            while (!asyncOperation.isDone)
            {
                yield return null;
            }
        }
	}
}
