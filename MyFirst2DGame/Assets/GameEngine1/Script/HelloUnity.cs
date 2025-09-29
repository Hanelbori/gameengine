using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 게임 시작 시 한 번만 실행되는 코드
        Debug.Log("게임이 시작되었습니다!");
        
        // 4주차에서 만든 Animator 찾기 (나중에 배울 예정)
        // myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // 매 프레임마다 실행되는 코드
        Debug.Log("매 프레임마다 실행됩니다!");
        // A키가 눌렸는지 확인 (나중에 배울 예정)
        // if(Input.GetKey(KeyCode.A)) {
        //     Debug.Log("A키가 눌렸습니다!");
        // }
    }
}
