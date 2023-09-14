using Utils;
using Utils.Event;
using VContainer;

namespace UISystem
{
    public class Score
    {
        private int _ammo;
        
        [Inject] private readonly ScoreView _view;
        
        // [Inject]
        // public Score(ScoreView view)
        // {
        //     _view = view;
        // }

        public void OnEvent()
        {
            Signals.Get<TakeBonusSignal>().AddListener(ScoreUpdate);
            Signals.Get<ResetSceneSignal>().AddListener(DisEvent);
        }

        private void DisEvent()
        {
            Signals.Get<TakeBonusSignal>().RemoveListener(ScoreUpdate);
            Signals.Get<ResetSceneSignal>().RemoveListener(DisEvent);
        }

        private void ScoreUpdate()
        {
            _ammo++;
            _view.ScoreUpdate(_ammo.ToString());
        }
    }
}