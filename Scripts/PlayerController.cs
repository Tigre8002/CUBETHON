using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody RB;

    public int forwardForce;
    public int sidewaysForce;

    void Start() {
        RB = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        RB.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            RB.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.A))
        {
            RB.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (RB.position.y < -1f)
        {
            GameManager.EndGame();
        }
    }
}
