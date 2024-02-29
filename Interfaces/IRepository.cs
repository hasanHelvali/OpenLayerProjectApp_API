namespace BasarSoftProject1_API.Interfaces
{
    public interface IRepository<T>
    {
        //Ekleme silme guncelleme ve getirme metotlarının arayuzleri burada listelenecek.
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
    }
}
