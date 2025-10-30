using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TouchPhaseDisplay : MonoBehaviour
{
    private Touch theTouch;
    private float timeTouchEnded;
    private float displayTime = 0.5f;
    public TextMeshProUGUI phaseDisplayText;
    void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            theTouch = Input.GetTouch(0);
            phaseDisplayText.text = theTouch.phase.ToString();

            if (theTouch.phase == TouchPhase.Ended)
            {
                timeTouchEnded = Time.time;
            }
        }

        else if (Time.time - timeTouchEnded > displayTime)
        {
            phaseDisplayText.text = "";
        }
    }
}
