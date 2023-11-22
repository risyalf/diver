using System;

namespace Assets.Team.Tako.Core.Scripts
{
    /// <summary>
    /// Menangani behaviour mati dari suatu instansi.
    /// </summary>
    internal interface IDeath
    {
        /// <summary>
        /// Dipanggil ketika instansi mati.
        /// </summary>
        void DoDeath();

        /// <summary>
        /// Event yang dipanggil ketika instansi mati.
        /// </summary>
        Action OnDeath { get; set; }
    }
}
