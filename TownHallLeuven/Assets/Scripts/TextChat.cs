using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextChat : MonoBehaviour
{
    public bool ActText;
    public GameObject Canvas;
    public int Character;
    public Text txt;
    public Text txtName;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ActText)
        {
            Canvas.SetActive(false);
        }
        else
        {
            Canvas.SetActive(true);
        }
        if (Character == 1)
        {
            txt.text = "Hey, you! I may only be 15 now, but one day I will be the king. Look at the statue on the townhall, that's me! I'm gonna be the greatest ruler!";
            txtName.text = "Leopold II of Belgium";
        }
        else
        {
            txt.text = "";
            txtName.text="";
        }
    }
}
