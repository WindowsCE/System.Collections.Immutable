using System.Collections;

namespace System
{
    // TODO: Move to NETStandard.WindowsCE library
    internal static class ArrayStructuralEquatable
    {
        public static IStructuralComparable AsStructuralComparable(this Array array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            return new StructuralArray(array);
        }

        public static IStructuralEquatable AsStructuralEquatable(this Array array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            return new StructuralArray(array);
        }
    }
}
