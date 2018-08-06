namespace System
{
    internal static class TypeExtensions
    {
        // TODO: Move to NETStandard.WindowsCE library
        public static bool IsConstructedGenericType(this Type type)
        {
            return type.IsGenericType && !type.IsGenericTypeDefinition;
        }
    }
}
