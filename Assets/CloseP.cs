using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseP : MonoBehaviour
{  // 将此变量关联到您的“Panel2”面板
    public GameObject Panel2;

    // 此函数用于切换“Panel2”面板的显示和隐藏
    public void TogglePanel2()
    {
        // 检查“Panel2”是否已激活（即显示），并执行相反操作
        // 如果面板是显示的，则隐藏；如果面板是隐藏的，则显示
        Panel2.SetActive(!Panel2.activeSelf);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
