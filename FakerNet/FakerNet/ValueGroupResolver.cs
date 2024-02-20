using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerNet
{
    public class ValueGroupResolver : IValueResolver
    {

        private List<YamlValueResolver> fakeValuesList = new List<YamlValueResolver>();

        public void add(YamlValueResolver fakeValues)
        {
            fakeValuesList.Add(fakeValues);
        }

        public Dictionary<object, object>? this[string key]
        {
            get
            {
                Dictionary<object, object>? result = null;
                foreach (YamlValueResolver fakeValues in fakeValuesList)
                {
                    if (fakeValues.SupportsPath(key))
                    {
                        if (result != null)
                        {
                            Dictionary<object, object>? newResult = fakeValues[key];
                            if (newResult != null) 
                                newResult.ToList().ForEach(x => result[x.Key] =x.Value);
                        }
                        else
                        {
                            result = fakeValues[key];
                        }
                    }
                }
                return result;
            }
        }
    }
}
