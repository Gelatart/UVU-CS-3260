/// Project Prolog
/// Name: Daniel Wood
/// CS3260 Section 001
/// Project: Lab_Phase_3
/// Date: 4/5/2020 11:53:00 PM
/// <summary>
/// Singleton class that uses serialization and deserialization to deal with opening and saving files
/// </summary>
///  
/// I declare that the following code was written by me or provided
/// by the instructor for this project. I understand that copying source
/// code from any other source constitutes plagiarism, and that I will receive
/// a zero on this project if I am found in violation of this policy.
/// ---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace LabPhase3
{
    public class FileIO : object, IFileAccess
    {

        private static FileIO _instance;
        public static FileIO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FileIO();
                }
                return _instance;
            }
        }
        private SortedDictionary<string, Employee> _employeeDB;
        public SortedDictionary<string, Employee> EmployeeDB 
        {
            get { return _employeeDB; }
            set { _employeeDB = value; }
        }
        private SortedDictionary<string, Employee> _formerDB;
        public SortedDictionary<string, Employee> FormerDB
        {
            get { return _formerDB; }
            set { _formerDB = value; }
        }
        private SortedDictionary<string, Course> _courseDB;
        public SortedDictionary<string, Course> CourseDB
        {
            get { return _courseDB; }
            set { _courseDB = value; }
        }
        List<SortedDictionary<string, Employee>> listDB = new List<SortedDictionary<string, Employee>>();
        //List<SortedDictionary<string, Employee>> listDB = new List<SortedDictionary<string, Employee>> { EmployeeDB, FormerDB };
        private Stream _fileStream;
        public Stream fileStream 
        {
            get { return _fileStream; }
            set { _fileStream = value; }
        }

        private bool _fileOpened;
        public bool fileOpened
        {
            get { return _fileOpened; }
            set { _fileOpened = value; }
        }
        private bool _fileSaved;
        public bool fileSaved
        {
            get { return _fileSaved; }
            set { _fileSaved = value; }
        }

        private FileIO()
        {

        }

        public void OpenFileDB()
        {
            //Utilizes OpenFileDialog and sets the "fileStream" property
            fileOpened = false;
            OpenFileDialog OpenDialog = new OpenFileDialog();
            OpenDialog.Title = "Daniel's Open File Dialog";
            OpenDialog.Filter = "Text Files (.txt)|*.txt";
            if (OpenDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileStream = File.OpenRead(OpenDialog.FileName);
                fileOpened = true;
            }
        }


        public void SaveFileDB()
        {
            //Utilizes SaveFileDialog and sets the "fileStream" property
            listDB.Add(EmployeeDB);
            listDB.Add(FormerDB);
            fileSaved = false;
            SaveFileDialog SaveDialog = new SaveFileDialog();
            SaveDialog.Title = "Daniel's Save File Dialog";
            SaveDialog.Filter = "Text Files (.txt)|*.txt";
            if (SaveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    fileStream = File.OpenWrite(SaveDialog.FileName);
                    fileSaved = true;
                }
                catch (System.IO.IOException err)
                {
                    //show error message
                }
            }
        }

        public void ReadDB()
        {
            //Deserializes the "fileStream" and sets the EmployeeDB
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                //List<SortedDictionary<string, Employee>> listDB = new List<SortedDictionary<string, Employee>>();
                //listDB = (List<SortedDictionary<string, Employee>>)formatter.Deserialize(fileStream);
                EmployeeDB = (SortedDictionary<string, Employee>)formatter.Deserialize(fileStream);
                FormerDB = (SortedDictionary<string, Employee>)formatter.Deserialize(fileStream);
                CourseDB = (SortedDictionary<string, Course>)formatter.Deserialize(fileStream);
                //EmployeeDB = listDB[0];
                //FormerDB = listDB[1];
            } 
            catch(ArgumentException)
            {

            }
            catch(SerializationException)
            {

            }
        }

        public void WriteDB()
        {
            //Serializes the EmployeeDB and writes to the "fileStream"
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                //formatter.Serialize(fileStream, listDB);
                formatter.Serialize(fileStream, EmployeeDB);
                formatter.Serialize(fileStream, FormerDB);
                formatter.Serialize(fileStream, CourseDB);
            }
            catch (ArgumentNullException)
            {

            }
            
        }


    }
}
