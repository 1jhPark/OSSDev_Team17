using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//기둥 점수 처리 관련
public class ScoreTrigger : MonoBehaviour
{
    public static int ScoringEx = 1; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoringSystem.score+=ScoringEx; //기둥 통과 시 점수
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
