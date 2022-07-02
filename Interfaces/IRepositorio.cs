namespace series.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lsita();

         T RetornaPorId(int id);
         void Insere(Task entidade);
         void Exclui(int id);
         void Atualiza(int id, Task entidade);
         int ProximoId();
    }
}