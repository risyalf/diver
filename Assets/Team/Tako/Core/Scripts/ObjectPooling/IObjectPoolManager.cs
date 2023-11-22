namespace Assets.Team.Tako.Core.Scripts.ObjectPooling
{
    /// <summary>
    /// Menangain object pooling pada suatu instansi.
    /// </summary>
    public interface IObjectPoolManager
    {
        /// <summary>
        /// Untuk mendapatkan object yang dapat digunakan.
        /// </summary>
        /// <returns>
        /// Mengembalikan nilai berupa IPooledObject.
        /// </returns>
        IPooledObject GetFreeObject();

        /// <summary>
        /// Menghapus semua cache dari object pooling.
        /// </summary>
        void ResetPooling();
    }
}
