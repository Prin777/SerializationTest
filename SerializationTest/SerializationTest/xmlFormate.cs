using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SerializationTest
{
    class xmlFormate
    {
    }

    [XmlRoot("TMAS")]
    public class TMAS
    {
        [XmlElement(ElementName = "TMASProject")]
        public TMASProject tmasp;

        [XmlArray("DOModelCollection")]
        public List<DOModule> domodules { get; set; }
    }
    public class TMASProject
    {
        [XmlElement(ElementName = "Version")]
        public string Version
        { get; set; }

        [XmlElement(ElementName = "ProjectID")]
        public string ProjectID
        { get; set; }

        [XmlElement(ElementName = "ProjectName")]
        public string ProjectName
        { get; set; }

        [XmlElement(ElementName = "ProjectType")]
        public string ProjectType
        { get; set; }

        [XmlElement(ElementName = "CreateTime")]
        public string CreateTime
        { get; set; }

        [XmlElement(ElementName = "CreateUnit")]
        public string CreateUnit
        { get; set; }

        [XmlElement(ElementName = "CreatedVersion")]
        public string CreatedVersion
        { get; set; }

        [XmlElement(ElementName = "CreatedBy")]
        public string CreatedBy
        { get; set; }

        [XmlElement(ElementName = "Note")]
        public string Note
        { get; set; }

        [XmlElement(ElementName = "EditStatus")]
        public string EditStatus
        { get; set; }

        [XmlElement(ElementName = "TopID")]
        public string TopID
        { get; set; }
    }

    [XmlType(TypeName = "DOModule"), Serializable]
    public class DOModule
    {
        [XmlAttribute("DO_ID")]
        public string DO_ID
        { get; set; }

        [XmlAttribute("ModelCode")]
        public string ModelCode
        { get; set; }

        [XmlAttribute("DO_ParentID")]
        public string DO_ParentID
        { get; set; }

        [XmlAttribute("UnitWidth")]
        public string UnitWidth
        { get; set; }

        [XmlAttribute("UnitHeight")]
        public string UnitHeight
        { get; set; }

        [XmlAttribute("DO_Name")]
        public string DO_Name
        { get; set; }

        [XmlAttribute("DO_OrderNo")]
        public string DO_OrderNo
        { get; set; }

        [XmlAttribute("DO_Location")]
        public string DO_Location
        { get; set; }

        [XmlAttribute("DO_Size")]
        public string DO_Size
        { get; set; }

        [XmlAttribute("DO_TextColor")]
        public string DO_TextColor
        { get; set; }

        [XmlAttribute("DO_DrawColor")]
        public string DO_DrawColor
        { get; set; }

        [XmlAttribute("DO_FillColor")]
        public string DO_FillColor
        { get; set; }

        [XmlAttribute("DO_Font")]
        public string DO_Font
        { get; set; }

        [XmlAttribute("DO_DrawWidth")]
        public string DO_DrawWidth
        { get; set; }

        [XmlAttribute("DO_DashStyle")]
        public string DO_DashStyle
        { get; set; }

        [XmlAttribute("HeadText")]
        public string HeadText
        { get; set; }

        [XmlAttribute("IsConfigModule")]
        public string IsConfigModule
        { get; set; }
        //public DOModule()
        //{
        //}

        //[XmlElement(ElementName = "Functions")]
        //public Functions Functions;

        [XmlElement(ElementName = "Properties")]
        public Properties Properties;

        ///// <summary>
        ///// 内部包含的元器件
        ///// </summary>
        //[XmlArray("DOObjects")]
        //public List<DOModule1> DoObjects { get; set; }

        [XmlArray("DOPorts")]
        public List<DOPort> DoPoorts { get; set; }

        [XmlArray("DOLinks")]
        public List<DOLink> DoLinks { get; set; }
    }

    [Serializable]
    public class Functions
    {
        [XmlElement(ElementName = "CurrentFunctions")]
        public string CurrentFunctions;

        [XmlElement(ElementName = "AttachedFunctions")]
        public string AttachedFunctions;

        [XmlElement(ElementName = "MappingFunctions")]
        public string MappingFunctions;

        [XmlElement(ElementName = "BlockingFunctions")]
        public string BlockingFunctions;
    }

    [Serializable]
    public class Properties
    {
        [XmlElement(ElementName = "TechData")]
        public string TechData;

        [XmlElement(ElementName = "RepairCoat")]
        public string RepairCoat;

        [XmlElement(ElementName = "RepairTime")]
        public string RepairTime;

        [XmlElement(ElementName = "MTBF")]
        public string MTBF;

        [XmlElement(ElementName = "FailureRate")]
        public string FailureRate;

        [XmlElement(ElementName = "HasBist")]
        public string HasBist;

        [XmlElement(ElementName = "BISTCost")]
        public string BISTCost;

        [XmlElement(ElementName = "HarshLevel")]
        public string HarshLevel;

        [XmlElement(ElementName = "BISTTime")]
        public string BISTTime;

        [XmlElement(ElementName = "BISTDelay")]
        public string BISTDelay;

        [XmlElement(ElementName = "ImageID")]
        public string ImageID;

        [XmlElement(ElementName = "ModuleCatagory")]
        public string ModuleCatagory;

        [XmlElement(ElementName = "HierarchyLevel")]
        public HierarchyLevel HierarchyLevel;
    }

    [Serializable]
    public class HierarchyLevel
    {
        [XmlAttribute("DO_ID")]
        public string DO_ID
        { get; set; }

        [XmlAttribute("DO_Name")]
        public string DO_Name
        { get; set; }

        [XmlAttribute("DO_Description")]
        public string DO_Description
        { get; set; }

        [XmlAttribute("DO_OrderNO")]
        public string DO_OrderNO
        { get; set; }

        [XmlAttribute("UseCount")]
        public string UseCount
        { get; set; }
    }

    //[XmlType(TypeName = "DOModule1"), Serializable]
    //public class DOModule1
    //{
    //    [XmlAttribute("DO_ID")]
    //    public string DO_ID
    //    { get; set; }

    //    [XmlAttribute("DO_ParentID")]
    //    public string DO_ParentID
    //    { get; set; }
    //}

    [XmlType(TypeName = "DOPort"), Serializable]
    public class DOPort
    {
        [XmlAttribute("DO_ID")]
        public string DO_ID
        { get; set; }

        [XmlAttribute("DO_ParentID")]
        public string DO_ParentID
        { get; set; }

        [XmlAttribute("DO_Name")]
        public string DO_Name
        { get; set; }

        [XmlAttribute("DO_OrderNo")]
        public string DO_OrderNo
        { get; set; }

        [XmlAttribute("DO_Location")]
        public string DO_Location
        { get; set; }

        [XmlAttribute("DO_Location2")]
        public string DO_Location2
        { get; set; }

        [XmlAttribute("DO_TextColor")]
        public string DO_TextColor
        { get; set; }

        [XmlAttribute("DO_DrawColor")]
        public string DO_DrawColor
        { get; set; }

        [XmlAttribute("DO_FillColor")]
        public string DO_FillColor
        { get; set; }

        [XmlAttribute("DO_Font")]
        public string DO_Font
        { get; set; }

        [XmlAttribute("HeadText")]
        public string HeadText
        { get; set; }

        [XmlAttribute("DOPortType")]
        public string DOPortType
        { get; set; }

        [XmlAttribute("AutoLocation")]
        public string AutoLocation
        { get; set; }
    }

    [XmlType(TypeName = "DOLink"), Serializable]
    public class DOLink
    {
        [XmlAttribute("DO_ID")]
        public string DO_ID
        { get; set; }

        [XmlAttribute("DO_ParentID")]
        public string DO_ParentID
        { get; set; }

        [XmlAttribute("DO_Name")]
        public string DO_Name
        { get; set; }

        [XmlAttribute("DO_OrderNo")]
        public string DO_OrderNo
        { get; set; }

        [XmlAttribute("D0_DrawColor")]
        public string D0_DrawColor
        { get; set; }

        [XmlAttribute("LineType")]
        public string LineType
        { get; set; }

        [XmlAttribute("LineWidth")]
        public string LineWidth
        { get; set; }

        [XmlAttribute("StartDO_ID")]
        public string StartDO_ID
        { get; set; }

        [XmlAttribute("StartDO_Name")]
        public string StartDO_Name
        { get; set; }

        [XmlAttribute("StartDOType")]
        public string StartDOType
        { get; set; }

        [XmlAttribute("StartPortID")]
        public string StartPortID
        { get; set; }

        [XmlAttribute("StartPortName")]
        public string StartPortName
        { get; set; }

        [XmlAttribute("EndDO_ID")]
        public string EndDO_ID
        { get; set; }

        [XmlAttribute("EndDO_Name")]
        public string EndDO_Name
        { get; set; }

        [XmlAttribute("EndDOType")]
        public string EndDOType
        { get; set; }

        [XmlAttribute("EndPortID")]
        public string EndPortID
        { get; set; }

        [XmlAttribute("EndPortName")]
        public string EndPortName
        { get; set; }

        [XmlAttribute("VitrualLine")]
        public string VitrualLine
        { get; set; }

        [XmlAttribute("Orthogonal")]
        public string Orthogonal
        { get; set; }

        [XmlAttribute("Location")]
        public string Location
        { get; set; }
    }
}
