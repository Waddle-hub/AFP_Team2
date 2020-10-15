using System;

public class Items
{
    public Items(string id, int quantity, double price, string name, string category)
    {
        this.id = id;
        this.quantity = quantity;
        this.price = price;
        this.name = name;
        this.category = category;
    }

    private string id;
    public string Id
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
        }

    }

    private string name;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    private int quantity;
    public int Quantity
    {
        get
        {
            return quantity;
        }
        set
        {
            quantity = value;
        }
    }

    private double price;
    public double Price
    {
        get
        {
            return price;
        }
        set
        {
            price = value;
        }
    }

    private string category;
    public string Category
    {
        get
        {
            return category;
        }
        set
        {
            category = value;
        }
    }

}