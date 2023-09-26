using Core.GlobalStateMachine;
using UnityEngine.SceneManagement;
using Utils;
using Utils.Event;

namespace Core
{
    public class Game
    {
        public void StartGame()
        {
            Signals.Get<ResetSceneSignal>().AddListener(ResetScene);
            Signals.Get<StartGameSignal>().Dispatch();
        }
        
        private void ResetScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
            Signals.Get<ResetSceneSignal>().RemoveListener(ResetScene);
        }
    }
}
