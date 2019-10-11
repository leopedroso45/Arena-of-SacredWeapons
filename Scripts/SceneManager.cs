using UnityEngine;

public class SceneManager : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartMap()
    {
        Application.LoadLevel(1);
    }
}
