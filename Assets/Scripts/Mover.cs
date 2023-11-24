using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        gameObject.transform.position += transform.forward * _speed * Time.deltaTime;
    }
}