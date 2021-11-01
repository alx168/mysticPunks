using UnityEngine;

public class Enemy
{
    public string type { get; }
    public string description { get; }
    public int hp { get; }
    public int agil { get; }
    public int soc { get; }
    public int xp { get; }

    public Enemy(string type, string description, int hp, int agil, int soc, int xp)
    {
        this.type = type;
        this.description = description;
        this.hp = hp;
        this.agil = agil;
        this.soc = soc;
        this.xp = xp;
    }
}
