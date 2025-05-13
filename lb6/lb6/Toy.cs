namespace lb6;
public class Toy:Ware
{
    public int old;
    public string madein;
    public string MadeIn
    {
        get => madein;
        set => madein = value;
    }
    public int Old
    {
        get => old;
        set => old = value;
    }
    public override string ToString()
    {
        return "NameWare"+' '+nameware+" \nnameplace"+' '+nameplace+"\nPrice"+' '+price+"\nOLd"+' '+old+"\nMade in"+' '+madein;
    }
    public override bool Equals(object a)
    {
        if (a is Toy d)
        {
            return GetHashCode() == d.GetHashCode();
        }
        return false;
    }
    public override int GetHashCode()
    {
        //return HashCode.Combine(base.GetHashCode(), old, madein);
        return ToString().GetHashCode();
    }
}