using GenerationSystem;
using UISystem;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Core
{
    public class Bootstrapper : IStartable
    {
        [Inject] private Game _game;
        [Inject] private Score _score;
        [Inject] private Generation _generation;

        public void Start()
        {
            _game.StartGame();
            _score.OnEvent();
            _generation.OnEvent();
            _generation.PlayerGeneration();
            _generation.BonusGeneration();
            _generation.ObstacleGeneration();
        }
    }
}
