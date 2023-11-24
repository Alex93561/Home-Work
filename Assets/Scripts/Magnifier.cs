using UnityEngine;

public class Magnifier : MonoBehaviour
{
    [SerializeField] private float _rateOfIncrease;

    private void Update()
    {
        float normalizedRateOfIncrease = _rateOfIncrease * Time.deltaTime;
        Vector3 growthDirection = new(normalizedRateOfIncrease, normalizedRateOfIncrease, normalizedRateOfIncrease);
        transform.localScale += growthDirection;
    }
}