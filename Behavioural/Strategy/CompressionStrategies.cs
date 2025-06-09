namespace Design.Patterns.Sandbox.Behavioural.Strategy
{
    public class ZipCompression : ICompressionStrategy
    {
        public string Compress(string data) => $"ZIP: {data}";
    }

    public class RarCompression : ICompressionStrategy
    {
        public string Compress(string data) => $"RAR: {data}";
    }
}
