using UnityEngine;

[CreateAssetMenuAttribute(fileName = "New Unit", menuName = "Scriptable Unit")]

public class ScriptableUnit : ScriptableObject
{

    public Faction faction;

    public enum Faction{

        Player,
        Enemy

    }

}
