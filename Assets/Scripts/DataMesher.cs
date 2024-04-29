using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DataMesher : MonoBehaviour {

	/// <summary>
	/// Resolution scale to use for marching cubes
	/// </summary>
	public int ResolutionScale = 10;

	/// <summary>
	/// Surface value to use for marching cubes
	/// </summary>
	public float SurfaceValue = 0;

	/// <summary>
	/// Instance of marching cubes algorithm
	/// </summary>
	private MarchingCubes marchingCubes;

	/// <summary>
	/// Controller to access data from
	/// </summary>
	public DataController DataController;


	// Start is called before the first frame update
	void Start() {

		// Obtain the data
		float[,,] data = DataController.DataLoader.LoadData();

		// Initialize marching cubes
		marchingCubes = new MarchingCubes(ResolutionScale, SurfaceValue);

		// Perform marching cubes
		List<Vector3> vertices = new List<Vector3>();
		List<int> indices = new List<int>();
		marchingCubes.MarchAll(data, vertices, indices);

		// Create the mesh for Unity to render
		Mesh mesh = new Mesh();
		mesh.indexFormat = IndexFormat.UInt32;
		mesh.SetVertices(vertices);
		mesh.SetTriangles(indices, 0);
		mesh.RecalculateNormals();
		mesh.RecalculateBounds();

		MeshFilter meshFilter = gameObject.AddComponent<MeshFilter>();
		gameObject.AddComponent<MeshRenderer>();
		GetComponent<Renderer>().material =
			new Material(Shader.Find("Standard"));
		meshFilter.mesh = mesh;
	}
	
}
