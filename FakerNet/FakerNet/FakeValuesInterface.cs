namespace FakerNet
{
    public interface FakeValuesInterface
    {
        Dictionary<object, object>? this[string key] { get; }
    }
}