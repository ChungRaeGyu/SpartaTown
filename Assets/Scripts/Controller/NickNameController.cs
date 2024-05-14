using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NickNameController : MonoBehaviour
{
    [SerializeField] InputField input;
    [SerializeField] InputField Changeinput;
    [SerializeField] Text nickname;
    [SerializeField] GameObject ChangeNicknamePanel;

    private string name;
    // Start is called before the first frame update
    public void ChangeNickName(){
        ChangeNicknamePanel.SetActive(true);
    }
    public void SuccessChange(){
        if(CheckNickName(Changeinput))
            ChangeNicknamePanel.SetActive(false);
    }

    public bool CheckNickName()
    {
        name = input.text;
        if (name.Length >= 2 && name.Length <= 10)
        {
            nickname.text = name;
            return true;
        }else{
            input.text = "2~10글자만 됩니다.";
            return false;
        }
    }
    public bool CheckNickName(InputField input)
    {
        name = input.text;
        if (name.Length >= 2 && name.Length <= 10)
        {
            nickname.text = name;
            return true;
        }
        else
        {
            input.text = "2~10글자만 됩니다.";
            return false;
        }
    }
}
