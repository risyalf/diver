namespace Assets.Team.Tako.Core.Scripts.ObjectPooling
{
    /// <summary>
    /// Object yang dapat di pooling.
    /// </summary>
    public interface IPooledObject
    {
        /// <summary>
        /// Untuk mengaktifkan object.
        /// </summary>
        void Activate();

        /// <summary>
        /// Untuk mematikan object.
        /// </summary>
        void DeActivate();

        /// <summary>
        /// Untuk mengetahui apakah object pool aktif atau tidak.
        /// </summary>
        /// <returns>
        /// Mengembalikan nilai berupa bool.
        /// </returns>
        bool IsActive();
    }
}
