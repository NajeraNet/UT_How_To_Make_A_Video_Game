using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    // tomamos la posision de player
    public Transform player;
    // offset para acomodar la carmara y que no quede en el centro
    public Vector3 offset;

	// Update is called once per frame
	void Update () {
        // iguala la posision del jugador y se la asigna a la camara con "transform.position"
        transform.position = player.position + offset;
	}
}
