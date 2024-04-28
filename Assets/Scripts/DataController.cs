using UnityEngine;

public class DataController : MonoBehaviour {

	public DataLoader DataLoader { get; private set; }
	public string FileName;

	public void Awake() {
		DataLoader = new DataLoader(FileName);
		DataLoader.LoadData();
	}
}