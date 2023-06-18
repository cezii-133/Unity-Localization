using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class GetWorld : MonoBehaviour
{
    [SerializeField] private int _wordCount;
    private Text _thisWorldText;
    private void Start()
    {
        _thisWorldText = this.GetComponent<Text>();
        _thisWorldText.text = LanguageManager.Words[_wordCount];
    }

   
}
