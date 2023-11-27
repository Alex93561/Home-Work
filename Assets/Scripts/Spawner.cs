using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Collider _target;
    [SerializeField] private Mover _enemy;

    private float _rechargeTime = 2f;
    private Coroutine _createEnemyJob;

    private void Start()
    {
        _createEnemyJob = StartCoroutine(CreateEnemy());
    }

    private IEnumerator CreateEnemy()
    {
        WaitForSeconds waitForRechargeTime = new(_rechargeTime);

        while (true)
        {
            Instantiate(_enemy, gameObject.transform.position, _enemy.transform.rotation).SetTargetTransform(_target.transform);

            yield return waitForRechargeTime;
        }
    }

    private void OnDestroy()
    {
        StopCoroutine(_createEnemyJob);
    }
}