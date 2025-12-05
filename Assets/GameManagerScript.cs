using UnityEngine;
using UnityEngine.Serialization;

public class GameManagerScript : MonoBehaviour
{
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
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameInfo.BeatL1 == true)
        {
            Destroy(level2Bocker);
            Boxes1.SetActive(true);
        }
        
        if (GameInfo.BeatL2 == true)
        {
            Destroy(level3Bocker);
            Boxes2.SetActive(true);
        }
        
        if (GameInfo.BeatL3 == true)
        {
            Destroy(BossWall1);
            Destroy(BossWall2);
            Destroy(BossWall3);
            Destroy(BossWall4);
            Key.SetActive(true);
            Boxes3.SetActive(true);
        }
    }
}
