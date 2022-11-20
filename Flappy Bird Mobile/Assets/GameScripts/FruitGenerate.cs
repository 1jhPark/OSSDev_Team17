using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//과일 생성기
public class FruitGenerate : MonoBehaviour
{
    //public float objCtrl;
    //public GameObject obj;
    public float TimeCount, FruitCount, DestroyCount, GenRate;
    public float highestPP, lowestPP;
    //public static int Eat = 0;
    public GameObject Fruit;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        TimeCount += Time.deltaTime;
        GameObject clonedFruit;
        if (TimeCount > FruitCount) // 파이프가 나오는 시점 조절
        {
            if (Random.Range(0, GenRate)>50)
            {
                clonedFruit = Instantiate(Fruit, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity); //파이프를 복사하여 출력
                clonedFruit.transform.position = new Vector3(4, Random.Range(highestPP, lowestPP), 0); //랜덤한 y좌표로 복사된 파이프를 이동
                TimeCount = 0;
                //if (Eat == 1) { Destroy(clonedFruit, 0); }
                DestroyFruit(clonedFruit); //최적화를 위한 오브젝트 파괴
            }

        }
        
    }
    void DestroyFruit(GameObject obj) //오브젝트를 파괴하는 함수
    {
        Destroy(obj, DestroyCount);
    }
}
