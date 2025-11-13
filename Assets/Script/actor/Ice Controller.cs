using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(CapsuleCollider))]
[RequireComponent(typeof(Rigidbody))]

public class IceController : MonoBehaviour
{

    public float Sport;
    public Animator anim;
    public Rigidbody rb;

    public float Corner;

    [Header("移动速度：")]
    public float MoveSpeed = 3.0f;

    [Header("转速：")]
    public float RotateSpeed;

    [Header("跳跃高度")]
    public float  Jumpheight;
    public bool isJumping = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();//移动

        Turn();//转向

        Jump();//跳跃
        if (isJumping && Physics.Raycast(transform.position, Vector3.down, 2f))
        { 
            isJumping = false;
        }

        Attack();//攻击

    }

    public void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Sport = Mathf.Min(Sport + 0.05f, 1f);
         
        }
        else
        {
            Sport = Mathf.Max(Sport - 0.03f, 0);
        }
        anim.SetFloat("Sport", Sport);

        if (Sport > 0.05f)
        {
            transform.Translate(Vector3.forward * MoveSpeed * Sport * Time.deltaTime);//（现在的方向走（原始速度*速度的倍率*时间））
        }
    }

    public void Turn()
    {

        Corner = 0;
        //用来告诉anim往哪里转
        if (Input.GetKey(KeyCode.A))//向左转
        {
            Corner = -1;
        }

        if (Input.GetKey(KeyCode.D))//向右转
        {
            Corner = 1;
        }
        anim.SetFloat("Corner", Corner);
        //
        if (Corner != 0)
        {
            transform.Rotate(0, Corner * RotateSpeed * Time.deltaTime, 0);//(0,x,0)表示不饶x,z轴转
        }

    }

    public void Jump()
    {
        if (Input.GetKey(KeyCode.K)&& !isJumping)
        {
            anim.SetTrigger("Jump");
            rb.AddForce(Vector3.up * Jumpheight, ForceMode.Impulse);
            isJumping = true;
        }
    }

    public void Attack()
    {
        if (Input.GetKey(KeyCode.J))
        {
            anim.SetTrigger("attack");
        }
    }


}
