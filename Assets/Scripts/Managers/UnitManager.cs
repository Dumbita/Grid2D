using UnityEngine;

public class UnitManager : MonoBehaviour
{
   
    public static UnitManager Instance;

    private void Awake()
    {

        Instance = this;

    }

}
