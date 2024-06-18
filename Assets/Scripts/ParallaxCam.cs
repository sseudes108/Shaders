using UnityEngine;

public class ParallaxCam : MonoBehaviour{

    public float Speed;

    private void Update() {
        transform.position += Speed * Time.deltaTime * new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0f);
    }
}