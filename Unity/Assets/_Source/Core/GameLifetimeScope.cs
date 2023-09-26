using GenerationSystem;
using UISystem;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Core
{
    public class GameLifetimeScope : LifetimeScope
    {
        [Header("Game"), Space(5f)]
        [SerializeField] private ScoreView scoreView;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterComponent(scoreView);
            builder.Register<Game>(Lifetime.Singleton);
            builder.Register<Score>(Lifetime.Singleton);
            builder.Register<Generation>(Lifetime.Singleton);
            builder.RegisterEntryPoint<Bootstrapper>();
        }
    }
}