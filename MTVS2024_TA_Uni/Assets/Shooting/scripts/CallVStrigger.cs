using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting; //비주얼 스크립트 네임스페이스 추가
using UnityEngine;

public class CallVStrigger : MonoBehaviour
{
    //현재 게임오브젝트가 가지고 있는 비주얼 스크립트 컴포넌트
    public ScriptMachine machine;
    //Variables 컴포넌트 (비주얼스크립트를 가진 오브젝트라면 Variables 컴포넌트는 자동 추가)
    public Variables vsComp;
    //Variables 컴포넌트에서 받아온 값을 확인하기 위한 변수
    public float a;


    // Start is called before the first frame update
    void Start()
    {
        //내가 가지고 있는 비주얼 스크립트 컴포넌트를 담는다
        machine = GetComponent<ScriptMachine>();
        //작성된 스크립트의 유니티 이벤트를 실행한다. 커스텀이벤트는 C#에서 실행시킬 수 없다.
        machine.TriggerUnityEvent("CallToCS");


        //게임오브젝트의 Variables 컴포넌트를 담는다
        vsComp = GetComponent<Variables>();
        //Variables 컴포넌트의 speedObj 변수의 값을 a 변수에 담는다
        a = Variables.Object(vsComp).Get<float>("speedObj");

    }

    // Update is called once per frame
    void Update()
    {
        a = Variables.Object(vsComp).Get<float>("speedObj");
    }
}
