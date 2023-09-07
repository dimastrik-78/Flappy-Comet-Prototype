using GenerationSystem;
using PlayerSystem;
using UISystem;
using UnityEngine;
using Zenject;

namespace Core
{
    public class GameInstaller : MonoInstaller
    {
        [Header("Game"), Space(5f)]
        [SerializeField] private int minDistanceSpawn;
        [SerializeField] private int maxDistanceSpawn;
        [SerializeField] private ScoreView scoreView;

        public override void InstallBindings()
        {
            Container.Bind<Game>()
                .AsSingle()
                .NonLazy();
            
            Container.Bind<Score>()
                .AsSingle()
                .WithArguments(scoreView)
                .NonLazy();
            
            Container.Bind<Generation>()
                .AsSingle()
                .WithArguments(minDistanceSpawn, maxDistanceSpawn)
                .NonLazy();

            // Container.Bind<Movement>()
            //     .AsSingle()
            //     .NonLazy();
        }
    }
}