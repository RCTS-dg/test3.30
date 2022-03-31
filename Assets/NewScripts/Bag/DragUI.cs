using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class DragUI : Button, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private Transform beginParentTransform;
    private Transform topOfUiT;

    int x;
    protected override void Start()
    {
        topOfUiT = GameObject.Find("Canvas").transform;

    }


    public void OnBeginDrag(PointerEventData eventData)
    {

        if (transform.parent == topOfUiT) return;
        beginParentTransform = transform.parent;
        transform.SetParent(topOfUiT);
    }


    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
        if (transform.GetComponent<Image>().raycastTarget) transform.GetComponent<Image>().raycastTarget = false;
    }


    public void OnEndDrag(PointerEventData eventData)
    {
        GameObject go = eventData.pointerCurrentRaycast.gameObject;
        transform.GetComponent<Image>().raycastTarget = true;
        if (go.tag == "Grid") //并不会发生这个
        {
            SetPosAndParent(transform, go.transform);
        }
        else if (go.tag == "Thing") //如果是物品
        {
            Transform GoParent = go.transform.parent;
            SetPosAndParent(go.transform, beginParentTransform);
            SetPosAndParent(transform, GoParent);
        }
        else if (go.tag == "Gweapon" && ISORNOT(1)) //如果是武器
        {
            SetPosAndParent(transform, go.transform);
        }
        else if (go.tag == "Gjewelry" && ISORNOT(2)) //如果是饰品
        {
            SetPosAndParent(transform, go.transform);
        }
        else if (go.tag == "Garmor" && ISORNOT(3)) //如果是装甲
        {
            SetPosAndParent(transform, go.transform);
        }
        else if (go.tag == "Gshoes" && ISORNOT(4)) //如果是鞋子
        {
            SetPosAndParent(transform, go.transform);
        }
        else if (go.tag == "Rubbish")
        {
            this.image.sprite = Resources.Load("nope", typeof(Sprite)) as Sprite;
            SetPosAndParent(transform, beginParentTransform);
        }
        else //其他任何情况，物体回归原始位置
        {
            SetPosAndParent(transform, beginParentTransform);
        }
    }


    private void SetPosAndParent(Transform t, Transform parent)
    {
        t.SetParent(parent);
        t.position = parent.position;
    }

    bool ISORNOT(int th)
    {

        Transform[] myTransforms = GetComponentsInChildren<Transform>();
        switch (myTransforms[0].name)
        {
            case "test0":
                x = 0;
                break;
            case "test1":
                x = 1;
                break;
            case "test2":
                x = 2;
                break;
            case "test3":
                x = 3;
                break;
            case "test4":
                x = 4;
                break;
            case "test5":
                x = 5;
                break;
            case "test6":
                x = 6;
                break;
            case "test7":
                x = 7;
                break;
            case "test8":
                x = 8;
                break;
            case "test9":
                x = 9;
                break;
            default:
                x = -1;
                break;
        }
        switch (th)
        {
            case 1:
                if (TotalData.list1[x]==1)
                {
                    return true;
                }
                break;
            case 2:
                if (TotalData.list1[x] == 2)
                {
                    return true;
                }
                break;
            case 3:
                if (TotalData.list1[x] == 3)
                {
                    return true;
                }
                break;
            case 4:
                if (TotalData.list1[x] == 4)
                {
                    return true;
                }
                break;
            default:
                break;
        }
        return false;
    }
}