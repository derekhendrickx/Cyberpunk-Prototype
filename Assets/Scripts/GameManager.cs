using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null; 

	private GameObject player;

	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
		else if (instance != this)
		{
			Destroy(gameObject);   
		}
		//Sets this to not be destroyed when reloading scene
		DontDestroyOnLoad(gameObject);
		
		Init();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void Init()
	{
		player = GameObject.FindGameObjectWithTag("Player");
	}
}
