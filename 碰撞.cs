
using UnityEngine;
using UnityEngine.UI;
public class 碰撞 : MonoBehaviour
{
    public move movement;
    public Text score;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "障碍")
        {
            movement.enabled = false;
        }
    }



}