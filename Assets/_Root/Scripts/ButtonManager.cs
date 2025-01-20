using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Root.Scripts
{
    public class ButtonManager : MonoBehaviour
    {
        public void QuiteButton()
        {
            SceneManager.LoadScene("MainMenu");
        }

        public void BanglaPlayButton()
        {
            SceneManager.LoadScene("GamePlayBangla");
        }

        public void EnglishPlayButton()
        {
            SceneManager.LoadScene("GamePlayEnglish");
        }
        public void ExitButton()
        {
            Application.Quit();
        }
    }
}