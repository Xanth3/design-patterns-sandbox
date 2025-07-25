namespace Design.Patterns.Sandbox.Creational.Builder
{
    public interface IBuilder
    {
        void Reset();
        void SetPartA(string value);
        void SetPartB(int value);
        Product GetProduct();
    }
}
