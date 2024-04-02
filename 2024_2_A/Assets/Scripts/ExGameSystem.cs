using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Item
{
    private int index;
    private string name;
    private ItemType type;
    private Sprite image;

    public int Index
    {
        get { return Index; }
        set {index = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public ItemType Type
    {
        get { return type; }
        set { type = value; }
    }

    public Sprite Image
    {
        get { return Image; }
        set { Image = value; }
    }

    public Item(int index, string name, ItemType type)
    {
        this.index = index;
        this.name = name;
        this.type = type;
    }
}



public enum ItemType
{
        Weapon,
        Armor,
        Potion,
        QucstItem
}


public class Inventory
{
    private Item[] items = new Item[16];

    public Item this[int index]
    {
        get { return items[index]; }
        set { items[index] = value;  }
    }

    public int ItemCount
    {
        get
        {
            int count = 0;
            foreach(Item item in items)
            {
                if (item != null) count++;
            }
            return count;
        }
    }

    public bool AddItem(Item item)
    {
        for(int i = 0; i < items.Length; i++)
        {
            if(items[i] == null)
            {
               items[i] = item;
               return true;
            }
        }
        return false;
    }

    public void RemoveItem(Item item)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == item)
                break;
        }
    }
}

public class ExGameSystem : MonoBehaviour
{
    private Inventory inventory = new Inventory();

    void Start()
    {
        Item sword = new Item(0, "Sword", ItemType.Weapon);
        Item shield = new Item(100, "shield", ItemType.Armor);



        inventory.AddItem(sword);
        inventory.AddItem(shield);
        Debug.Log("Player Inventory : " + GetInventoryAsString());
    }

    private string GetInventoryAsString()
    {
        string resurlt = "";
        for(int i =0; i < inventory.ItemCount; i++)
        {
            if(inventory[i] != null)
            {
                resurlt += inventory[i].Name + ",";
            }
        }
        return resurlt.TrimEnd(',');
    }

}