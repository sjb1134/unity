
using UnityEngine;
using UnityEngine.UI;

public class 分数 : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform cube;
    public Text score;

    // Update is called once per frame
    void Update()
    {
        score.text = cube.position.z.ToString("0");
     
    }

}
