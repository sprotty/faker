namespace FakerNet
{
    public interface IValueResolver
    {
        /// <summary>
        /// returns a value map or null of the key can not be found
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Dictionary<object, object>? this[string key] { get; }
    }
}