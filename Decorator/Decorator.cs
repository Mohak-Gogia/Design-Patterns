namespace Decorator
{
    public abstract class Decorator : Component
    {
        protected Component _component { get; set; }

        protected Decorator(Component component)
        {
            _component = component;
        }

        public void SetComponent(Component component)
        {
            _component = component;
        }

        public override string Operation()
        {
            return _component?.Operation() ?? string.Empty;
        }
    }
}
