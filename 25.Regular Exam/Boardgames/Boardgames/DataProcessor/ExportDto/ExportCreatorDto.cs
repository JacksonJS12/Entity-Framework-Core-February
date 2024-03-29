﻿using System.Xml.Serialization;
using Boardgames.Data.Models;

namespace Boardgames.DataProcessor.ExportDto;

[XmlType("Creator")]
public class ExportCreatorDto
{
    [XmlElement("CreatorName")]
    public string CreatorName { get; set; } = null!;

    [XmlAttribute("BoardgamesCount")]
    public int BoardgamesCount { get; set; }

    [XmlArray("Boardgames")]
    public ExportBoardgameDto[] Boardgames { get; set; } = null!;
}