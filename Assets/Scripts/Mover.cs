using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _direction;

    private void Update()
    {
        gameObject.transform.position += _direction * _speed * Time.deltaTime;
    }

    public void SetTarget(Vector3 target)
    {
        _direction = target;
    }
}