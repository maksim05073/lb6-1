using System.Text.RegularExpressions;

namespace lb6;

public class Ware
{
    public string nameware;
    public string nameplace;
    public double price;
    public string NameWare
    {
        get => nameware;
        set => nameware = value;
    }
    public string NamePlace
    {
        get => nameplace;
        set => nameplace = value;
    }
    public double Price
    {
        get => price;
        set
        {
            if (value < 0) throw new ArgumentException("Price cannot be negative");
            price = value;
        }
    }
    public override string ToString()
    {
        return "NameWare"+' '+nameware+" \nnameplace"+' '+nameplace+"\nPrice"+' '+price;
    }
    public override bool Equals(object a)
    {
        if (a is Ware d)
        {
            return GetHashCode() == d.GetHashCode();
        }
        return false;
    }
    public override int GetHashCode()
    {
        //return HashCode.Combine(nameware, nameplace, price);
        return ToString().GetHashCode();
    }
}