using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Tavisca.StudentAdmissionSystem.Adapter.Model;

namespace Tavisca.StudentAdmissionSystem.Adapter.Database
{
    public class FileSystem : IDatabase
    {
        public string SaveStudentInformation(StudentAdmissionRequestResponseModel newStudentInCollege)
        { 
            string fileName = @"C:\Users\asharma\Desktop\StudentAdmissionSystem\Tavisca.StudentAdmissionSystem\Tavisca.StudentAdmissionSystem.Adapter\StudentsDatabaseFileSystem\"+newStudentInCollege.FName+" "+newStudentInCollege.LName+".txt";
            string newStudentObjectIntoString = null;
            try
            {  
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }  
                using (FileStream fs = File.Create(fileName))
                {
                    newStudentObjectIntoString = JsonConvert.SerializeObject(newStudentInCollege);
                    Byte[] title = new UTF8Encoding(true).GetBytes(newStudentObjectIntoString);
                    fs.Write(title, 0, title.Length); 
                }
                // Open the stream and read it back.  
                //using (StreamReader sr = File.OpenText(fileName))
                //{
                //    string s = "";
                //    while ((s = sr.ReadLine()) != null)
                //    {
                //        Console.WriteLine(s);
                //    }
                //}
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            } 
            return newStudentObjectIntoString;
        }
    }
}
