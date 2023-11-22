using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Team.Tako.Core.Scripts
{
    /// <summary>
    /// Menangani timer pada game.
    /// </summary>
    public interface ITimer
    {
        /// <summary>
        /// TimerMono yang berjalan pada game.
        /// </summary>
        float Timer { get; }
    }
}
