using UnityEngine;
using System.Collections;

public class GameCenter : MonoBehaviour {

    public MovieTexture movie;
    public UITexture movieTexture;
    public TweenScale tweenScale;
    private bool isStart = true;
    // Use this for initialization
    void Start()
    {
        movie.loop = false;
        movie.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (isStart)
        {
            if (movie.isPlaying)
            {
                if (Input.GetMouseButton(0))
                {
                    StopMovie();
                }
            }
            else
            {
                StopMovie();
            }
        }
    }
    void StopMovie()
    {
        isStart = false;
        movie.Stop();
        movieTexture.gameObject.SetActive(false);
        tweenScale.PlayForward();
     
    }
}
