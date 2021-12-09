
using UnityEngine;

public class 跟随 : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Player;
    public Vector3 pianli;

    // Update is called once per frame
    void Update()
    {
        transform.position = Player .position+pianli;

    }
}
