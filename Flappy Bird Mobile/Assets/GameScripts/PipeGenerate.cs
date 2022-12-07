using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//파이프 생성기 
public class PipeGenerate : MonoBehaviour
{
    //public float objCtrl;
    //public GameObject obj;
    public float TimeCount, PipeCount, DestroyCount;
    public float highestPP, lowestPP;
    public GameObject Pipe;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeCount += Time.deltaTime;
        if (TimeCount > PipeCount) // 파이프가 나오는 시점 조절
        {
            GameObject clonedPipe = Instantiate(Pipe, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity); //파이프를 복사하여 출력
            clonedPipe.transform.position = new Vector3(2, Random.Range(highestPP, lowestPP), 0); //랜덤한 y좌표로 복사된 파이프를 이동
            TimeCount = 0;
            DestroyPipe(clonedPipe); //최적화를 위한 오브젝트 파괴
        }
        /*
        Count();
        if (TimeCount == 1)
        {
            Instantiate(Pipe);
            TimeCount = 0;
        }
        */
    }
    void DestroyPipe(GameObject obj) //오브젝트를 파괴하는 함수
    {
        Destroy(obj, DestroyCount);
    }
    /*
    public int Count()
    {
        TimeCount += Time.deltaTime;
        if (TimeCount > PipeCount) { return 1; }
        else return 0;
    }
    */
}
