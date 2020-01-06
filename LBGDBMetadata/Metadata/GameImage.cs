﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace LBGDBMetadata.Metadata
{
    [XmlRoot(ElementName = "GameImage")]
    public class GameImage
    {
        [XmlElement(ElementName = "DatabaseID")]
        public string DatabaseID { get; set; }
        [XmlElement(ElementName = "FileName")]
        public string FileName { get; set; }
        [XmlElement(ElementName = "Type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "Region")]
        public string Region { get; set; }
    }
}