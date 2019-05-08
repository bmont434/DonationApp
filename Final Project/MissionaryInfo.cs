using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Final_Project
{
    [XmlRoot("Missionary")]
    public class MissionaryInfo
    {
        [XmlElement("MFirstName")]
        public string MFirstName { get; set; }
        [XmlElement("MLastName")]
        public string MLastName { get; set; }
        [XmlElement("MAddress")]
        public string MAddress { get; set; }
        [XmlElement("MState")]
        public string MState { get; set; }
        [XmlElement("MZip")]
        public int MZip { get; set; }
        [XmlElement("MTelephone")]
        public int MTelephone { get; set; }
        [XmlElement("MGoal")]
        public double MGoal { get; set; }

        [XmlArray("ItemList"), XmlArrayItem(typeof(Donor), ElementName = "Item")]
        public List<Donor> ItemList { get; set; }

        public MissionaryInfo()
        {
            ItemList = new List<Donor>();
        }

        public MissionaryInfo(string MFirstName, string MLastName, string MAddress, string MState, int MZip, int MTelephone, double MGoal)
        {
            this.MFirstName = MFirstName;
            this.MLastName = MLastName;
            this.MAddress = MAddress;
            this.MState = MState;
            this.MZip = MZip;
            this.MTelephone = MTelephone;
            this.MGoal = MGoal;
            ItemList = new List<Donor>();
        }
    }
}