using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private List<GameObject> _spawnPoints;
    [SerializeField] private Mover _enemy;

    private float _rechargeTime = 2f;

    private void Start()
    {
        StartCoroutine(CreateEnemy());
    }

    private IEnumerator CreateEnemy()
    {
        WaitForSeconds waitForRechargeTime = new(_rechargeTime);

        while (true)
        {
            Transform tempTransform = _spawnPoints[Random.Range(0, _spawnPoints.Count)].transform;
            Instantiate(_enemy, tempTransform.position, Quaternion.identity).SetTarget(_direction);

            yield return waitForRechargeTime;
        }
    }
}