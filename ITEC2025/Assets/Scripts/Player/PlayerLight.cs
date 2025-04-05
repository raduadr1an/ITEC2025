using UnityEngine;
using UnityEngine.Rendering.Universal;

public class PlayerLight : MonoBehaviour
{
    private Light2D light2D;
    public float lightValue;

    void Start()
    {
        light2D = gameObject.GetComponent<Light2D>();
        if (light2D == null)
        {
            light2D = gameObject.AddComponent<Light2D>();
        }

        light2D.lightType = Light2D.LightType.Point;
        light2D.pointLightOuterRadius = lightValue;
        light2D.intensity = 1.5f;
        light2D.color = Color.white;
    }
}
