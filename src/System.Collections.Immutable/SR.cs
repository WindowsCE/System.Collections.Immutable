﻿internal static partial class SR
{
    public const string Arg_KeyNotFoundWithKey = "The given key '{0}' was not present in the dictionary.";
    public const string ArrayInitializedStateNotEqual = "Object is not an array with the same initialization state as the array to compare it to.";
    public const string ArrayLengthsNotEqual = "Object is not an array with the same number of elements as the array to compare it to.";
    public const string CannotFindOldValue = "Cannot find the old value";
    public const string CapacityMustBeGreaterThanOrEqualToCount = "Capacity was less than the current Count of elements.";
    public const string CapacityMustEqualCountOnMove = "MoveToImmutable can only be performed when Count equals Capacity.";
    public const string CollectionModifiedDuringEnumeration = "Collection was modified; enumeration operation may not execute.";
    public const string DuplicateKey = "An element with the same key but a different value already exists. Key: {0}";
    public const string InvalidEmptyOperation = "This operation does not apply to an empty instance.";
    public const string InvalidOperationOnDefaultArray = "This operation cannot be performed on a default instance of ImmutableArray<T>.  Consider initializing the array, or checking the ImmutableArray<T>.IsDefault property.";

    public static string Format(string format, params object[] args)
    {
        return string.Format(format, args);
    }
}
