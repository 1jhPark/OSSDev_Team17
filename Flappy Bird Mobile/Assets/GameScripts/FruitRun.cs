using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitRun : MonoBehaviour
{
    public float FruitSp;
    public GameObject Fruit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * Vector3.left * FruitSp; //화면에 따라 과일 이동
       
    }
}
