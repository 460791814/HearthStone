using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour {
    public MovieTexture movie;
	// Use this for initialization
	void Start () {
        movie.loop = false;
        movie.Play();
	}
	
	// Update is called once per frame
	void Update () {
        if (movie.isPlaying)
        {
            if (Input.GetMouseButton(0))
            { 
             
            }
        }
	}
}
