using UnityEngine;
using System.Collections;

using System.Collections.Generic;

public class AnimationLinkScript : MonoBehaviour {

    GameObject animation;
    GameObject thisObject;
    List<GameObject> listOfChildrenOfModel;
    List<GameObject> listOfChildrenOfAnimation;

    // Use this for initialization
    void Start () {
        listOfChildrenOfModel = new List<GameObject>();
        listOfChildrenOfAnimation = new List<GameObject>();
        animation = GameObject.Find("testanim");
        thisObject = transform.FindChild("female_01_reference_skeleton").gameObject;

        GetChildRecursiveForModel(thisObject);
        GetChildRecursiveForAnimation(animation);

        MatchAnimationToModel();

        //Debug.Log("NUMBER OF CHILDREN");
        //Debug.Log(listOfChildrenOfAnimation.Count);
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void MatchAnimationToModel()
    {
        for(int iter = 0; iter < listOfChildrenOfAnimation.Count; iter++)
        {
            for(int iter2 = 0; iter2 < listOfChildrenOfModel.Count; iter2++)
            {
                if(listOfChildrenOfAnimation[iter].name == listOfChildrenOfModel[iter2].name)
                {
                    //listOfChildrenOfModel[iter2].transform.DetachChildren();
                    listOfChildrenOfModel[iter2].transform.parent = listOfChildrenOfAnimation[iter].transform;
                    listOfChildrenOfModel[iter2].AddComponent<AlwaysAtParentScript>();
                    //listOfChildrenOfModel[iter2].transform.localRotation = Quaternion.identity;
                    //listOfChildrenOfModel[iter2].transform.localPosition = Vector3.zero;
                    //listOfChildrenOfModel[iter2].transform.rotation = Quaternion.identity;
                    //listOfChildrenOfModel[iter2].transform.position = Vector3.zero;
                    //listOfChildrenOfModel[iter2].transform.localScale = listOfChildrenOfAnimation[iter2].transform.localScale;
                    iter2 = listOfChildrenOfModel.Count;
                }
            }
        }
    }

    private void GetChildRecursiveForModel(GameObject obj)
    {
        if (null == obj)
        {
            return;
        }

        for(int iter = 0; iter < obj.transform.childCount; iter++)
        {
            if (null == obj.transform.GetChild(iter).gameObject)
            {
                continue;
            }
            //child.gameobject contains the current child you can do whatever you want like add it to an array
            listOfChildrenOfModel.Add(obj.transform.GetChild(iter).gameObject);
            GetChildRecursiveForModel(obj.transform.GetChild(iter).gameObject);
        }
    }

    private void GetChildRecursiveForAnimation(GameObject obj)
    {
        if (null == obj)
        {
            return;
        }

        for (int iter = 0; iter < obj.transform.childCount; iter++)
        {
            if (null == obj.transform.GetChild(iter).gameObject)
            {
                continue;
            }
            //child.gameobject contains the current child you can do whatever you want like add it to an array
            listOfChildrenOfAnimation.Add(obj.transform.GetChild(iter).gameObject);
            GetChildRecursiveForAnimation(obj.transform.GetChild(iter).gameObject);
        }
    }
}
