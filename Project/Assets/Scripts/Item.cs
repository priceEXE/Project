using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private int maxHp;
    public int MaxHp {get{return maxHp;} set{maxHp = value;}}
    private int movingSpeed;
    public int MovingSpeed {get{return movingSpeed;} set{movingSpeed = value;}}

}
