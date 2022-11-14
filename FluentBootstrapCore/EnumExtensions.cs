using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace FluentBootstrapCore
{
    internal static class EnumExtensions
    {
        public static string GetDescription(this Enum @enum)
        {
            FieldInfo fieldInfo = @enum.GetType().GetField(@enum.ToString());
            DescriptionAttribute description = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false).OfType<DescriptionAttribute>().FirstOrDefault();
            return description == null ? @enum.ToString() : description.Description;
        }
    }
}
