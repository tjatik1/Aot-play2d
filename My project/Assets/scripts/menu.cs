using UnityEngine.SceneManagement;
using UnityEngine;


public class menu : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
