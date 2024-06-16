using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public float dayLength = 60f;  // Duraci�n de un ciclo d�a/noche en segundos

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
        float cycle = elapsedTime / dayLength; // Proporci�n del ciclo completado

        // Ajustar la intensidad y el color seg�n el ciclo de d�a y noche
        directionalLight.intensity = Mathf.Lerp(0.2f, 1.0f, Mathf.PingPong(cycle, 1f));
        directionalLight.color = Color.Lerp(Color.blue, Color.red, Mathf.PingPong(cycle, 1f));
    }
}
