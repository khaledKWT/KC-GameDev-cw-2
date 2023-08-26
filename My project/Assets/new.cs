using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class script : MonoBehaviour
{
    string heroname = "khaled";
    int heropower = 200;

    string villainname = "soud";
    int villainpower = 999;
    float playerspeed = 200;
    // Start is called before the first frame update
    void Start()
    {
        if (heropower >= villainpower)
        {
            print("heropower strong then villainpower");
        }
        else if (heropower < villainpower)
        {
            print("villainpow strong then heropower");
        }
        else
        {
            print("khaled power = soud power");
        }
        print(playerspeed);
        setspeed(2.5f);
        print(playerspeed);
    }
    // Update is called once per frame
    void Update()
    {

    }

    void setspeed(float speed)
    {
        playerspeed = speed;

    }
}
