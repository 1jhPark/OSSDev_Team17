using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CurrentSc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = ScoringSystem.score.ToString(); //게임 종료 시 점수 표시
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
