using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public MyEnum.ItemType itemType;
    private int movingSpeed;
    public int MovingSpeed {get{return movingSpeed;} set{movingSpeed = value;}}

    public Collider2D collider2D;

    private List<MyEnum.ItemType> availableItem;

    public virtual void InitItem()
    {
        ItemManager.Instance.InsertItem(this);
    }

    public void DisableItem()
    {
        ItemManager.Instance.RemoveItem(this);
        Destroy(gameObject);
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        foreach (var item in availableItem)
        {
            if( item == collision.transform.GetComponent<Item>().itemType)
            {

            }
            
        }
    }

}
