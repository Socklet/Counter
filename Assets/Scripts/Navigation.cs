using UnityEngine.SceneManagement;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    public GameObject MenuToOpen;
    public GameObject MenuToClose;
    public string SceneToLoad;

   
    public void OnClick() 
    {
        OpenMenu();
        CloseMenu();
    }

    public void OnClickGameBtn()
    {
        OpenScene();
    }
    void OpenMenu()
    {
        MenuToOpen.SetActive(true);
    }

    void CloseMenu()
    {
        MenuToClose.SetActive(false);
    }

    void OpenScene()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
}
