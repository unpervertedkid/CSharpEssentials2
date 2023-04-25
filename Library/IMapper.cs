namespace Generics;

public interface IMapper<S,T>
{
    T Map(S source);
}