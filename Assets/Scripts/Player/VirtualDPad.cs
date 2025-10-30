using TMPro;
using UnityEngine;

public class VirtualDPad : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI directionText;
    
    Vector2 touchStartPosition;
    Vector2 touchEndPosition;
    string direction = "";

    private PlayerController playerController;

    void Start()
    {
        playerController = FindFirstObjectByType<PlayerController>();
    }
    void Update()
    {
        // --- TOUCH ---
        if (Input.touchCount > 0)
        {
            Touch theTouch = Input.GetTouch(0);

            if (theTouch.phase == TouchPhase.Began)
            {
                touchStartPosition = theTouch.position;
            }
            else if (theTouch.phase == TouchPhase.Moved || theTouch.phase == TouchPhase.Ended)
            {
                touchEndPosition = theTouch.position;
                DetectDirection();
            }
        }

        // --- MOUSE ---
        if (Input.GetMouseButtonDown(0))
        {
            touchStartPosition = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            touchEndPosition = Input.mousePosition;
            DetectDirection();
        }

        directionText.text = direction;
        
    }

    void DetectDirection()
    {
        float x = touchEndPosition.x - touchStartPosition.x;
        float y = touchEndPosition.y - touchStartPosition.y;

        if (Mathf.Abs(x) == 0 && Mathf.Abs(y) == 0)
        {
            direction = "Tapped";
        }
        else if (Mathf.Abs(x) > Mathf.Abs(y))
        {
            direction = x > 0 ? "Right" : "Left";
            playerController.MovePlayer(direction);
        }
        else
        {
            direction = y > 0 ? "Up" : "Down";
        }
    }

}