using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;


namespace BehaviorDesigner.Runtime.Tasks
{
    public class SendMessage : Action
    {
        [DllImport("user32.dll", EntryPoint = "keybd_event")]
        public static extern void Keybd_event(

        byte bvk,

        byte bScan,//0

        int dwFlags,//0Ϊ���£�1��ס��2�ͷ�

        int dwExtraInfo//0

        );


        public override TaskStatus OnUpdate()
        {
            Keybd_event(80, 0, 0, 0);
            Keybd_event(80, 0, 2, 0);
            // Log the text and return success
            return TaskStatus.Success;
        }


    }
}

