using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Team.Tako.Core.Scripts
{
    /// <summary>
    /// Menangani status game.
    /// </summary>
    public interface IGameStatus
    {
        /// <summary>
        /// Status dari game.
        /// </summary>
        GameStatus Status { get; }

        /// <summary>
        /// Untuk ganti status game.
        /// </summary>
        /// <param name="status">
        /// Status yang dimiliki oleh game.
        /// </param>
        void ChangeStatus(GameStatus status);

        /// <summary>
        /// Event yang dipanggil ketika status game berganti.
        /// </summary>
        Action<GameStatus> OnStatusChanged { get; set; }
    }

    /// <summary>
    /// Status yang dimiliki oleh game.
    /// </summary>
    public enum GameStatus
    {
        Idle,
        Play,
        End
    }
}
