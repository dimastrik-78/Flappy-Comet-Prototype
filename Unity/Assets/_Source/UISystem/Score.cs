using Utils;
using Utils.Event;

namespace UISystem
{
    public class Score
    {
        private int _ammo;
        
        private readonly ScoreView _view;
        
        public Score(ScoreView view)
        {
            _view = view;
            
            SetEvent();
        }

        private void SetEvent()
        {
            Signals.Get<TakeBonusSignal>().AddListener(ScoreUpdate);
            Signals.Get<ResetSceneSignal>().AddListener(DeleteEvent);
        }

        private void DeleteEvent()
        {
            Signals.Get<TakeBonusSignal>().RemoveListener(ScoreUpdate);
            Signals.Get<ResetSceneSignal>().RemoveListener(DeleteEvent);
        }

        private void ScoreUpdate()
        {
            _ammo++;
            _view.ScoreUpdate(_ammo.ToString());
        }
    }
}