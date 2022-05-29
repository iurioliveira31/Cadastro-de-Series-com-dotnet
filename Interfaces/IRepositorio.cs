namespace Dio.Series.Interfaces
{
    public interface IRepositorio<T>
    {
         void Lista();
         void RetornoPorId();
         void Insere();
         void Excluir();
         void Atualizar();
         int ProximoId();
    }
}