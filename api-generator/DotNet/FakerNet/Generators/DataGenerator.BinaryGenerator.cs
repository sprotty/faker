using System.CodeDom.Compiler;
using System.Security.Cryptography;
using System.Text;

namespace FakerNet
{
    partial class DataGenerator
    {
        partial class BinaryGenerator
        {

            /// <summary>
            /// Decodes base64 data, producing binary data
            /// </summary>
            /// <param name="base64Data">
            /// The base 64 data to decode
            /// </param>
            [FakerMethod("base64_decode")]
            public byte[] Base64Decode(string base64Data) => Convert.FromBase64String(base64Data);

            /// <summary>
            /// Encodes binary data as base64
            /// </summary>
            /// <param name="data">
            /// The data to encode
            /// </param>
            [FakerMethod("base64_encode")]
            public string Base64Encode(byte[] data) => Convert.ToBase64String(data);

            /// <summary>
            /// Gets some random binary data
            /// </summary>
            /// <param name="minLen">
            /// The minimum number of bytes to return
            /// (default value "4")
            /// </param>
            /// <param name="maxLen">
            /// The maximum number of bytes to return
            /// (default value "32")
            /// </param>
            [FakerMethod("binary")]
            public byte[] Binary(long minLen = 4, long maxLen = 32) => Random.NextBytes(Random.NextInt32((int)minLen, (int)maxLen));

            /// <summary>
            /// Decodes hex data, producing binary data
            /// </summary>
            /// <param name="hexData">
            /// The hex data to decode
            /// </param>
            [FakerMethod("hex_decode")]
            public byte[] HexDecode(string hexData) => Convert.FromHexString(hexData);

            /// <summary>
            /// Encodes binary data as hex
            /// </summary>
            /// <param name="data">
            /// The data to encode
            /// </param>
            [FakerMethod("hex_encode")]
            public string HexEncode(byte[] data) => Convert.ToHexString(data);

            /// <summary>
            /// Produces an MD5 hash.
            /// </summary>
            /// <param name="data">
            /// Binary data
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Crypto.md5 #=> "6b5ed240042e8a65c55ddb826c3408e6"</code>
            /// </example>
            [FakerMethod("md5")]
            public byte[] Md5(byte[]? data = null)
            {
                data ??= Random.NextBytes(10);
                return MD5.HashData(data);
            }


            /// <summary>
            /// Produces an MD5 hash of a string.
            /// </summary>
            /// <param name="data">
            /// Binary data
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Crypto.md5 #=> "6b5ed240042e8a65c55ddb826c3408e6"</code>
            /// </example>
            [FakerMethod("md5_string")]
            public byte[] Md5String(string? data = null, Encoding? encoding = null)
            {
                data ??= Faker.Data.Alphanumeric.AlphaNumeric(10);
                encoding ??= Encoding.UTF8;
                return Md5(encoding.GetBytes(data));
            }

            /// <summary>
            /// Produces a SHA1 hash.
            /// </summary>
            /// <param name="data">
            /// The binary data tohash
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Crypto.sha1 #=> "4e99e31c51eef8b2d290e709f757f92e558a503f"</code>
            /// </example>
            [FakerMethod("sha1")]
            public byte[] Sha1(byte[]? data = null)
            {
                data ??= Random.NextBytes(10);
                using (var sha1 = SHA1.Create())
                {
                    return sha1.ComputeHash(data);
                }
            }

            /// <summary>
            /// Produces a SHA1 hash of a string.
            /// </summary>
            /// <param name="data">
            /// The binary data tohash
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Crypto.sha1 #=> "4e99e31c51eef8b2d290e709f757f92e558a503f"</code>
            /// </example>
            [FakerMethod("sha1_string")]
            public byte[] Sha1String(string? data = null, Encoding? encoding = null)
            {
                data ??= Faker.Data.Alphanumeric.AlphaNumeric(10);
                encoding ??= Encoding.UTF8;
                return Sha1(encoding.GetBytes(data));
            }

            /// <summary>
            /// Produces a SHA256 hash.
            /// </summary>
            /// <param name="data">
            /// The binary data to hash
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Crypto.sha256 #=> "51e4dbb424cd9db1ec5fb989514f2a35652ececef33f21c8dd1fd61bb8e3929d"</code>
            /// </example>
            [FakerMethod("sha256")]
            public byte[] Sha256(byte[]? data = null)
            {
                data ??= Random.NextBytes(10);
                using (var sha256 = SHA256.Create())
                {
                    return sha256.ComputeHash(data);
                }
            }

            /// <summary>
            /// Produces a SHA256 hash of a string.
            /// </summary>
            /// <param name="data">
            /// The binary data to hash
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Crypto.sha256 #=> "51e4dbb424cd9db1ec5fb989514f2a35652ececef33f21c8dd1fd61bb8e3929d"</code>
            /// </example>
            [FakerMethod("sha256_string")]
            public byte[] Sha256String(string? data = null, Encoding? encoding = null)
            {
                data ??= Faker.Data.Alphanumeric.AlphaNumeric(10);
                encoding ??= Encoding.UTF8;
                return Sha256(encoding.GetBytes(data));
            }

            /// <summary>
            /// Produces a SHA512 hash.
            /// </summary>
            /// <param name="data">
            /// The binary data to hash
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Crypto.sha512 #=> "7b9fc82a6642874833d01b74a7b4fae3d15373193b55cfba47327f8f0afdc8d0ea155b58639a03a887009ef997dab8dd8d36767620d430f6e787e5996e26da80"</code>
            /// </example>
            [FakerMethod("sha512")]
            public byte[] Sha512(byte[]? data = null)
            {
                data ??= Random.NextBytes(10);
                using (var sha512 = SHA512.Create())
                {
                    return sha512.ComputeHash(data);
                }
            }

            /// <summary>
            /// Produces a SHA512 hash of a string.
            /// </summary>
            /// <param name="data">
            /// The binary data to hash
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Crypto.sha512 #=> "7b9fc82a6642874833d01b74a7b4fae3d15373193b55cfba47327f8f0afdc8d0ea155b58639a03a887009ef997dab8dd8d36767620d430f6e787e5996e26da80"</code>
            /// </example>
            [FakerMethod("sha512_string")]
            public byte[] Sha512String(string? data = null, Encoding? encoding = null)
            {
                data ??= Faker.Data.Alphanumeric.AlphaNumeric(10);
                encoding ??= Encoding.UTF8;
                return Sha512(encoding.GetBytes(data));
            }
        }

    }
}
