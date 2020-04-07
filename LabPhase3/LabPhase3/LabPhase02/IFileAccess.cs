/// Project Prolog
/// Name: Daniel Wood
/// CS3260 Section 001
/// Project: Lab_Phase_3
/// Date: 4/5/2020 11:52:00 PM
/// <summary>
/// Interface for file access to be implemented by FileIO
/// </summary>
///  
/// I declare that the following code was written by me or provided
/// by the instructor for this project. I understand that copying source
/// code from any other source constitutes plagiarism, and that I will receive
/// a zero on this project if I am found in violation of this policy.
/// ---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LabPhase3
{
    interface IFileAccess
    {
        SortedDictionary<String, Employee> EmployeeDB { get; set; }
        Stream fileStream { get; set; }
        void OpenFileDB();  //Utilizes OpenFileDialog and sets the "fileStream" property
        void SaveFileDB();  //Utilizes SaveFileDialog and sets the "fileStream" property
        void ReadDB();      //Deserializes the "fileStream" and sets the EmployeeDB
        void WriteDB();     //Serializes the EmployeeDB and writes to the "fileStream"
    }
}
