using UnityEngine;

public class CheckPPL1 : MonoBehaviour
{
    public static bool inRangeG = false;
    public static bool inRangeV = false;

    void Update()
    {
        if (inRangeG && inRangeV)
        {
            Debug.Log("bombombini gusini");
        }
    }
}
