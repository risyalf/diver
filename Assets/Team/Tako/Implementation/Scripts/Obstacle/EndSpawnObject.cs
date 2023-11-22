using Assets.Team.Tako.Core.Scripts.Spawn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Team.Tako.Implementation.Scripts.Obstacle
{
    /// <summary>
    /// Untuk mengakhiri object spawn yang ada di scene.
    /// </summary>
    public class EndSpawnObject : MonoBehaviour
    {
        #region Variable

        /// <summary>
        /// Batas x untuk mengakhiri object spawn.
        /// </summary>
        [SerializeField]
        private float endOfXPosition = 0;

        #endregion

        #region Mono

        private void Update()
        {
            if (transform.position.x <= endOfXPosition)
            {
                gameObject.SetActive(false);
            }
        }

        #endregion
    }
}
