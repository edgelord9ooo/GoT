 using System.Collections.Generic;
 using System.Xml.Serialization;
 
 [XmlRoot("GameDataCollection")]
 public class WesterosCardsIContainer
 {
 	[XmlArray("WesterosCardsI")]
 	[XmlArrayItem("WesterosCardI")]
 	public List<WesterosCardI> WesterosCardsI = new List<WesterosCardI>();

    [XmlArray("WesterosCardsII")]
 	[XmlArrayItem("WesterosCardII")]
 	public List<WesterosCardII> WesterosCardsII = new List<WesterosCardII>();
 }