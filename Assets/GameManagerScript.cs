using UnityEngine;
using UnityEngine.Serialization;

public class GameManagerScript : MonoBehaviour
{
    public AudioSource HubPlayer;
    public AudioClip HubNone;
    public AudioClip HubOne;
    public AudioClip HubTwo;
    public AudioClip HubThree;
    public GameObject level1Bocker;
    public GameObject level2Bocker;
    public GameObject level3Bocker;
    public GameObject BossWall1;
    public GameObject BossWall2;
    public GameObject BossWall3;
    public GameObject BossWall4;
    public GameObject Key;
    public GameObject Boxes1;
    public GameObject Boxes2;
    public GameObject Boxes3;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HubPlayer = GetComponent<AudioSource>();
        HubPlayer.clip = HubNone;
        HubPlayer.Play();
        if (GameInfo.BeatL1 == true)
        {
            level2Bocker.SetActive(false);;
            Boxes1.SetActive(true);
            HubPlayer.clip = HubOne;
            HubPlayer.Play();
        }
        
        if (GameInfo.BeatL2 == true)
        {
            level3Bocker.SetActive(false);
            Boxes2.SetActive(true);
            HubPlayer.clip = HubTwo;
            HubPlayer.Play();
        }
        
        if (GameInfo.BeatL3 == true)
        {
            Destroy(BossWall1);
            Destroy(BossWall2);
            Destroy(BossWall3);
            Destroy(BossWall4);
            Key.SetActive(true);
            Boxes3.SetActive(true);
            level1Bocker.SetActive(true);
            level2Bocker.SetActive(true);
            level3Bocker.SetActive(true);
            HubPlayer.clip = HubThree;
            HubPlayer.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
