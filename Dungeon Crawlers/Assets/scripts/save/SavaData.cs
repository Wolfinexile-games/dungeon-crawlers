using UnityEngine;    // For Debug.Log, etc.

using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

using System;
using System.Runtime.Serialization;
using System.Reflection;

// === This is the info container class ===
[Serializable()]
public class SaveData : ISerializable
{
    public static SaveData saveData = new SaveData();
    // === Values ===
    // Edit these during gameplay
    public int sceneID;
    public int dungeonsCleared;
    public string actorName;
    public int actorLevel;
    public float actorXP;
    public BaseCharacterClass actorClass;
    public int charisma;
    public int luck;
    public int agility;
    public int strength;
    public int speed;
    // === /Values ===

    // The default constructor. Included for when we call it during Save() and Load()
    public SaveData() { }

    // This constructor is called automatically by the parent class, ISerializable
    // We get to custom-implement the serialization process here
    public SaveData(SerializationInfo info, StreamingContext ctxt)
    {
        // Get the values from info and assign them to the appropriate properties. Make sure to cast each variable.
        // Do this for each var defined in the Values section above
        sceneID = (int)info.GetValue("sceneID", typeof(int));
        dungeonsCleared = (int)info.GetValue("dungeonsCleared", typeof(int));
        actorName = (string)info.GetValue("actorName", typeof(string));
        actorLevel = (int)info.GetValue("actorLevel", typeof(int));
        actorXP = (float)info.GetValue("actorXP", typeof(float));
        actorClass = (BaseCharacterClass)info.GetValue("actorClass", typeof(BaseCharacterClass));
        charisma = (int)info.GetValue("charisma", typeof(int));
        luck = (int)info.GetValue("luck", typeof(int));
        agility = (int)info.GetValue("agility", typeof(int));
        strength = (int)info.GetValue("strength", typeof(int));
        speed = (int)info.GetValue("speed", typeof(int));
    }

    // Required by the ISerializable class to be properly serialized. This is called automatically
    public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
    {
        // Repeat this for each var defined in the Values section
        info.AddValue("sceneID", sceneID);
        info.AddValue("dungeonsCleared", dungeonsCleared);
        info.AddValue("actorName", actorName);
        info.AddValue("actorLevel", actorLevel);
        info.AddValue("actorXP", actorXP);
        info.AddValue("actorClass", (actorClass));
        info.AddValue("charisma", charisma);
        info.AddValue("luck", luck);
        info.AddValue("agility", agility);
        info.AddValue("strength", strength);
        info.AddValue("speed", speed);

    }
}

// === This is the class that will be accessed from scripts ===
public class SaveLoad
{

    public static string currentFilePath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "SaveData.dcs";    // Edit this for different save files

    // Call this to write data
    public static void Save()  // Overloaded
    {
        Save(currentFilePath);
    }
    public static void Save(string filePath)
    {
        SaveData data = new SaveData();

        Stream stream = File.Open(filePath, FileMode.Create);
        BinaryFormatter bformatter = new BinaryFormatter();
        bformatter.Binder = new VersionDeserializationBinder();
        bformatter.Serialize(stream, data);
        stream.Close();
    }

    // Call this to load from a file into "data"
    public static void Load() { Load(currentFilePath); }   // Overloaded
    public static void Load(string filePath)
    {
        SaveData data = new SaveData();
        Stream stream = File.Open(filePath, FileMode.Open);
        BinaryFormatter bformatter = new BinaryFormatter();
        bformatter.Binder = new VersionDeserializationBinder();
        data = (SaveData)bformatter.Deserialize(stream);
        stream.Close();

        // Now use "data" to access your Values
    }

}

// === This is required to guarantee a fixed serialization assembly name, which Unity likes to randomize on each compile
// Do not change this
public sealed class VersionDeserializationBinder : SerializationBinder
{
    public override Type BindToType(string assemblyName, string typeName)
    {
        if (!string.IsNullOrEmpty(assemblyName) && !string.IsNullOrEmpty(typeName))
        {
            Type typeToDeserialize = null;

            assemblyName = Assembly.GetExecutingAssembly().FullName;

            // The following line of code returns the type. 
            typeToDeserialize = Type.GetType(String.Format("{0}, {1}", typeName, assemblyName));

            return typeToDeserialize;
        }

        return null;
    }
}