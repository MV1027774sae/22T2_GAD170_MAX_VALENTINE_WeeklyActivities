using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace MaxValentine
{
    public class ResetCounter : MonoBehaviour
    {
        // we need to have a COUNTER...
        [SerializeField] private TextMeshProUGUI resestCounterUI;
        [SerializeField] private int resetCount = 0;

        // ...we need to increase the counter's value every time the marble resets

        // We need to start and stop listening to the OnMarbleRest event
        private void OnEnable()
        {
            MarbleCapture.OnMarbleReset += IncreaseResetCount;
        }

        private void OnDisable()
        {
            MarbleCapture.OnMarbleReset -= IncreaseResetCount;
        }

        // when the OnMarbleReset event is announced, we increase the counter's value

        private void IncreaseResetCount()
        {
            resetCount++;
            resestCounterUI.text = resetCount.ToString();
        }
    }
}
