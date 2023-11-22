using Assets.Team.Tako.Core.Scripts;
using Assets.Team.Tako.Core.Scripts.Modifier;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Team.Tako.Implementation.Scripts
{
    /// <summary>
    /// Menangani tingkat kesulitan pada game.
    /// </summary>
    public class DifficultyManager : MonoBehaviour
    {
        #region Variable

        private ITimer _timer = null;

        private IMovementSpeedGlobalModifier _modifier = null;

        private int _counter = 1;

        [SerializeField]
        private int tresholdToIncreaseDifficulty = 0;

        [SerializeField]
        private float increasePerTreshold = 0;

        #endregion

        #region Mono

        private void Awake()
        {
            _timer = FindObjectsOfType<MonoBehaviour>().OfType<ITimer>().FirstOrDefault();

            _modifier = FindObjectsOfType<MonoBehaviour>().OfType<IMovementSpeedGlobalModifier>().FirstOrDefault();
        }

        private void Update()
        {
            if (_timer.Timer > tresholdToIncreaseDifficulty * _counter)
            {
                _modifier.SetModifier(_modifier.Modifier + _counter * increasePerTreshold);

                _counter++;
            }
        }

        #endregion
    }
}