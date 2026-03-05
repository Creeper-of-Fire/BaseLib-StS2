using System;

namespace BaseMod2.Utils;

[AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
public sealed class PoolAttribute(Type poolType) : Attribute
{
    public Type PoolType { get; } = poolType;
}
