using System.CodeDom.Compiler;
using System.Text.Encodings.Web;
using System.Web;

namespace FakerNet
{
    partial class PersonGenerator
    {
        partial class AvatarGenerator
        {
            /// <summary>
            /// Produces a URL for an avatar from robohash.org.
            /// </summary>
            /// <param name="name">
            /// The name of the image, also used as a key to generate the image, so changing this changes the image. 
            /// Default value will select some Lorem text
            /// (default value "nil")
            /// </param>
            /// <param name="size">
            /// image size in pixels, in the format of ‘AxB’
            /// (default value "'48x48'")
            /// </param>
            /// <param name="format">
            /// The image file format ('png', 'jpg' or 'bmp')
            /// (default value "'jpg'")
            /// </param>
            /// <param name="type">
            /// The avatar set to use (Robot, Monster, RobotHead, Cat, Person)
            /// (default value "AvatarType.Person")
            /// </param>
            /// <param name="background">
            /// Include a background
            /// (default value "false")
            /// </param>
            /// <example>
            /// <code>Faker::Avatar.image => "https://robohash.org/sitsequiquia.png?size=300x300&set=set1"</code>
            /// </example>
            /// <example>
            /// <code>Faker::Avatar.image(slug: "my-own-slug")=> "https://robohash.org/my-own-slug.png?size=300x300&set=set1"</code>
            /// </example>
            /// <example>
            /// <code>Faker::Avatar.image(slug: "my-own-slug", size: "50x50") => "https://robohash.org/my-own-slug.png?size=50x50&set=set1"</code>
            /// </example>
            /// <example>
            /// <code>Faker::Avatar.image(slug: "my-own-slug", size: "50x50", format: "jpg")=> "https://robohash.org/my-own-slug.jpg?size=50x50&set=set1"</code>
            /// </example>
            /// <example>
            /// <code>Faker::Avatar.image(slug: "my-own-slug", size: "50x50", format: "bmp") => "https://robohash.org/my-own-slug.bmp?size=50x50&set=set1"</code>
            /// </example>
            /// <example>
            /// <code>Faker::Avatar.image(slug: "my-own-slug", size: "50x50", format: "bmp", set: "set1", bgset: "bg1") => "https://robohash.org/my-own-slug.bmp?size=50x50&set=set1&bgset=bg1"</code>
            /// </example>
            [FakerMethod("image")]
            public string Image(string? name = null, string size = "48x48", string format = "jpg", AvatarType type = AvatarType.Person, bool background = false)
            {
                //            name ??= Faker.Lorem.Words(3).Replace(" ", "");
                var sizeArg = $"/size_{size}";
                var setArg = $"/set_{UtilityMethods.GetEnumValue(type)}";
                var bgsetArg = background ? "/bgset_any" : "";
                return $"https://robohash.org{sizeArg}{setArg}{bgsetArg}/{HttpUtility.UrlEncode(name)}.{format}";
            }
        }
    }
}