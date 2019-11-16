
using UnityEngine;

public class Chicken : MonoBehaviour
{
  

    [Header("移動速度"), Range(1, 100)]
    public int speed = 1;

    [Header("跳躍高度"), Range(1, 2000)]
    public float jump = 1;
    [Header("對話內容")]
        public string talk = "咕咕";
    [Header("是否取得雞蛋")]
    public bool mission = true;

    public int count = 0;

    private void Start()
    {
        print("遊戲開始!!!");
    }

    private void Update()
    {
        print("咕咕咕咕咕咕咕咕咕咕咕");

    }

}

  