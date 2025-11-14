using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BossActorController : MonoBehaviour
{
    public BossActorData bad;
    public Animator Banim;
    private bool isWaiting = false;
    private Transform targetPlayer; // 记录玩家位置用于转向


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("检查器检测到物体");
        if (other.CompareTag("Player")&& !isWaiting )
        {
            Debug.Log("检测到玩家，自动攻击");
            targetPlayer = other.transform; // 保存玩家位置
            StartCoroutine("Attack");

        }
    }

    IEnumerator Attack()
    {
        isWaiting = true; 
        yield return new WaitForSeconds(2.0f);


        // 若玩家仍在范围内，转向后攻击
        if (targetPlayer != null)
        {
            FacePlayer(targetPlayer);
        }
        this.Banim.SetTrigger("attack");

        isWaiting = false; 
    }

    private void FacePlayer(Transform player)
    {
        Vector3 targetDir = player.position - transform.position;
        targetDir.y = 0;
        transform.rotation = Quaternion.LookRotation(targetDir);
    }


    // 玩家离开时清空目标，避免空引用
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            targetPlayer = null;
        }
    }

}
