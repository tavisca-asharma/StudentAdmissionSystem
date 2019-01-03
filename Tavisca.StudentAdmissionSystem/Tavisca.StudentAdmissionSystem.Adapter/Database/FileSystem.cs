using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Tavisca.StudentAdmissionSystem.Adapter.Model;
using Tavisca.StudentAdmissionSystem.Contract.Model;

namespace Tavisca.StudentAdmissionSystem.Adapter.Database
{
    public class FileSystem : IDatabase
    {
        public Student SaveStudentInformation(Student newStudentInCollege)
        { 
            string fileName = @"C:\Users\asharma\Desktop\StudentAdmissionSystem\Tavisca.StudentAdmissionSystem\Tavisca.StudentAdmissionSystem.Adapter\StudentsDatabaseFileSystem\"+newStudentInCollege.FirstName+" "+newStudentInCollege.LastName+".txt";
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
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            } 
            return newStudentInCollege;
        }
    }
}
