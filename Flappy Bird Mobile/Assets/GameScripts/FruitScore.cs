using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitScore : MonoBehaviour
{
    public static int FruitEx=3;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoringSystem.score += FruitEx; //보너스 점수
        //FruitGenerate.Eat += 1;
        GetComponent<AudioSource>().Play();
        Destroy(gameObject); //획득 시 파괴
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
