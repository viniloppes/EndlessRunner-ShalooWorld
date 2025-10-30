using UnityEngine;

public class PlayerColliderHandle : MonoBehaviour
{
    [SerializeField] private Animator hitAnimator;
    [SerializeField] private float collisionCooldown = 1.0f;
    [SerializeField] private float adjustChangeSpeedAmount = -2.0f;

    private const string PlayerHitStr = "Hit";

    private LevelGenerator _levelGenerator ;
    private float cooldownTimer = 0.0f;


    void Start()
    {
        _levelGenerator = FindFirstObjectByType<LevelGenerator>();
        
    }
    void Update()
    {
        if (cooldownTimer > 0.0f)
        {
            cooldownTimer -= Time.deltaTime;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!(cooldownTimer <= 0.0f)) return;
        
        _levelGenerator.ChangeSpeed(adjustChangeSpeedAmount);
        cooldownTimer = collisionCooldown;
        hitAnimator.SetTrigger(PlayerHitStr);
        // Debug.Log(collision.gameObject.name);
    }
}