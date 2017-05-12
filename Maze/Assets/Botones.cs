using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour {

	public void LoadByIndex(int sceneIndex){
		SceneManager.LoadScene (sceneIndex);
	}

}
