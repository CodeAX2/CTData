using System.IO;
using UnityEngine;

/// <summary>
/// Represents a data loader for 3D function data stored in a file
/// </summary>
public class DataLoader {

	/// <summary>
	/// Name of file to load data from
	/// </summary>
	private string FileName { get; set; }

	/// <summary>
	/// 3D array of data loaded from file
	/// </summary>
	private float[,,] Data { get; set; }

	/// <summary>
	/// If the data has been loaded from the file
	/// </summary>
	private bool Loaded { get; set; }

	/// <summary>
	/// Creates a new DataLoader to load function data from a file
	/// </summary>
	/// <param name="fileName">Name of the file to load data from</param>
	public DataLoader(string fileName) {
		FileName = fileName;
		Loaded = false;
	}

	/// <summary>
	/// Load or retrieve previously loaded data from the file
	/// </summary>
	/// <returns>3D array indexed by (x,y,z) containing function data</returns>
	public float[,,] LoadData() {
		// Check if data is already loaded
		if (!Loaded) {
			using (StreamReader sr = new StreamReader(FileName)) {
				// Read the dimensions of x,y,z
				int xSize = int.Parse(sr.ReadLine());
				int ySize = int.Parse(sr.ReadLine());
				int zSize = int.Parse(sr.ReadLine());

				// Empty line
				sr.ReadLine();

				// Create array
				Data = new float[xSize, ySize, zSize];

				// Load data
				for (int x = 0; x < xSize; x++) {
					// One line for each x-coordinate
					string[] line = sr.ReadLine().Split(',');
					int idx = 0;
					// z-values clustered together, then y-values
					for (int y = 0; y < ySize; y++) {
						for (int z = 0; z < zSize; z++) {
							Data[x, y, z] = int.Parse(line[idx]);
							idx++;
						}
					}
				}
				Loaded = true;
				Debug.Log("Data loaded!");
			}
		}
		return Data;
	}
}