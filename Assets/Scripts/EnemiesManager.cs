using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemiesManager : MonoBehaviour {

	public GameObject enemyPrefab;
	public int nbEnemy = 1;
	public Transform center;
	public float range = 10f;

	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	void Awake()
	{
		for(var i = 0; i < nbEnemy; i++)
		{
			Vector3 origin;
			if (this.RandomPoint(center.position, range, out origin))
			{
				var enemy = Instantiate(enemyPrefab, origin, Quaternion.identity);
				enemy.transform.parent = gameObject.transform;
			}
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private bool RandomPoint(Vector3 center, float range, out Vector3 result) {
		for (int i = 0; i < 30; i++) {
			Vector3 randomPoint = center + Random.insideUnitSphere * range;
			NavMeshHit hit;
			if (NavMesh.SamplePosition(randomPoint, out hit, 1.0f, NavMesh.AllAreas)) {
				result = hit.position;
				return true;
			}
		}
		result = Vector3.zero;
		return false;
	}
}
