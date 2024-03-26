using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExCharacter : MonoBehaviour
{
    public float speed = 5f; //캐릭터 이동속도

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        Move();  //프레임마다 Move함수 호출
    }

    protected virtual void Move() //virtual 키워드를 작성하여 상속받은 클래스가 재 정의 할 수 있게한다.
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);   //캐릭터를 앞으로 이동
    }
   
   public void DestoryCharacter() //캐릭터파괴
    {
        Destroy(gameObject);
    }    
}
