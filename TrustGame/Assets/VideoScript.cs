using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoScript : MonoBehaviour
{
    public GameObject Nextvideo;

    private VideoPlayer videoPlayer;
    // Start is called before the first frame update
    void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(OnMovieFinished(videoPlayer));
    }

    IEnumerator OnMovieFinished(VideoPlayer player)
    {
        while (player.isPlaying)
        {
            yield return null;
        }
        Nextvideo.SetActive(true);
    }
}
