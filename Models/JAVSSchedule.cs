using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace RecorderApi.Models.Schedule

{
	[XmlRoot(ElementName="Schedule", Namespace="http://schemas.javs.com/schedule/2010")]
	public class Schedule 
	{
		public Schedule() {}
		
		[JsonIgnore]
		[XmlIgnore]
		[BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
		
		[BsonElement("scheduleId")]
		[XmlElement(ElementName="ScheduleId", Namespace="http://schemas.javs.com/schedule/2010")]
		public string ScheduleId { get; set; }
		
		[BsonElement("master")]
		[XmlElement(ElementName="Master", Namespace="http://schemas.javs.com/schedule/2010")]
		public Master Master { get; set; }
		
		[BsonElement("location")]
		[XmlElement(ElementName="Location", Namespace="http://schemas.javs.com/schedule/2010")]
		public string Location { get; set; }
		
		[BsonElement("type")]
		[XmlElement(ElementName="Type", Namespace="http://schemas.javs.com/schedule/2010")]
		public string Type { get; set; }
		
		[BsonElement("groups")]
		[XmlArray(ElementName="Groups", Namespace="http://schemas.javs.com/schedule/2010")]
		[XmlArrayItem(ElementName="Group", Namespace="http://schemas.javs.com/schedule/2010")]		
		public List<Group> Groups { get; set; }
		
		[BsonElement("startTime")]
		[XmlElement(ElementName="StartTime", Namespace="http://schemas.javs.com/schedule/2010")]
		public string StartTime { get; set; }

		[BsonElement("endTime")]
		[XmlElement(ElementName="EndTime", Namespace="http://schemas.javs.com/schedule/2010")]
		public string EndTime { get; set; }

		[BsonElement("order")]
		[XmlElement(ElementName="Order", Namespace="http://schemas.javs.com/schedule/2010")]
		public int Order { get; set; }

		[BsonElement("completed")]
		[XmlElement(ElementName="Completed", Namespace="http://schemas.javs.com/schedule/2010")]
		public bool Completed { get; set; }

		[BsonElement("autoStart")]
		[XmlElement(ElementName="AutoStart", Namespace="http://schemas.javs.com/schedule/2010")]
		public bool AutoStart { get; set; }

		[BsonElement("autoStartMinutesEarly")]
		[XmlElement(ElementName="AutoStartMinutesEarly", Namespace="http://schemas.javs.com/schedule/2010")]
		public int AutoStartMinutesEarly { get; set; }
		
		[BsonElement("autoStop")]
		[XmlElement(ElementName="AutoStop", Namespace="http://schemas.javs.com/schedule/2010")]
		public bool AutoStop { get; set; }
	}
	[XmlRoot(ElementName="Master", Namespace="http://schemas.javs.com/schedule/2010")]
	public class Master 
	{
		[BsonElement("masterId")]
		[XmlElement(ElementName="Id", Namespace="http://schemas.javs.com/schedule/2010")]
		public string MasterId { get; set; }
		
		[BsonElement("title")]
		[XmlElement(ElementName="Title", Namespace="http://schemas.javs.com/schedule/2010")]
		public string Title { get; set; }
		
		[BsonElement("sealed")]
		[XmlElement(ElementName="Sealed", Namespace="http://schemas.javs.com/schedule/2010")]
		public string Sealed { get; set; }
	}
	public class Group 
		{
			//MasterGroupId
			//Name
			//Order
			//IsLoggable
			//Parties
				//Party
				//FirstName
				//MiddleInitial
				//Prefix
				//Suffix
				//ExternalIdentifier
				//Birthdate
			[BsonIgnore]
			[JsonIgnore]
			[XmlIgnore]
			public long Id {get; set;}
			
			[BsonElement("group")]
			[JsonProperty(PropertyName = "group")]
			[XmlText]
			public string Value {get; set;}
		}

}
