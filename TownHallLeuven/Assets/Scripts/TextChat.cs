using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextChat : MonoBehaviour
{
    public bool ActText;
    public GameObject Canvas;
    public int Character;
    public int Conversation;
    public Text txt;
    public Text txtName;
    public Text Option1;
    public Text Option2;
    public Text Option3;
    public Button button1;
    public Button button2;
    public Button button3;

    // Start is called before the first frame update
    void Start()
    {
        Button btn1 = button1.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick1);
        Button btn2 = button2.GetComponent<Button>();
        btn2.onClick.AddListener(TaskOnClick2);
        Button btn3 = button3.GetComponent<Button>();
        btn3.onClick.AddListener(TaskOnClick3);
    }

    // Update is called once per frame
    void Update()
    {
        if (!ActText)
        {
            Canvas.SetActive(false);
        }
        else
        {
            Canvas.SetActive(true);
        }
        if (Character == 1)
        {
            if (Conversation ==0 )
            {
                txt.text = "Hey, you! I may only be 15 now, but one day I will be the king. Look at the statue on the townhall, that's me! I'm gonna be the greatest ruler!";
                txtName.text = "Leopold II of Belgium";
                Option1.text = "Ok.";
                Option2.text = "I'mma cut your head off.";
                Option3.text = "Can you tell me more about you?";
            }
            if (Conversation == 1)
            {
                txt.text = "I'm the son of Leopold the first, the founder of this country. This is my mother, she's very sick, but I help her as well as I can.";
                txtName.text = "Leopold II of Belgium";
                Option1.text = "Ok.";
                Option2.text = "Ok.";
                Option3.text = "Ok.";
            }
        }
        else if (Character == 2)
        {
            if (Conversation == 0)
            {
                txt.text = "My son is really arrogant and energetic, but he's a good boy. He's taking good care of me, since I'm very sick.";
                txtName.text = "Louise Marie of Belgium";
            }
        }
        else if (Character == 3)
        {
            if (Conversation == 0)
            {
                txt.text = "A while back I wrote a letter to the city of Leuven about those niches. That is what pushed them to finally build those statues. Look, they're finally up.";
                txtName.text = "Victor Hugo";
            }
        }
        else
        {
            txt.text = "";
            txtName.text = "";
        }

    }
    void TaskOnClick1()
    {
        if (Character == 1)
        {
            if (Conversation == 0)
            {
                ActText = false;
            }
            else if (Conversation == 1)
            {
                ActText = false;
            }
        }
    }
    void TaskOnClick2()
    {
        if (Character == 1)
        {
            if (Conversation == 0)
            {
                ActText = false;
            }
            else if (Conversation == 1)
            {
                ActText = false;
            }
        }
    }
    void TaskOnClick3()
    {
        if (Character == 1)
        {
            if (Conversation == 0)
            {
                Conversation = 1;
            }
            else if (Conversation == 1)
            {
                ActText = false;
            }
        }
    }
}