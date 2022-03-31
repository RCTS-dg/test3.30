using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalData : MonoBehaviour
{
    public static float attackTime=0;
    public static float defend =0;
    public static float returnAttack =0;
    public static float speed=1;
    public static float attack=1;

    public static float NattackTime = 0;
    public static float Ndefend = 0;
    public static float NreturnAttack = 0;
    public static float Nspeed = 1;
    public static float Nattack = 1;

    public static int number;
    public static int[] list1 = new int[20];//type
    public static int[] list2 = new int[20];//index
    public static int[] index = {0,0,0,0};
    public static Weapon[] weapon=new Weapon[10];
    public static Jewelry[] jewelry = new Jewelry[10];
    public static Armor[] armors = new Armor[10];
    public static Shoes[] shoes = new Shoes[10];
}
