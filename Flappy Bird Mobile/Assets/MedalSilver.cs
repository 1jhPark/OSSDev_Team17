using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//은메달 획득 코드
public class MedalSilver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoringSystem.bestP == 0)
        {
            gameObject.SetActive(true);
        }
        else if (ScoringSystem.bestP == 1)
        {
            gameObject.SetActive(false);
        }
    }
}
