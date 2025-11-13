using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gatewayred : MonoBehaviour
{
    public door Door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider Other)//如果挂载这个代码的碰撞体一直与另一个碰撞体碰撞
    {
        Door.Lift(2);//视频里的是door.SendMessage("Lift");d
    }

}
