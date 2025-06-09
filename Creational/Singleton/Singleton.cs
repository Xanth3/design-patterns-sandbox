namespace Design.Patterns.Sandbox.Creational.Singleton
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> lazy =
            new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance => lazy.Value;

        private Singleton() { }

        public string GetMessage() => "I am a Singleton instance.";
    }
}