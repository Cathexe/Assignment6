using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject editDeletePanel;
    public GameObject searchPanel;
    public GameObject createPanel;

    public void MainMenu()
    {
        menuPanel.SetActive(true);
        editDeletePanel.SetActive(false);
        searchPanel.SetActive(false);
        createPanel.SetActive(false);
    }
    public void Edit()
    {
        menuPanel.SetActive(false);
        editDeletePanel.SetActive(true);
        searchPanel.SetActive(false);
        createPanel.SetActive(false);
    }
    public void Search()
    {
        menuPanel.SetActive(false);
        editDeletePanel.SetActive(false);
        searchPanel.SetActive(true);
        createPanel.SetActive(false);
    }
    public void Create()
    {
        menuPanel.SetActive(false);
        editDeletePanel.SetActive(false);
        searchPanel.SetActive(false);
        createPanel.SetActive(true);
    }

}
