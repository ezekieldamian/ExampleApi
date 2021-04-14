using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace Empr.CoreServicesApi.Utilities
{
    public static class Helper
    {
        public static string GetDescription(this Enum value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    var attr = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attr != null)
                    {
                        return attr.Description;
                    }
                }
            }
            return null;
        }

        public static List<string> GetAllDescriptions<T>(this Type type) where T : struct, IConvertible
        {
            if (!type.IsEnum)
            {
                throw new ArgumentException($"{type} must be an enum");
            }

            var descriptions = new List<string>();
            var names = Enum.GetNames(type);

            foreach (var name in names)
            {
                var field = type.GetField(name);
                var fds = field.GetCustomAttributes(typeof(DescriptionAttribute), true);
                foreach (DescriptionAttribute fd in fds)
                {
                    descriptions.Add(fd.Description);
                }
            }

            return descriptions;
        }
    }
}