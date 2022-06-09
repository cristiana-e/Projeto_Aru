using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
 
public class TimelinePlayer : MonoBehaviour
{
    public PlayableDirector director;
 
    
    void Awake(){
        director = GetComponent<PlayableDirector>();
    }
    // Use this for initialization
    void Start()
    {
        
    }
 
 
    void OnTriggerExit2D(Collider2D outro)
    {
        if (outro.gameObject.tag == "Aru")
        {
            director.Stop();
        }
    }
 
    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.tag == "Aru")
        {
            director.Play();
        }
    }
}