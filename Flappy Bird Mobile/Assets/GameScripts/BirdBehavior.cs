using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//플레이어 캐릭터(새)의 행동을 제어하는 코드. 

public class BirdBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D phs;
    //public const float jump=2.5f; //점프력 계수 정의, 스크립트에서 조절
    public float jump=2.5f; //점프력 계수 정의, 엔진에서 조절
    void Start()
    {
        phs = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            GetComponent<AudioSource>().Play();
            phs.velocity = Vector2.up * jump;
        } // 마우스 버튼 눌렀을 때 점프 코드
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (ScoringSystem.score > ScoringSystem.bestscore) //최고점수 판단
        {
            ScoringSystem.bestP = 1;
            ScoringSystem.bestscore = ScoringSystem.score;
        }
        SceneManager.LoadScene("QuitScene");
    }
}
