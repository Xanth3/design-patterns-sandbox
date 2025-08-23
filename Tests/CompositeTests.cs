using Design.Patterns.Sandbox.Structural.Composite;
using Xunit;

namespace Design.Patterns.Sandbox.Tests
{
    public class CompositeTests
    {
        [Fact]
        public void Composite_Tree_Produces_Correct_Operation()
        {
            IComponent root = new Composite("root");
            IComponent branch = new Composite("branch");
            IComponent leaf1 = new Leaf("leaf1");
            IComponent leaf2 = new Leaf("leaf2");

            branch.Add(leaf1);
            root.Add(branch);
            root.Add(leaf2);

            var expected = "Composite: root contains [Composite: branch contains [Leaf: leaf1], Leaf: leaf2]";
            Assert.Equal(expected, root.Operation());
        }

        [Fact]
        public void Leaf_Has_No_Children()
        {
            IComponent leaf = new Leaf("single");
            Assert.Empty(leaf.GetChildren());
        }
    }
}
