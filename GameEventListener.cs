using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SkyBrave_Toolkit.Scripts.Scriptable_Game_Events
{
    public class GameEventListener : MonoBehaviour
    {
        [Tooltip("Events to register with.")]
        public List<GameEvent> gameEvents;
    
        [Tooltip("Responses to invoke when Event is raised.")]
        public List<UnityEvent> responses;

        private void OnEnable()
        {
            foreach (var gameEvent in gameEvents)
            {
                gameEvent.RegisterListener(this);
            }
        }

        private void OnDisable()
        {
            foreach (var gameEvent in gameEvents)
            {
                gameEvent.UnregisterListener(this);
            }
        }

        public void OnEventRaised(GameEvent gameEvent)
        {
            int indexOfResponseToInvoke = gameEvents.IndexOf(gameEvent);
            responses[indexOfResponseToInvoke].Invoke();
        }

        public void WriteOnConsole(string debugLog)
        {
            print(debugLog);
        }
    }
}

