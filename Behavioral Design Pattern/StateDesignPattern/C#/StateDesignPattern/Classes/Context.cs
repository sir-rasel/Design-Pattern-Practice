using System;

namespace StateDesignPattern.Classes
{
    class Context
    {
        private State _state = null;

        public Context(State state)
        {
            TransitionTo(state);
        }

        public void TransitionTo(State state)
        {
            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            _state = state;
            _state.SetContext(this);
        }

        public void Request1()
        {
            _state.Handle1();
        }

        public void Request2()
        {
            _state.Handle2();
        }
    }
}
