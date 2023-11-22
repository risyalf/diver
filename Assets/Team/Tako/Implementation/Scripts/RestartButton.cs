using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Team.Tako.Implementation.Scripts
{
    /// <summary>
    /// Tombol yang digunakan untuk restart game.
    /// </summary>
    public class RestartButton : MonoBehaviour
    {
        #region Variable

        /// <summary>
        /// Menangani tombol yang digunakan untuk restart game.
        /// </summary>
        private Button _restartButton = null;

        #endregion

        #region Mono

        private void Awake()
        {
            _restartButton = GetComponent<Button>();

            _restartButton.onClick.AddListener(() =>
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            });
        }

        private void OnDestroy()
        {
            _restartButton.onClick.RemoveAllListeners();
        }

        #endregion
    }
}