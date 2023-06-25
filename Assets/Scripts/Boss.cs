using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public Transform player; // �÷��̾��� Transform ������Ʈ�� �����ؾ� �մϴ�.
    private Animator animator; // NPC ��ü�� Animator ������Ʈ�� �����ؾ� �մϴ�.

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

            // ���⿡ ���� �ִϸ��̼��� �����մϴ�.
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

        // ���� �̵�
        transform.Translate(directions * moveSpeed * Time.deltaTime);

    }
}