using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameObject Instance;
    NickNameController nickNameController;
    [SerializeField] Text Time;

    [SerializeField] Sprite catImageSprite;
    [SerializeField] Sprite penguinImageSprite;

    [SerializeField] Image CharacterChoiceImage;
    [SerializeField] GameObject PlayerImage;

    [SerializeField] AnimatorController catAnimator;
    [SerializeField] AnimatorController penguinAnimator;


    [SerializeField] GameObject Panel;
    [SerializeField] GameObject CharacterChoicePanel;
    [SerializeField] GameObject ChangeNicknameButton;

    private void Start() {
        if(Instance == null){
            Instance = this.gameObject;
        }else{
            Destroy(this.gameObject);;
        }
        nickNameController = GetComponent<NickNameController>();
    }

    //시간 표시
    private void Update(){
        Time.text = DateTime.Now.ToString(("HH:mm"));
    }

    //닉네임 입력, 패널닫고 게임시작
    public void ClickButton(){
        nickNameController.CheckNickName();
        ChangeNicknameButton.SetActive(true);
        Panel.SetActive(false);
    }
    //캐릭터선택창으로 돌아간다.
    public void CharacterChoice(){
        CharacterChoicePanel.SetActive(true);
    }
    //닉네임입력 창으로 돌아간다.
    public void BackLoginPanel(){
        CharacterChoicePanel.SetActive(false);
        //클릭된 버튼의 게임오브젝트를 가져온다.
        GameObject eventButtonOb = EventSystem.current.currentSelectedGameObject;
        SetImage(eventButtonOb);
         
    }
    //선택한 이미지, 컨트롤러 변경
    private void SetImage(GameObject obj)
    {
        if(obj.name=="Cat"){
            CharacterChoiceImage.sprite= catImageSprite;
            PlayerImage.GetComponent<SpriteRenderer>().sprite= catImageSprite;
            PlayerImage.GetComponent<Animator>().runtimeAnimatorController = catAnimator;
        }else{
            CharacterChoiceImage.sprite = penguinImageSprite;
            PlayerImage.GetComponent<SpriteRenderer>().sprite = penguinImageSprite;
            PlayerImage.GetComponent<Animator>().runtimeAnimatorController = penguinAnimator;
        }
    }

    
}
