using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//플레이어 캐릭터(새)의 행동을 제어하는 코드. 
//조작법은 터치 한 번에 점프 한 번. 
//컴퓨터용 테스트 버전을 위해 마우스 클릭도 가능하게 해야 함

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
        if (ScoringSystem.score > ScoringSystem.bestscore)
        {
            ScoringSystem.bestscore = ScoringSystem.score;
        }
        SceneManager.LoadScene("QuitScene");
    }
}
