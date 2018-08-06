namespace System.Collections.Generic
{
    // TODO: Move to NETStandard.WindowsCE library
    internal static class Comparer2<T>
    {
        public static Comparer<T> Create(Comparison<T> comparison)
        {
            if (comparison == null)
                throw new ArgumentNullException(nameof(comparison));

            return new ComparisonComparer<T>(comparison);
        }
    }

    internal sealed class ComparisonComparer<T> : Comparer<T>
    {
        private readonly Comparison<T> _comparison;

        public ComparisonComparer(Comparison<T> comparison)
        {
            _comparison = comparison;
        }

        public override int Compare(T x, T y)
        {
            return _comparison(x, y);
        }
    }
}
