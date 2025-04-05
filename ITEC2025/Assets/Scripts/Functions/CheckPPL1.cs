using UnityEngine;

public class CheckPPL1 : MonoBehaviour
{
    public static bool inRangeG = false;
    public static bool inRangeV = false;
    public static bool isOpen = false;
    void Update()
    {
        if (inRangeG && inRangeV && !isOpen)
        {
            isOpen = true;
        }
    }
}
