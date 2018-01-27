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
        //head.transform.parent.position = new Vector3(-0.1f, -1.4f, -17.03f);
        head.transform.parent = gameObject.transform;
        ApplyBaseMaterials();

        gameObject.AddComponent<AnimationLinkScript>();
        Destroy(this);
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
        tailMaterial = head.transform.FindChild("Tail").GetComponent<Renderer>().materials;

        for(int iter = 0; headMaterials.Length > iter; iter++)
        {
            if (headMaterials[iter].name == "body (Instance)")
            {
                headMaterials[iter].mainTexture = (Texture)Resources.Load("Models/Materials/H_Octavia");
                headMaterials[iter].color = Color.white;
            }
            else if (headMaterials[iter].name == "tongue (Instance)")
            {
                headMaterials[iter].mainTexture = (Texture)Resources.Load("Models/Materials/Generic_Tongue");
                headMaterials[iter].color = Color.white;
            }
            else if (headMaterials[iter].name == "teeth (Instance)")
            {
                headMaterials[iter].mainTexture = (Texture)Resources.Load("Models/Materials/Generic_Teeth");
                headMaterials[iter].color = Color.white;
            }
            else if (headMaterials[iter].name == "eyelashes (Instance)")
            {
                headMaterials[iter].mainTexture = (Texture)Resources.Load("Models/Materials/Generic_Eyelashes");
                headMaterials[iter].color = Color.white;
            }
            else if (headMaterials[iter].name == "eyeball_l (Instance)")
            {
                headMaterials[iter].mainTexture = (Texture)Resources.Load("Models/Materials/EL_Octavia");
                headMaterials[iter].mainTextureOffset = new Vector2(0.8f, -0.2f);
                headMaterials[iter].color = Color.white;
            }
            else if (headMaterials[iter].name == "eyeball_r (Instance)")
            {
                headMaterials[iter].mainTexture = (Texture)Resources.Load("Models/Materials/ER_Octavia");
                headMaterials[iter].mainTextureOffset = new Vector2(0.2f, -0.2f);
                headMaterials[iter].color = Color.white;
            }

        }

        for(int iter = 0; hairMaterial.Length > iter; iter++)
        {
            if (hairMaterial[iter].name == "hair (Instance)")
            {
                hairMaterial[iter].mainTexture = (Texture)Resources.Load("Models/Materials/HA_Octavia");
                hairMaterial[iter].color = Color.white;
            }
        }
        for (int iter = 0; tailMaterial.Length > iter; iter++)
        {
            if (tailMaterial[iter].name == "tail (Instance)")
            {
                tailMaterial[iter].mainTexture = (Texture)Resources.Load("Models/Materials/TA_Octavia");
                tailMaterial[iter].color = Color.white;
            }
        }
    }
}
