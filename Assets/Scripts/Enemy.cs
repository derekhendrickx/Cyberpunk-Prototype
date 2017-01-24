using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class Enemy : MonoBehaviour {

	public float damage = 0f;
	public float health = 100f;
	public float speed = 1f;
	private ThirdPersonCharacter thirdPersonCharacter;

	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	void Awake()
	{
		thirdPersonCharacter = gameObject.GetComponentInChildren<ThirdPersonCharacter>();
		thirdPersonCharacter.MoveSpeedMultiplier = speed;
		thirdPersonCharacter.AnimSpeedMultiplier = speed;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/// <summary>
	/// OnTriggerEnter is called when the Collider other enters the trigger.
	/// </summary>
	/// <param name="other">The other Collider involved in this collision.</param>
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			// TODO: Apply damage
		}
	}
}
