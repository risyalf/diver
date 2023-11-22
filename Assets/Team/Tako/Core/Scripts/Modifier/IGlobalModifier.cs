using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Team.Tako.Core.Scripts.Modifier
{
    /// <summary>
    /// Modifier yang bersifat global.
    /// </summary>
    public interface IGlobalModifier
    {
        /// <summary>
        /// Nilai modifier pada stat.
        /// </summary>
        float Modifier { get; }

        /// <summary>
        /// Untuk mengubah modifier.
        /// </summary>
        /// <param name="modifier">
        /// Nilai modifier.
        /// </param>
        void SetModifier(float modifier);
    }
}
