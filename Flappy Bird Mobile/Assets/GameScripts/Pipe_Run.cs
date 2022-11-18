using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_Run : MonoBehaviour
{
    public float PipeSp; //파이프 이동 속, 높은 값 부여 시 난이도 상승
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime*Vector3.left*PipeSp; //시간에 따라*파이프 위치가*속도만큼 변함
        //Debug.Log(transform.position); // 파이프 현재 위치 확인 테스트용 코드
    }
}
