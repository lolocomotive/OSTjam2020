
using UnityEngine;

public class Lightswitch : MonoBehaviour, Clickable
{
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    public GameObject light5;
    public GameObject light6;
    public GameObject light7;
    public SpriteRenderer lswitch;
    public Sprite switchstate1;
    public Sprite switchstate2;

    public void click()
    {
        light1.gameObject.SetActive(!light1.gameObject.activeSelf);
        light2.gameObject.SetActive(!light2.gameObject.activeSelf);
        light3.gameObject.SetActive(!light3.gameObject.activeSelf);
        light4.gameObject.SetActive(!light4.gameObject.activeSelf);
        light5.gameObject.SetActive(!light5.gameObject.activeSelf);
        light6.gameObject.SetActive(!light6.gameObject.activeSelf);
        light7.gameObject.SetActive(!light7.gameObject.activeSelf);
        if (lswitch.sprite == switchstate1)
        {
            lswitch.sprite = switchstate2;
        }
        else
        {
            lswitch.sprite = switchstate1;
        }
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
