namespace Design.Patterns.Sandbox.Creational.Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public void Reset()
        {
            _product = new Product();
        }

        public void SetPartA(string value)
        {
            _product.PartA = value;
        }

        public void SetPartB(int value)
        {
            _product.PartB = value;
        }

        public Product GetProduct()
        {
            var result = _product;
            Reset();
            return result;
        }
    }
}
