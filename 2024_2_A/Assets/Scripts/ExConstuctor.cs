using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExConstuctor : MonoBehaviour
{
    private int value;

    public ExConstuctor(int _value)
    {
        value = _value;
        Debug.Log("��ü�� ���� �Ǿ����ϴ� . �ʱⰪ : " + value);
    }
    // Start is called before the first frame update
    void Start()
    {
        ExConstuctor ex = new ExConstuctor(10);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(this.gameObject);
        }
    }
    void OnDestroy()
    {
        Debug.Log("��ü�� �ı��Ǿ����ϴ�");
    }
}


