using UnityEngine;
using UnityEngine.UI;

public class BagPicker : MonoBehaviour
{
    [SerializeField] private GameObject _picker;

    private void Start()
    {
        SetPickerPosition();
        int bestLevel = PlayerPrefs.GetInt("bestLevel", 1);
        if (int.Parse(gameObject.transform.GetChild(0).transform.name) <= bestLevel)
        {
            gameObject.GetComponent<Button>().enabled = true;
            gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            gameObject.transform.GetChild(1).gameObject.SetActive(false);
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            gameObject.GetComponent<Button>().enabled = false;
            gameObject.GetComponent<Image>().color = new Color(0.5f, 0.5f, 0.5f, 1);
        }
    }

    public void UseButton()
    {
        PlayerPrefs.SetInt("bagColor", int.Parse(gameObject.name));
        _picker.transform.SetParent(transform);
    }

    private void Update()
    {
        if (transform.childCount == 3) gameObject.GetComponent<Image>().color = new Color(0.5f, 0.7f, 1, 1);
        else gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 1);
    }

    private void SetPickerPosition()
    {
        int color = PlayerPrefs.GetInt("bagColor", 0);
        if (int.Parse(transform.name) == color) _picker.transform.SetParent(transform);
    }
}