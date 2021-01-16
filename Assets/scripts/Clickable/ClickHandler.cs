using UnityEngine;
using UnityEngine.InputSystem;

public class ClickHandler : MonoBehaviour
{
    void Update()
    {
        if (Mouse.current.press.wasPressedThisFrame)
        {
            Vector2 v = Camera.main.ScreenPointToRay(new Vector3(Mouse.current.position.x.ReadValue(), Mouse.current.position.y.ReadValue(), Camera.main.nearClipPlane)).origin;
            RaycastHit2D hit;
            hit = Physics2D.Raycast(v, new Vector2(0, 0));
            if (hit != default(RaycastHit2D))
            {
                GameObject o = hit.transform.gameObject;
                Clickable clickable = o.GetComponent<Clickable>();
                if (clickable != default(Clickable))
                {
                    clickable.click();
                    
                }
            }
        }
    }
}
