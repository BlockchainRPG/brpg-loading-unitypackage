using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingAnimation : MonoBehaviour
{
    public static LoadingAnimation instance;

    public string scenePath = "Packages/io.blockchainrpg.loading/LoadingAnimation.unity";

    void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
            return;
        }

        DontDestroyOnLoad(this);
        instance = this;
    }

    public void StartLoading()
    {
        if (!SceneManager.GetSceneByPath(scenePath).isLoaded)
            SceneManager
                .LoadSceneAsync(scenePath, LoadSceneMode.Additive)
                .completed += operation =>
            {
            };
    }

    public void StopLoading()
    {
        var scene = SceneManager.GetSceneByPath(scenePath);
        if (scene.isLoaded)
        {
            SceneManager.UnloadSceneAsync(scene); // Use the scene object directly
        }
    }
}
