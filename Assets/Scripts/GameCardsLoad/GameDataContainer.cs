 using System.Collections.Generic;
 using System.Xml.Serialization;
 
 [XmlRoot("GameDataCollection")]
 public class WesterosCardsIContainer
 {
 	[XmlArray("WesterosCardsI")]
 	[XmlArrayItem("WesterosCardI")]
 	public List<WesterosCard> WesterosCardsI = new List<WesterosCard>();

    [XmlArray("WesterosCardsII")]
 	[XmlArrayItem("WesterosCardII")]
 	public List<WesterosCard> WesterosCardsII = new List<WesterosCard>();
 }