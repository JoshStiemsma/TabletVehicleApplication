using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextBox : MonoBehaviour {
    public Text Title, MainText,SubTitle;
    TextBox(string _Title,string _SubTitle,string _MainText)
    {
        UpdateData(_Title, _SubTitle, _MainText);
    }
    public void UpdateData(string _Title,string _Subtitle, string _MainText)
    {

        Title.text = _Title;
        MainText.text = _MainText;
        SubTitle.text = _Subtitle;
    }
}
