using UnityEngine;
using UnityEngine.InputSystem;

public class ButtonClick : MonoBehaviour
{
    public BallPreFab ballPreFab;

    void Update()
    {
        if (Touchscreen.current.press.wasPressedThisFrame)
        {
            BallPreFab ball = Instantiate(ballPreFab);

            ball.transform.localPosition = transform.position;
            ball.transform.rotation = Camera.main.transform.rotation;
            ball.GetComponent<Rigidbody>().AddForce(
            Camera.main.transform.forward * Random.Range(3200, 3700)
            );
        }
    }
}
