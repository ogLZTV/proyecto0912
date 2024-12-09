using UnityEngine;

abstract public class Interactive : MonoBehaviour
{
    protected bool interactive;
    protected void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            interactive = true;
        }
    }
    protected void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            interactive = false;
        }
    }
}
