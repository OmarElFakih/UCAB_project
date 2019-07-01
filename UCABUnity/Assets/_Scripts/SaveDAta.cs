using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

public class SaveDAta 
{
    
	/*  public static void SaveScore()
    {
		BinaryFormatter formatter = new BinaryFormatter();
	
		
        FileStream stream = new FileStream(Application.persistentDataPath + "/Score.dat", FileMode.OpenOrCreate);
        try
        {
     
			ScoreData data = new ScoreData();
            formatter.Serialize(file,data);

        }catch(SerializationException e)
        {
            Debug.Log("Error en" + e);
        }

        file.Close();

    }

    public static ScoreData LoadScore()
    {
		
		if (File.Exists(Application.persistentDataPath + "/Score.dat"))
		{
		 BinaryFormatter formatter = new BinaryFormatter();
         FileStream file = new FileStream(Application.persistentDataPath + "/Score.dat", FileMode.Open);
			
		ScoreData data=	formatter.Deserialize(file) as ScoreData;
		
		
		 file.Close();
		 
		 return data;
		}else

        {
            Debug.Log("error en " + Application.persistentDataPath + "/Score.dat" );
			return null;
		}
		
       
    }
	*/
	
}
