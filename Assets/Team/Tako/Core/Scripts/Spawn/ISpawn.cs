using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Team.Tako.Core.Scripts.Spawn
{
    /// <summary>
    /// Menangani spawning didalam game.
    /// </summary>
    public interface ISpawn
    {
        /// <summary>
        /// Id spawn yang ada pada scene.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Method yang dipanggil untuk spawn instansi.
        /// </summary>
        void DoSpawn();
    }
}
