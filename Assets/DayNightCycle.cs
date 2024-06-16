using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public float dayLength = 60f;  // Duración de un ciclo día/noche en segundos

    private Light directionalLight;
    private float startTime;

    void Start()
    {
        directionalLight = GetComponent<Light>();
        startTime = Time.time;
    }

    void Update()
    {
        float elapsedTime = Time.time - startTime;
        float cycle = elapsedTime / dayLength; // Proporción del ciclo completado

        // Ajustar la intensidad y el color según el ciclo de día y noche
        directionalLight.intensity = Mathf.Lerp(0.2f, 1.0f, Mathf.PingPong(cycle, 1f));
        directionalLight.color = Color.Lerp(Color.blue, Color.red, Mathf.PingPong(cycle, 1f));
    }
}
