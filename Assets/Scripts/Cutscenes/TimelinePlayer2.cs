using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
 
public class TimelinePlayer2 : MonoBehaviour
{
    public PlayableDirector director;
 
    
    void Awake(){
        director = director.GetComponent<PlayableDirector>();
    }
 
 
    void OnTriggerExit2D(Collider2D outro)
    {
        if (outro.gameObject.tag == "Aru")
        {
            director.Stop();
        }
    }

    public void StartTimeline(){
        director.Play();
    }
 
    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.tag == "Aru")
        {
            StartTimeline();
        }
    }
}