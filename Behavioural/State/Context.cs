namespace Design.Patterns.Sandbox.Behavioural.State
{
    public class Context
    {
        private IState _state;

        public Context(IState initialState)
        {
            _state = initialState;
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public string Request()
        {
            return _state.Handle();
        }
    }
}
