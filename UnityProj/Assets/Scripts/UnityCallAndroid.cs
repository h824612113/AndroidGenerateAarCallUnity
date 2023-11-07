using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnityCallAndroid : MonoBehaviour
{

    public Text txtOld;
    public Text txtNew;
    public Text txtStaticOld;
    public Text txtStaticNew;
    public Text txtTestFun;
    public Text txtTestStaticFun;
    // Start is called before the first frame update
    void Start()
    {
        using (AndroidJavaClass javaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
        {
            using (AndroidJavaObject javaObj = javaClass.GetStatic<AndroidJavaObject>("currentActivity"))
            {
                int i = javaObj.Get<int>("testI");
                txtOld.text = i.ToString();
                
                javaObj.Set<int>("testI", 11);
                i = javaObj.Get<int>("testI");
                txtNew.text = i.ToString();
                
                int stticI = javaObj.GetStatic<int>("testStaticI");
                txtStaticOld.text = i.ToString();
                
                javaObj.SetStatic<int>("testStaticI",21);
                stticI = javaObj.GetStatic<int>("testStaticI");
                txtStaticNew.text = stticI.ToString();
                
                //调用有返回值的成员函数
                string testFunStr = javaObj.Call<string>("TestFun");
                txtTestFun.text = testFunStr;
                string testStaticFunStr = javaObj.CallStatic<string>("TestStaticFun");
                txtTestStaticFun.text = testStaticFunStr;
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
