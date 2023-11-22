namespace Assets.Team.Tako.Core.Scripts.Factory
{
    /// <summary>
    /// Menangani pembuatan dari suatu instansi.
    /// </summary>
    /// <typeparam name="T">
    /// Semua tipe yang ada di sistem.
    /// </typeparam>
    public interface IFactory<T>
    {
        /// <summary>
        /// Untuk mendapatkan instansi.
        /// </summary>
        /// <param name="parameters">
        /// Parameter yang digunakan untuk mendapatkan instansi.
        /// </param>
        /// <returns>
        /// Mengembalikan nilai berupa T.
        /// </returns>
        T Get(params object[] parameters);

        /// <summary>
        /// Untuk reset factory.
        /// </summary>
        void Reset();
    }
}
