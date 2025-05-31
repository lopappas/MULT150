using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Controller : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("lpappas_Final");
    }
}