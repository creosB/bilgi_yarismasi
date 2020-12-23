using UnityEngine.UI;
using UnityEngine;

public class Menu : MonoBehaviour {
	public Canvas menu;
	public Canvas _ayarlar;

	public void Basla(string basla){
		Application.LoadLevel(1);
	}
	public void Ayarlar(string ayarlar){
		menu.enabled = false;
		_ayarlar.enabled = true;
	}
	public void Cikis () {
		Application.Quit ();
	 }
}
