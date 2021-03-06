using System;

namespace NES.Contracts
{
    public interface IEventFactory
    {
        T Create<T>(Action<T> action);
        object Create(Type type);
    }
}