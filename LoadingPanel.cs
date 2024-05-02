using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingPanel : MonoBehaviour
{
    public void OnClick()
    {
        LoadingAnimation.instance.StopLoading();
    }
}
