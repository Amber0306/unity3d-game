using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ShowTip : MonoBehaviour
{
    public CanvasGroup tips;    
    
    public void show(string str)
    {
        ShowTips(tips, str);
    }

    private void ShowTips(CanvasGroup tipCanvasGroup, string msg)
    {
        tipCanvasGroup.GetComponentInChildren<Text>().text = msg;
      
        tipCanvasGroup.alpha = 0.1f;
        DOTween.Kill(tipCanvasGroup);
        Sequence sequence = tipCanvasGroup.DOSequence();
        sequence.Append(tipCanvasGroup.DOFade(1, 0.8f));
        sequence.AppendInterval(2.0f);
        sequence.Append(tipCanvasGroup.DOFade(0, 1.0f));
    }
}

public static class GameObjExt
{
    public static Sequence DOSequence(this UnityEngine.Object seq)
    {
        Sequence sequence = DOTween.Sequence();
        sequence.target = seq;

        return sequence;
    }
}
