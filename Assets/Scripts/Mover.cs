using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;

    private Transform _targetTransform;
    private Transform _transform;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        _transform.LookAt(_targetTransform);
        _transform.position = Vector3.MoveTowards(_transform.position, _targetTransform.position, _speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == _targetTransform.gameObject)
        {
            Destroy(gameObject);
        }
    }

    public void SetTargetTransform(Transform targetTransform)
    {
        _targetTransform = targetTransform;
    }
}