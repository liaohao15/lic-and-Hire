using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    public float Sport;
    public Animator anim;

    public float Corner;

    [Header("移动速度：")]
    public float MoveSpeed = 3.0f;

    [Header("转速：")]
    public float RotateSpeed;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();//移动
        Turn();


    }

    public void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Sport = Mathf.Min(Sport + 0.05f, 1f);
            print("现在速度为:" + Sport * MoveSpeed);
        }
        else
        {
            Sport = Mathf.Max(Sport - 0.03f, 0);
        }
        anim.SetFloat("Sport", Sport);

        if (Sport > 0.05f)
        {
            transform.Translate(Vector3.forward * MoveSpeed * Sport * Time.deltaTime);
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


}
