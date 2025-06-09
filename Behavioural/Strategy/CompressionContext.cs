namespace Design.Patterns.Sandbox.Behavioural.Strategy
{
    public class CompressionContext
    {
        private ICompressionStrategy _strategy;

        public CompressionContext(ICompressionStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(ICompressionStrategy strategy)
        {
            _strategy = strategy;
        }

        public string CompressData(string data)
        {
            return _strategy.Compress(data);
        }
    }
}
