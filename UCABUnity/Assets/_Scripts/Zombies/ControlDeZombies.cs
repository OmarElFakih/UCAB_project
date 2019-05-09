using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class ControlDeZombies : MonoBehaviour
{
    public static ControlDeZombies CZ = null;


    [SerializeField] private Zombie[] zombies = null;
    [SerializeField] private TimelineAsset[] timelines = null;
    private PlayableDirector director = null;

    private int livingZombies = 0;

    private void Awake()
    {
        if (CZ == null) {
            CZ = this;
        }
        else if(CZ != null && CZ != this)
        {
            Destroy(this.gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        livingZombies = zombies.Length;
        director = GetComponent<PlayableDirector>();
    }


    public void ZombieDied()
    {
        livingZombies -= 1;
        if (livingZombies == 0)
        {
            livingZombies = zombies.Length;
            StartCoroutine(NextWave());
        }

    }


    private IEnumerator NextWave() {
        yield return new WaitForSeconds(3f);
        int index = Random.Range(0, timelines.Length);
        director.playableAsset = timelines[index];
        director.Play();
        foreach (Zombie z in zombies)
            z.gameObject.SetActive(true);
    }



}
