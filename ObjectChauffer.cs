using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;

namespace ObjectChauffer
{
    public static class ObjectChauffeur
    {
        public static dynamic Create<T>()
        {
            var result = new ExpandoObject() as IDictionary<string, object>;

            var targetType = typeof(T);

            var targetInstance = Activator.CreateInstance<T>();

            PropertyInfo[] properties = targetType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var prop in properties)
            {
                Func<object, object> targetAction = (param) =>
                {
                    prop.SetValue(targetInstance, param, null);

                    return result;
                };

                result.Add(string.Concat("With", prop.Name), targetAction);
            }

            CreateBuildFunciton(result, targetInstance);

            return result;
        }

        private static void CreateBuildFunciton<T>(IDictionary<string, object> expando, T instance)
        {
            Func<T> buildFunc = () => instance;

            expando.Add("Build", buildFunc);
        }
    }
}