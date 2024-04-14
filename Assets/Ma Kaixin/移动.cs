using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 移动 : MonoBehaviour
{
    public float moveSpeed = 1f;

    private AudioSource audioSource;
    public Text num;
    public GameObject shengli;
    private int fen;
    // Start is called before the first frame update
    void Start()
    {
        // 获取 AudioSource 组件
        audioSource = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        // 获取WASD键的输入
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // 计算移动方向
        Vector3 moveDirection = new Vector3(-horizontalInput, 0f, -verticalInput).normalized;

        // 根据输入移动人物
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        // 如果按下WASD中的任何键并且音效没有正在播放
        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) && !audioSource.isPlaying)
        {
            audioSource.Play(); // 播放音效
        }

        if (fen == 40)
        {
            shengli.SetActive(true);
        }
        // 这里添加控制玩家移动的代码
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
         
            fen += 10;
            num.text = fen.ToString();
            Destroy(other.gameObject);
        }

    }
}
