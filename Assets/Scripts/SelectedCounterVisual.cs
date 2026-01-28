using UnityEditor.Search;
using UnityEngine;

public class SelectedCounterVisual : MonoBehaviour
{
    [SerializeField]
    private BaseCounter baseCounter;

    [SerializeField]
    private GameObject[] visualGameObjects;

    private void Start()
    {
        Player.Instance.OnSelectedCounterChanged += Instance_OnSelectedCounterChanged;
    }

    private void Instance_OnSelectedCounterChanged(object sender, Player.OnSelectedCounterChangedeventArgs e)
    {
        if (baseCounter == e.selectedCounter)
        {
            Show();
        }
        else
        {
            Hide();
        }
    }

    private void Show()
    {
        foreach(var visualGameObject in visualGameObjects)
        {
            visualGameObject.SetActive(true);
        }
    }
    private void Hide()
    {
        foreach (var visualGameObject in visualGameObjects)
        {
            visualGameObject.SetActive(false);

        }
    }
}
