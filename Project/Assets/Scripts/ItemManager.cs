using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    private static ItemManager _instance;

    private ItemManager()
    {
        
    }
    //单例访问模式
    public static ItemManager Instance
    {
        get
        {
            if(_instance == null)   
            {
                _instance = new ItemManager();
            }
            return _instance;
        }
    }

    private List<Item> currnetItem;

    public void InsertItem(Item item)
    {
        currnetItem.Add(item);
    }

    public void RemoveItem(Item item)
    {
        currnetItem.Remove(item);
    }
}
