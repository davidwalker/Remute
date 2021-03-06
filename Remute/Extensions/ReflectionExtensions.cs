using System;
using System.Linq;
using System.Reflection;

namespace Remutable.Extensions
{
    internal static class ReflectionExtensions
    {
        public static PropertyInfo[] GetInstanceProperties(Type type)
        {
            return type
                .GetTypeInfo()
                .GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty)
                .ToArray();
        }

        public static bool CompareInstanceProperties(PropertyInfo member1, PropertyInfo member2)
        {
            return member1.Module == member2.Module && member1.MetadataToken == member2.MetadataToken;
        }
    }
}