namespace Core.GlobalStateMachine
{
    public abstract class AGameState
    {
        protected IStateMachine _owner;
        public void Setup(IStateMachine owner) => _owner = owner;
        public virtual void Enter() { }
        public virtual void Exit() { }
    }

}