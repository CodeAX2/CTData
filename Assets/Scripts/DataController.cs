using UnityEngine;

public class DataController : MonoBehaviour {

	/// <summary>
	/// Instance of DataLoader to handle loading data from the file
	/// </summary>
	public DataLoader DataLoader { get; private set; }

	/// <summary>
	/// Name of the file to use when loading data
	/// </summary>
	public string FileName;

	public void Awake() {
		// Create an instance of DataLoader so we don't load the data multiple times
		DataLoader = new DataLoader(FileName);
		DataLoader.LoadData();
	}
}