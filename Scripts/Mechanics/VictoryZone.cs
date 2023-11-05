using Platformer.Gameplay;
using UnityEngine;
using System.Collections;
using static Platformer.Core.Simulation;

namespace Platformer.Mechanics
{
    /// <summary>
    /// Marks a trigger as a VictoryZone, usually used to end the current game level.
    /// </summary>
    public class VictoryZone : MonoBehaviour
    {
        void OnTriggerEnter2D(Collider2D collider)
        {
            var p = collider.gameObject.GetComponent<PlayerController>();
            if (p != null)
            {
                var ev = Schedule<PlayerEnteredVictoryZone>();
                ev.victoryZone = this;
            }

            if (collider.gameObject.CompareTag("Player"))
            {
                StartCoroutine(waitBeforeLevel());
                Destroy(collider.gameObject);
            }
        }

        public IEnumerator waitBeforeLevel()
        {
            yield return new WaitForSeconds(2);
            Application.LoadLevelAdditive(1);
        }

   
    }

    
}