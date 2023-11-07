package com.fightfun.tongits;

import android.os.Bundle;

import com.unity3d.player.UnityPlayer;
import com.unity3d.player.UnityPlayerActivity;

public class MainActivity extends UnityPlayerActivity {

    //用于测试的成员变量相关
    public int testI = 10;
    public static int testStaticI = 20;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
    }

    public String TestFun()
    {
        //对象名，函数名，参数
        UnityPlayer.UnitySendMessage("ACU","TestAndroidCallUnity","你好Unity");
        return  "String-Hna";
    }

    public static  String TestStaticFun()
    {
        return "TestStatic Fun-han";
    }
}