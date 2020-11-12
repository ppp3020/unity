using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //에너미 매니저 역할?
    //에너미들을 공장에서 찍어낸다 (에너미 프리팹)
    //애너미 스폰타임 - 랜덤처리
    //애너미 스폰위치 - 화면 위에 배치를 한다

    public GameObject enemyFactory;         // 에너미 공장 (프리팹)
    public GameObject[] spawnPoints;          // 스폰위치 여러개
    float spawnTime = 1.0f;                 // 스폰 시간 (몇초에 한번씩 찍어낼거니?)
    float curTime = 0.0f;                   // 누적 시간

    // Start is called before the first frame update
    void Start()
    {
        //에너미 생성
        spawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawnEnemy()
    {
        // 몇초에 한번 씩 이벤트 발동
        // 누적 시간으로 계산을 한다
        // 게임에서 정말 자주 사용함

        curTime += Time.deltaTime;
        if (curTime > spawnTime)
        {
            // 누적 현재시간을 0초로 초기화 (반드시 해줘야 한다)
            curTime = 0.0f;

            // 스폰 타임을 랜덤으로 처리하자
            spawnTime = Random.Range(0.5f, 2.0f);

            // 에너미 생성
            GameObject enemy = Instantiate(enemyFactory);
            int index = Random.Range(0, spawnPoints.Length);
            enemy.transform.position = spawnPoints[index].transform.position;
            //enemy.transform.position = transform.GetChild(index).position;        둘 중 편한걸로 사용
        }
    }
}
