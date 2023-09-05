using Utils;
using Utils.Event;

namespace UISystem
{
    public class ScoreController
    {
        private int _score;
        
        private readonly ScoreView _view;
        
        public ScoreController(ScoreView view)
        {
            _view = view;
            
            SetEvent();
        }

        private void SetEvent()
        {
            Signals.Get<TakeBonusSignal>().AddListener(ScoreUpdate);
        }

        private void DeleteEvent()
        {
            Signals.Get<TakeBonusSignal>().RemoveListener(ScoreUpdate);
        }

        private void ScoreUpdate()
        {
            _score++;
            _view.ScoreUpdate(_score.ToString());
        }
    }
}