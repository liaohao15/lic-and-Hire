using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{

    public float startY;
    public float middleY;
    public float endY;
    public int point = 0;//用来登记门的上升阶段
    public int planID = -1;//用来判断是不是一个板子连续碰撞
    // Start is called before the first frame update
    void Start()
    { 
        middleY = transform.position.y + 2.5f;
        endY = transform.position.y + 8.5f;

    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void Lift(int planX)
    {
        //if (point == 0)
        //{
        //    if (planID != planX)
        //    {
        //        planID = planX;
        //        if (transform.position.y < middleY)
        //        {
        //            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z);

        //            if (transform.position.y >= middleY)
        //            {
        //                point = 1;//一阶段完成，进入第二阶段
        //            }
        //        }
        //    }

        if (point == 0)
        {
            planID = planX;
            if (planID == planX)
            {
                if (transform.position.y < middleY)
                {
                    gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z);

                    if (transform.position.y >= middleY)
                    {
                        point = 1;//一阶段完成，进入第二阶段
                    }
                }
            }

        }
        if (point == 1)
        {
            if (planID != planX)
            {
                if (transform.position.y < endY)
                {
                    gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z);

                    if (transform.position.y >= endY)
                    {
                        point = 2;
                    }
                }
            }
        }
        if (point == 2)
        { 
            return;
        }


    }


}
