using System.Collections.Generic;

namespace Design.Patterns.Sandbox.Behavioural.TemplateMethod
{
    public abstract class AbstractProcess : IProcess
    {
        public string Run()
        {
            var steps = new List<string>();
            steps.Add(InitialStep());
            steps.Add(CoreStep());
            steps.Add(FinalStep());
            return string.Join(" -> ", steps);
        }

        protected virtual string InitialStep() => "Initial Step";
        protected abstract string CoreStep();
        protected virtual string FinalStep() => "Final Step";
    }
}
