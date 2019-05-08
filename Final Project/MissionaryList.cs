using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Final_Project
{
    class MissionaryList
    {
        public string CurrentFile { get; set; } = "default.xml";
        public MissionaryInfo Missionary;

        public MissionaryList()
        {
            Missionary = new MissionaryInfo();
        }

        public void UpdateMissionary(string First, string Last, string Address, string State, int Zip, int Telephone, double Goal)
        {
            Missionary.MFirstName = First;
            Missionary.MLastName = Last;
            Missionary.MAddress = Address;
            Missionary.MState = State;
            Missionary.MZip = Zip;
            Missionary.MTelephone = Telephone;
            Missionary.MGoal = Goal;
            

        }

        public void clear()
        {
            Missionary.ItemList.Clear();
        }

        /// <summary>
        /// Persists List of tiems to XML file specified by location parameter
        /// </summary>
        /// <param name="location"></param>
        public void persist()
        {
            if (Missionary.ItemList.Count > 0)
            {
                XmlSerializer xser = new XmlSerializer(typeof(MissionaryInfo));
                using (FileStream fs = new FileStream(CurrentFile, FileMode.Create))
                {
                    xser.Serialize(fs, Missionary);
                }
            }
        }

        /// <summary>
        /// ReMissionarys List of items from XML file specified by location parameter
        /// </summary>
        /// <param name="location"></param>
        public void reMissionary(string location)
        {
            CurrentFile = location;

            if (File.Exists(location))
            {
                try
                {
                    Missionary.ItemList.Clear();
                    var reader = new XmlSerializer(typeof(MissionaryInfo));
                    using (StreamReader file = new StreamReader(CurrentFile))
                    {
                        Missionary = (MissionaryInfo)(reader.Deserialize(file));
                    }
                }
                catch { }
            }
        }

    }
}

