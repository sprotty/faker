//namespace FakerNet
//{
//    public class Binary : IEquatable<Binary>
//    {
//        public Binary() : this(new byte[0]) { }
//        public Binary(byte[] data) { Data = data; }
//        public static Binary FromHexString(string hex) => new Binary(Convert.FromHexString(hex));

//        public byte[] Data { get; }

//        public bool Equals(Binary? other)
//        {
//            return other != null && BinaryHelper.IsEqual(Data, other.Data);
//        }
//        public override bool Equals(object? obj)
//        {
//            return obj is Binary bin && this.Equals(bin);
//        }
//        public override int GetHashCode()
//        {
//            return Data.Sum(b => b);
//        }
//        public override string ToString()
//        {
//            return Convert.ToHexString(this.Data);
//        }
//    }
//}
