using UnityEngine;
using UnityEngine.UI;

public class ControlSettings : MonoBehaviour
{
    [SerializeField] private Image _control_1;
    [SerializeField] private Image _control_2;

    private void Start()
    {
        int control = PlayerPrefs.GetInt("control", 1);
        if (control == 1)
            ChooseControl1();
        else
            ChooseControl2();
    }

    public void ChooseControl1()
    {
        //if (CanVibro) Vibration.VibrateIOS(ImpactFeedbackStyle.Medium);
        PlayerPrefs.SetInt("control", 1);
        _control_1.color = Color.green;
        _control_2.color = new Color(1, 1, 1, 1);
    }

    public void ChooseControl2()
    {
        //if (CanVibro) Vibration.VibrateIOS(ImpactFeedbackStyle.Medium);
        PlayerPrefs.SetInt("control", 2);
        _control_2.color = Color.green;
        _control_1.color = new Color(1, 1, 1, 1);
    }
}
