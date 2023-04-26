namespace Library;

public interface IMapper<S,T>
{
    T Map(S source);
}