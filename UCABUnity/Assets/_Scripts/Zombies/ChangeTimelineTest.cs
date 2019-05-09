using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;

public class ChangeTimelineTest : MonoBehaviour
{
    private PlayableDirector PD = null;
    public TimelineAsset TA;
    public TimelineAsset TB;


    private void Start()
    {
        PD = GetComponent<PlayableDirector>();
    }

    public void ChangeTimeline() {
        PD.playableAsset = (PD.playableAsset == TA) ? TB : TA;

        PD.Play();

    }
    
    
}
