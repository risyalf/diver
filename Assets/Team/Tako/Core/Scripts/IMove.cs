using UnityEngine;

namespace Assets.Team.Tako.Core.Scripts
{
    /// <summary>
    /// Menangani pergerakan dari suatu instansi.
    /// </summary>
    public interface IMove
    {
        /// <summary>
        /// Untuk menggerakkan instansi.
        /// </summary>
        /// <param name="direction">
        /// Arah instansi bergerak.
        /// </param>
        void DoMove(Vector3 direction);
    }
}
