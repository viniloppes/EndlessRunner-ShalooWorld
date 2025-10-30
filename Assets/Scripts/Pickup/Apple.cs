using UnityEngine;

public class Apple : Pickup
{
    
    [SerializeField] private float adjustChangeSpeedAmount = 3.0f;
    private LevelGenerator _levelGenerator ;
    public void Init(LevelGenerator levelGenerator)
    {
        this._levelGenerator = levelGenerator;
    }
    protected override void OnPickup()
    {
        _levelGenerator.ChangeSpeed(adjustChangeSpeedAmount);
        Destroy(gameObject);
    }
}
