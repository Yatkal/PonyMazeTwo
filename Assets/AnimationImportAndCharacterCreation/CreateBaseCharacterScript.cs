using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreateBaseCharacterScript : MonoBehaviour {

    public GameObject character;
    public GameObject head;

	// Use this for initialization
	void Start () {
        GameObject temp = Instantiate((GameObject)Resources.Load("Models/SoriaModel"));
        character = temp;
        character.transform.parent = gameObject.transform;
        GameObject temp2 = Instantiate((GameObject)Resources.Load("Models/Octavia"));
        head = temp2;
        ApplyBaseMaterials();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void ApplyBaseMaterials()
    {
        Material[] materials;

        materials = character.transform.FindChild("Reference").GetComponent<Renderer>().materials;

        for(int iter = 0; materials.Length > iter; iter++)
        {
            if(materials[iter].name == "body (Instance)")
            {
                materials[iter].mainTexture = (Texture)Resources.Load("Models/Materials/B_Octavia");
                materials[iter].color = Color.white;
            }
            else if (materials[iter].name == "Privates (Instance)")
            {
                materials[iter].mainTexture = (Texture)Resources.Load("Models/Materials/P_Octavia");
                materials[iter].color = Color.white;
            }
            else if (materials[iter].name == "Arms (Instance)")
            {
                materials[iter].mainTexture = (Texture)Resources.Load("Models/Materials/A_Octavia");
                materials[iter].color = Color.white;
            }
        }

        Material[] headMaterials;
        Material[] hairMaterial;
        Material[] tailMaterial;
        headMaterials = head.transform.FindChild("Reference").GetComponent<Renderer>().materials;
        hairMaterial = head.transform.FindChild("Hair").GetComponent<Renderer>().materials;
        tailMaterial = head.transform.FindChild("Hair").GetComponent<Renderer>().materials;

        for(int iter = 0; headMaterials.Length > iter; iter++)
        {
            if (materials[iter].name == "body (Instance)")
            {
                headMaterials[iter].mainTexture = (Texture)Resources.Load("Models/Materials/H_Octavia");
                headMaterials[iter].color = Color.white;
            }
            else if (materials[iter].name == "tongue (Instance)")
            {
                headMaterials[iter].mainTexture = (Texture)Resources.Load("Models/Materials/Generic_Tongue");
                headMaterials[iter].color = Color.white;
            }
            else if (materials[iter].name == "tongue (Instance)")
            {
                headMaterials[iter].mainTexture = (Texture)Resources.Load("Models/Materials/Generic_Tongue");
                headMaterials[iter].color = Color.white;
            }

        }
    }
}
