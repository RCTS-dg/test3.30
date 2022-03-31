using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pp : MonoBehaviour
{

    public int number = 1;
    public Text Rpost;
    public Text Bpost;

    private Transform trans;
    public GameObject Teleport;
    private Transform tankTrans;

    private GameObject A;
    // Start is called before the first frame update
    void Start()
    {
        if (number==1)
        {
            tankTrans = transform.Find("tankTrans");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (number==1)
        {

            if (Input.GetKeyDown((KeyCode)TotalValue.RedDraw) && TotalValue.Rpp < 25 && TotalValue.RleaderNum == 2)//�������ֵ�˲�Ƽ���
            {
                if (TotalValue.FirstTeleport)
                {
                    A = GameObject.Instantiate(Teleport, tankTrans.position, tankTrans.rotation) as GameObject;
                    TotalValue.FirstTeleport = false;
                }
                else if (!TotalValue.FirstTeleportOver)
                {
                    //trans = transform.Find("A");
                    gameObject.transform.position = A.transform.position;
                    TotalValue.FirstTeleportOver = true;
                    A.SetActive(false);
                }
            }

            if (Input.GetKeyDown((KeyCode)TotalValue.RedDraw)&&TotalValue.Rpp>=25)
            {
                TotalValue.Rpp -= 25;
                switch (Random.Range(1, 7))
                {
                    case 1:
                        TotalValue.RStability += 20;
                        Rpost.text = "�ȶ���+20";
                        break;
                    case 2:
                        TotalValue.RStability += 10;
                        Rpost.text = "�ȶ���+10";
                        break;
                    case 3:
                        if (TotalValue.RdefendValue<9)
                        {
                            TotalValue.RdefendValue += 1;
                            Rpost.text = "����+1(��������Ϊ9)";
                        }
                        break;

                    default:
                        Rpost.text = "���·���(50%����)";
                        break;
                }
            }


        }
        else
        {
            if (Input.GetKeyDown((KeyCode)TotalValue.BlueDraw) && TotalValue.Bpp >= 25)
            {
                TotalValue.Bpp -= 25;
                switch (Random.Range(1, 7))
                {
                    case 1:
                        TotalValue.BStability += 20;
                        Bpost.text = "�ȶ���+20";
                        break;
                    case 2:
                        TotalValue.BStability += 10;
                        Bpost.text = "�ȶ���+10";
                        break;
                    case 3:
                        if (TotalValue.BdefendValue < 9)
                        {
                            TotalValue.BdefendValue += 1;
                            Bpost.text = "����+1(��������Ϊ9)";
                        }
                        break;

                    default:
                        Bpost.text = "���·���(50%����)";
                        break;
                }
            }
        }
    }
}
