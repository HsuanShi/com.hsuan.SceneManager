using UnityEngine;
using UnityEngine.SceneManagement;

namespace hsuan.SceneManager
{
    /// <summary>
    /// switch scene and exit game
    /// </summary>
    //switch scene and exit game
    public class SceneManager : MonoBehaviour
    {
        [SerializeField, Range(0,1.5f), Header("音效時間")]
        private float soundDuration = 1.5f;

        private string storeSceneName;
        /// <summary>
        /// Change Scene by Variable 'sceneName'
        /// </summary>
        /// <param name="sceneName">ChangeScene</param>
        public void ChangScene(string sceneName)
        {
            storeSceneName = sceneName;
            Invoke("DelayChangeScene", soundDuration);
        }
        private void DelayChangeScene()
        {
            print("切換場景");
            UnityEngine.SceneManagement.SceneManager.LoadScene(storeSceneName);
        }
        /// <summary>
        /// Quit Game
        /// </summary>
        public void Quit()
        {
            //print("離開遊戲");
            Invoke("DelayQuit",soundDuration);
        }
        public void DelayQuit()
        {
            print("QuitGame");
            Application.Quit();
        }
    }
}
