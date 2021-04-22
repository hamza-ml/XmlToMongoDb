using System.Xml.Serialization;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace XmlToMongoDb
{
    [XmlType("child")]
    public class Child
    {
        [BsonElement("entire")]
        [XmlElement("entire")]
        public string Entire { get; set; }

        [BsonElement("finest")]
        [XmlElement("finest")]
        public List<Finest> Finest { get; set; }

        [BsonElement("rest")]
        [XmlElement("rest")]
        public int Rest { get; set; }

        [BsonElement("low")]
        [XmlElement("low")]
        public string Low { get; set; }

        [BsonElement("journey")]
        [XmlElement("journey")]
        public string Journey { get; set; }

        [BsonElement("nearest")]
        [XmlElement("nearest")]
        public string Nearest { get; set; }
    }

    public class Finest
    {
        [BsonElement("obtain")]
        [XmlElement("obtain")]
        public Obtain Obtain { get; set; }

        [BsonElement("teacher")]
        [XmlElement("teacher")]
        public string Teacher { get; set; }

        [BsonElement("fifty")]
        [XmlElement("fifty")]
        public string Fifty { get; set; }

        [BsonElement("want")]
        [XmlElement("want")]
        public int Want { get; set; }

        [BsonElement("strong")]
        [XmlElement("strong")]
        public string Strong { get; set; }

        [BsonElement("represent")]
        [XmlElement("represent")]
        public float Represent { get; set; }
    }

    public class Obtain
    {
        [BsonElement("put")]
        [XmlElement("put")]
        public string Put { get; set; }

        [BsonElement("limit")]
        [XmlAttribute("limit")]
        public int Limit { get; set; }

        [BsonElement("cowboy")]
        [XmlElement("cowboy")]
        public int Cowboy { get; set; }

        [BsonElement("include")]
        [XmlElement("include")]
        public float Include { get; set; }

        [BsonElement("sport")]
        [XmlElement("sport")]
        public string Sport { get; set; }

        [BsonElement("grabbed")]
        [XmlElement("grabbed")]
        public int Grabbed { get; set; }

        [BsonElement("ruler")]
        [XmlElement("ruler")]
        public string Ruler { get; set; }
    }
}
