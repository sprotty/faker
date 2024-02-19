using System.Collections;
using System.Globalization;

namespace FakerNet.NUnit
{
    public class FakerNUnitBase
    {
        private Dictionary<CultureInfo, FakerNet.Faker> _fakerMap = new Dictionary<CultureInfo, Faker>();

        public void ForEveryLocale(Predicate<CultureInfo> fn)
        {
            foreach (var locale in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                fn(locale);
            }
        }
        public IEnumerable FakerForEveryLocale(Func<FakerNet.Faker, object> fn)
        {
            List<object> results = new List<object>();
            foreach (var locale in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                FakerNet.Faker faker = CreateFaker(locale);
                results.Add(fn(faker));
            }
            return results;
        }
        public IEnumerable<T> FakerForEveryLocale<T>(Func<FakerNet.Faker, T> fn)
        {
            List<T> results = new List<T>();
            foreach (var locale in RegionalCultureInfos)
            {
                FakerNet.Faker faker = CreateFaker(locale);
                for (int i = 0; i < 10; i++)
                    results.Add(fn(faker));
            }
            return results;
        }

        private FakerNet.Faker CreateFaker(CultureInfo locale)
        {
            if (_fakerMap.TryGetValue(locale, out Faker faker) == false)
            {
                faker = new Faker(locale, new Random(0));
                _fakerMap[locale] = faker;
            }
            return faker;
        }

        public IEnumerable<CultureInfo> RegionalCultureInfos => CultureInfo.GetCultures(CultureTypes.AllCultures)
                                                                    .Where(x => !x.Equals(CultureInfo.InvariantCulture)) //Remove the invariant culture as a region cannot be created from it.
                                                                    .Where(x => !x.IsNeutralCulture); //Remove nuetral cultures as a region cannot be created from them.


    }
}