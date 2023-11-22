using Assets.Team.Tako.Core.Scripts.Spawn;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Team.Tako.Implementation.Scripts
{
    /// <summary>
    /// Untuk trigger spawn background.
    /// </summary>
    public class TriggerSpawnBackground : MonoBehaviour
    {
        #region Variable

        /// <summary>
        /// Posisi x sampai spawn.
        /// </summary>
        [SerializeField]
        private float positionXToSpawn = 0;

        /// <summary>
        /// Menangani spawn dari suatu entitas.
        /// </summary>
        private ISpawn _spawn = null;

        /// <summary>
        /// Indikasi apakah sudah spawn atau belum.
        /// </summary>
        private bool _doneSpawn = false;

        #endregion

        #region Mono

        private void Awake()
        {
            _spawn = FindObjectsOfType<MonoBehaviour>().OfType<ISpawn>().Where(x => x.Id == "Background").First();
        }

        private void Update()
        {
            if (transform.position.x <= positionXToSpawn && !_doneSpawn)
            {
                _doneSpawn = true;

                _spawn.DoSpawn();
            }
        }

        private void OnDisable()
        {
            _doneSpawn = false;
        }

        #endregion
    }
}