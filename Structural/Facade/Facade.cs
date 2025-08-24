namespace Design.Patterns.Sandbox.Structural.Facade
{
    public class Facade
    {
        private readonly SubsystemA _subsystemA;
        private readonly SubsystemB _subsystemB;

        public Facade(SubsystemA subsystemA, SubsystemB subsystemB)
        {
            _subsystemA = subsystemA;
            _subsystemB = subsystemB;
        }

        public string Operation()
        {
            var resultA = _subsystemA.OperationA();
            var resultB = _subsystemB.OperationB();
            return $"Facade: {resultA} | {resultB}";
        }
    }
}
