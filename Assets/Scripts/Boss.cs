using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public Transform player; // 플레이어의 Transform 컴포넌트를 연결해야 합니다.
    private Animator animator; // NPC 객체의 Animator 컴포넌트를 연결해야 합니다.

    public float moveSpeed = 11f;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (player != null)
        {
            Vector3 direction = player.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            // 방향에 따라 애니메이션을 설정합니다.
            if (direction.x < 0)
            {
                animator.Play("BossLeft");
            }
            else
            {
                animator.Play("BossRight");
            }
        }

        Vector2 directions = player.position - transform.position;
        directions.Normalize();

        // 몬스터 이동
        transform.Translate(directions * moveSpeed * Time.deltaTime);

    }
}