

using System.Collections.Generic;

public static class Myconst 
{
    static Myconst()
    {
        ItemPath = new Dictionary<MyEnum.ItemType, string>
        {
            {MyEnum.ItemType.None,"Item/None"},
        };
    }

    public static Dictionary<MyEnum.ItemType,string> ItemPath;
}
