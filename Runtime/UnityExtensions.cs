

using UnityEngine;
public static class UnityExtensions
{

    // keys

    public static void SetKeyCode(string key, KeyCode value)
    {
        FBPP.SetInt(key, (int)value);
    }
    public static KeyCode GetKeyCode(string key)
    {
        return (KeyCode)FBPP.GetInt(key);
    }
    public static void DeleteKeyCode(string key)
    {
        FBPP.DeleteInt(key);
    }


    public static bool HasKeyForKeyCode(string key)
    {
        return FBPP.HasKeyForInt(key);
    }


    // Vector3
    public static void SetVector3(string key, Vector3 value)
    {
        for (int i = 0; i < 3; i++)
        {
            FBPP.SetFloat(key + "_" + i, value[i]);
        }
    }
    public static Vector3 GetVector3(string key)
    {
        Vector3 vec = new();
        for (int i = 0; i < 3; i++)
        {
            vec[i] = FBPP.GetFloat(key + "_" + i);
        }

        return vec;
    }
    public static bool HasKeyForVector3(string key)
    {

        for (int i = 0; i < 3; i++)
        {
            bool has = FBPP.HasKeyForFloat(key + "_" + i);
            if (!has) return false;
        }
        return true;
    }


    // Quaternion
    public static void SetQuaternion(string key, Quaternion value)
    {
        for (int i = 0; i < 4; i++)
        {
            FBPP.SetFloat(key + "_" + i, value[i]);
        }
    }
    public static Quaternion GetQuaternion(string key)
    {
        Quaternion vec = new();
        for (int i = 0; i < 4; i++)
        {
            vec[i] = FBPP.GetFloat(key + "_" + i);
        }

        return vec;
    }
    public static bool HasKeyForQuaternion(string key)
    {

        for (int i = 0; i < 4; i++)
        {
            bool has = FBPP.HasKeyForFloat(key + "_" + i);
            if (!has) return false;
        }
        return true;
    }
}