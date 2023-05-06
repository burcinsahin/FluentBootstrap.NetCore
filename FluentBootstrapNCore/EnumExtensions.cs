using System;
using System.ComponentModel;
using System.Linq;

namespace FluentBootstrapNCore
{
    internal static class EnumExtensions
    {
        public static string GetDescription(this Enum @enum)
        {
            var fieldInfo = @enum.GetType().GetField(@enum.ToString());
            var description = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false).OfType<DescriptionAttribute>().FirstOrDefault();
            return description == null ? @enum.ToString() : description.Description;
        }
    }
}
