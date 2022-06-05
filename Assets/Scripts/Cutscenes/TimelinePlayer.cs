using UnityEngine;
using UnityEngine.Playables;
 
public class TimelinePlayer : MonoBehaviour
{
    public PlayableDirector timeline;
 
    // Use this for initialization
    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
    }
 
 
    void OnTriggerExit(Collider c)
    {
        if (c.gameObject.tag == "Aru")
        {
            timeline.Stop();
        }
    }
 
    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Ary")
        {
            timeline.Play();
        }
    }
}