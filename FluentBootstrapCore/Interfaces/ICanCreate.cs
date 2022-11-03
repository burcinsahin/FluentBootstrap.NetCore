namespace FluentBootstrapCore
{
    // Implement this interface directly from a component to indicate it can create a different component
    public interface ICanCreate<in TComponent>
        where TComponent : Component
    {
    }

    // This is a dummy component used to allow BootstrapHelper to create anything
    public abstract class CanCreate : Component,
        ICanCreate<Component>
    {
        private CanCreate(BootstrapHelper helper)
            : base(helper)
        {
        }
    }
}
