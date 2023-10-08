using OOPAdventure;

public abstract class Item
{
    public virtual string Name { get; set; }
    public bool SingleUse { get; set; }
    public bool CanTake { get; set; } = true;

    public virtual void Use(string Source)
    {
        throw new NotImplementedException();
    }

}