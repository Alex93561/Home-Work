using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] List<GameObject> _spawnPoints;
    [SerializeField] GameObject _enemy;

    private float _rechargeTime = 2f;


    private void Start()
    {
        Coroutine createEnemyJob = StartCoroutine(CreateEnemy());
    }

    private IEnumerator CreateEnemy()
    {
        WaitForSeconds waitForRechargeTime = new WaitForSeconds(_rechargeTime);

        while (true)
        {
            Transform tempTransform = _spawnPoints[Random.Range(0, _spawnPoints.Count)].transform;
            Instantiate(_enemy, tempTransform.position, tempTransform.localRotation);

            yield return waitForRechargeTime;
        }
    }
}


