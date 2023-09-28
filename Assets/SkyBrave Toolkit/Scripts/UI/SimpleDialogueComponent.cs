using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace SkyBrave_Toolkit.Scripts.UI
{
    public class SimpleDialogueComponent : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI textComponent;
        [SerializeField] private string[] lines;
        [SerializeField] private float timeBetweenCharacters = 0.04f;

        [SerializeField] private UnityEvent onDialogueEnded;

        private int _currentLineIndex;

        public void EvaluatePlayerInputToProgressDialogue()
        {
            if (textComponent.text == lines[_currentLineIndex])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[_currentLineIndex];
            }
        }

        public void StartDialogue()
        {
            textComponent.text = string.Empty;
            _currentLineIndex = 0;
            StartCoroutine(TypeLine());
        }

        IEnumerator TypeLine()
        {
            foreach (char c in lines[_currentLineIndex].ToCharArray())
            {
                textComponent.text += c;
                yield return new WaitForSeconds(timeBetweenCharacters);
            }
        }

        private void NextLine()
        {
            if (_currentLineIndex < lines.Length - 1)
            {
                _currentLineIndex++;
                textComponent.text = string.Empty;
                StartCoroutine(TypeLine());
            }
            else
            {
                EndDialogue();
            }
        }

        private void EndDialogue()
        {
            onDialogueEnded.Invoke();
        }
    }
}
