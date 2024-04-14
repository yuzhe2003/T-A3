using UnityEngine;

public class 碰撞 : MonoBehaviour
{
   private void OnCollisionEnter(Collision collision)
   {
    if(collision.gameObject.tag == "1.1")
    Destroy(gameObject);
   }
}
