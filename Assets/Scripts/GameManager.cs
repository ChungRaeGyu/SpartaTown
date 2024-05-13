using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameObject Instance;
    public InputField input;
    public Text nickname;
    private string name;
    [SerializeField] GameObject Panel;
    private void Start() {
        if(Instance == null){
            Instance = this.gameObject;
        }else{
            Destroy(this.gameObject);;
        }
    }
    
    public void ClickButton(){
        name = input.text;
        Debug.Log(name.Length);
        if(name.Length>=2&& name.Length<=10){
            Panel.SetActive(false);
            nickname.text = name;
        }
        
    }
}
