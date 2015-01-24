using UnityEngine;
using System.Collections;

public class LevelBuilder : MonoBehaviour {

	public GameObject Wall;
	public GameObject BoxDestructible;
	public GameObject BoxMovable;
	public GameObject Grass;

	public GameObject DoorOpen;
	public GameObject Stairs;

	public Vector2 topLeft;
	public TextAsset levelAsset;

	// Use this for initialization
	void Start () {
		// TODO read from asset
		string[] data = levelAsset.ToString ().Split ("\n"[0]);

		GameObject block;

		for (int y = 0; y < data.Length; y++) {
			string line = data[y];
			for(int x = 0; x < line.Length; x++) {
				block = null;

				switch(line[x]) {
				case 'w':
 					block = (GameObject)(Instantiate(Wall));
					block.transform.position = new Vector3(topLeft.x + x*2, topLeft.y - y*2, 0);
					break;
				case 'b':
					block = (GameObject)(Instantiate(BoxDestructible));
					block.transform.position = new Vector3(topLeft.x + x*2, topLeft.y - y*2, 0);
					break;
				case 'm':
					block = (GameObject)(Instantiate(BoxMovable));
					block.transform.position = new Vector3(topLeft.x + x*2, topLeft.y - y*2, 0);
					break;
				case 'g':
					block = (GameObject)(Instantiate(Grass));
					block.transform.position = new Vector3(topLeft.x + x*2, topLeft.y - y*2, 0);
					break;

				case 'd':
					block = (GameObject)(Instantiate(DoorOpen));
					block.transform.position = new Vector3(topLeft.x + x*2, topLeft.y - y*2, 0);
					break;
				case 's':
					block = (GameObject)(Instantiate(Stairs));
					block.transform.position = new Vector3(topLeft.x + x*2, topLeft.y - y*2, 0);
					break;
				case 'S':
					block = (GameObject)(Instantiate(Stairs));
					block.transform.position = new Vector3(topLeft.x + x*2, topLeft.y - y*2, 0);
					block.transform.localScale = new Vector3(-1, 1, 1);
					break;
				// TODO more types?
				default:
					block = null;
					break;
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
