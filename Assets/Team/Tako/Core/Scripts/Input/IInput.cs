using System;

namespace Assets.Team.Tako.Core.Scripts
{
    /// <summary>
    /// Menangani input yang diberikan oleh player.
    /// </summary>
    public interface IInput
    {
        string Id { get; }

        /// <summary>
        /// Untuk membuat input dapat digunakan atau tidak.
        /// </summary>
        /// <param name="disable">
        /// Indikasi apakah input dapat digunakan atau tidak.
        /// </param>
        void SetDisable(bool disable);
    }

    /// <summary>
    /// Menangani input yang diberikan oleh player.
    /// </summary>
    /// <typeparam name="T">
    /// Semua jenis tipe yang ada di sistem.
    /// </typeparam>
    public interface IInput<T> : IInput
    {
        /// <summary>
        /// Nilai yang dimiliki oleh Input.
        /// </summary>
        T Value { get; }

        /// <summary>
        /// Event yang dipanggil ketika value dari inputan berubah.
        /// </summary>
        Action<T> OnValueChange { get; set; }
    }
}