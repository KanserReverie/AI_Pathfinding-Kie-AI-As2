using UnityEngine;
using UnityEngine.SceneManagement;

namespace KieranAI1
{
    public class UIElements : MonoBehaviour
    {
        public void QuitButton()
        {
            Time.timeScale = 1;

            Application.Quit();
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }

        public void PlayGame()
        {
            SceneManager.LoadScene(1);
        }
    }
}