using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace RecorderApi.Models.Session

{
	[XmlRoot(ElementName="Master", Namespace="http://schemas.javs.com/master/2010")]
	public class Master 
	{
		public Master() {}
		
		[JsonIgnore]
		[XmlIgnore]
		[BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string mongoId { get; set; }

		[BsonElement("masterId")]
		[XmlElement(ElementName="MasterId", Namespace="http://schemas.javs.com/master/2010")]
		public string MasterId { get; set; }
		
		[BsonElement("id")]
		[XmlElement(ElementName="Id", Namespace="http://schemas.javs.com/master/2010")]
		public string Id { get; set; }
		
		[BsonElement("title")]
		[XmlElement(ElementName="Title", Namespace="http://schemas.javs.com/master/2010")]
		public string Title { get; set; }
		
		[BsonElement("pack")]
		[XmlElement(ElementName="Pack", Namespace="http://schemas.javs.com/master/2010")]
		public string Pack { get; set; }
		
		[BsonElement("isSealed")]
		[XmlElement(ElementName="IsSealed", Namespace="http://schemas.javs.com/master/2010")]
		public string IsSealed { get; set; }
		
		[BsonElement("sessions")]
		[XmlElement(ElementName="Sessions", Namespace="http://schemas.javs.com/master/2010")]
		public Sessions Sessions { get; set; }

		[BsonElement("exhibits")]
		[XmlElement(ElementName="Exhibits", Namespace="http://schemas.javs.com/master/2010")]
		public Exhibits Exhibits { get; set; }
    }

	[XmlRoot(ElementName="Sessions", Namespace="http://schemas.javs.com/master/2010")]
	public class Sessions {
		[BsonElement("session")]
		[XmlElement(ElementName="Session", Namespace="http://schemas.javs.com/master/2010")]
		public List<Session> Session { get; set; }
	}

	[BsonIgnoreExtraElements]
	[XmlRoot(ElementName="Session", Namespace="http://schemas.javs.com/master/2010")]
	public class Session {
		[BsonElement("sessionId")]
		[XmlElement(ElementName="SessionId", Namespace="http://schemas.javs.com/master/2010")]
		public string SessionId { get; set; }
		
		[BsonElement("type")]
		[XmlElement(ElementName="Type", Namespace="http://schemas.javs.com/master/2010")]
		public string Type { get; set; }
		
		[BsonElement("location")]
		[XmlElement(ElementName="Location", Namespace="http://schemas.javs.com/master/2010")]
		public string Location { get; set; }
		
		[BsonElement("startDate")]
		[XmlElement(ElementName="StartDate", Namespace="http://schemas.javs.com/master/2010")]
		public string StartDate { get; set; }
		
		[BsonElement("endDate")]
		[XmlElement(ElementName="EndDate", Namespace="http://schemas.javs.com/master/2010")]
		public string EndDate { get; set; }
		
		[BsonElement("events")]
		[XmlElement(ElementName="Events", Namespace="http://schemas.javs.com/master/2010")]
		 public Events Events { get; set; }
		
		[BsonElement("masterGroups")]
		[XmlElement(ElementName="MasterGroups", Namespace="http://schemas.javs.com/master/2010")]
		public MasterGroups MasterGroups { get; set; }
		
		[BsonElement("medias")]
		[XmlElement(ElementName="Medias", Namespace="http://schemas.javs.com/master/2010")]
		public Medias Medias { get; set; }
	}

	[XmlRoot(ElementName="Events", Namespace="http://schemas.javs.com/master/2010")]
	public class Events {
		[BsonElement("event")]
		[XmlElement(ElementName="Event", Namespace="http://schemas.javs.com/master/2010")]
		public List<Event> Event { get; set; }
	}
	[XmlRoot(ElementName="Event", Namespace="http://schemas.javs.com/master/2010")]
	public class Event {
		[BsonElement("eventId")]
		[XmlElement(ElementName="EventId", Namespace="http://schemas.javs.com/master/2010")]
		public string EventId { get; set; }
		
		[BsonElement("eventCategoryId")]
		[XmlElement(ElementName="EventTypeCategoryId", Namespace="http://schemas.javs.com/master/2010")]
		public string EventTypeCategoryId { get; set; }
		
		[BsonElement("eventTypeId")]
		[XmlElement(ElementName="EventTypeId", Namespace="http://schemas.javs.com/master/2010")]
		public string EventTypeId { get; set; }
		
		[BsonElement("identifier")]
		[XmlElement(ElementName="Identifier", Namespace="http://schemas.javs.com/master/2010")]
		public string Identifier { get; set; }
		
		[BsonElement("isPrivate")]
		[XmlElement(ElementName="IsPrivate", Namespace="http://schemas.javs.com/master/2010")]
		public string IsPrivate { get; set; }
		
		[BsonElement("isSystemEvent")]
		[XmlElement(ElementName="IsSystemEvent", Namespace="http://schemas.javs.com/master/2010")]
		public string IsSystemEvent { get; set; }
		
		[BsonElement("name")]
		[XmlElement(ElementName="Name", Namespace="http://schemas.javs.com/master/2010")]
		public string Name { get; set; }
		
		[BsonElement("timeStamp")]
		[XmlElement(ElementName="TimeStamp", Namespace="http://schemas.javs.com/master/2010")]
		public string TimeStamp { get; set; }
		
		[BsonElement("type")]
		[XmlElement(ElementName="Type", Namespace="http://schemas.javs.com/master/2010")]
		public string Type { get; set; }
		
		[BsonElement("eventNotes")]
		[XmlElement(ElementName="EventNotes", Namespace="http://schemas.javs.com/master/2010")]
		public string EventNotes { get; set; }
	}

	[XmlRoot(ElementName="MasterGroups", Namespace="http://schemas.javs.com/master/2010")]
	public class MasterGroups {
		[BsonElement("masterGroup")]
		[XmlElement(ElementName="MasterGroup", Namespace="http://schemas.javs.com/master/2010")]
		public List<MasterGroup> MasterGroup { get; set; }
	}
	[XmlRoot(ElementName="MasterGroup", Namespace="http://schemas.javs.com/master/2010")]
	public class MasterGroup {
		[BsonElement("masterGroupId")]
		[XmlElement(ElementName="MasterGroupID", Namespace="http://schemas.javs.com/master/2010")]
		public string MasterGroupID { get; set; }
		
		[BsonElement("name")]
		[XmlElement(ElementName="Name", Namespace="http://schemas.javs.com/master/2010")]
		public string Name { get; set; }
		
		[BsonElement("order")]
		[XmlElement(ElementName="Order", Namespace="http://schemas.javs.com/master/2010")]
		public string Order { get; set; }
		
		[BsonElement("isLoggable")]
		[XmlElement(ElementName="IsLoggable", Namespace="http://schemas.javs.com/master/2010")]
		public string IsLoggable { get; set; }
		
		[BsonElement("parties")]
		[XmlElement(ElementName="Parties", Namespace="http://schemas.javs.com/master/2010")]
		public Parties Parties { get; set; }
	}

	[XmlRoot(ElementName="Parties", Namespace="http://schemas.javs.com/master/2010")]
	public class Parties {
		[BsonElement("party")]
		[XmlElement(ElementName="Party", Namespace="http://schemas.javs.com/master/2010")]
		public Party Party { get; set; }
	}
	[XmlRoot(ElementName="Party", Namespace="http://schemas.javs.com/master/2010")]
	public class Party {
		[BsonElement("firstName")]
		[XmlElement(ElementName="FirstName", Namespace="http://schemas.javs.com/master/2010")]
		public string FirstName { get; set; }
		
		[BsonElement("lastName")]
		[XmlElement(ElementName="LastName", Namespace="http://schemas.javs.com/master/2010")]
		public string LastName { get; set; }
		
		[BsonElement("middleInitial")]
		[XmlElement(ElementName="MiddleInitial", Namespace="http://schemas.javs.com/master/2010")]
		public string MiddleInitial { get; set; }
		
		[BsonElement("prefix")]
		[XmlElement(ElementName="Prefix", Namespace="http://schemas.javs.com/master/2010")]
		public string Prefix { get; set; }
		
		[BsonElement("suffix")]
		[XmlElement(ElementName="Suffix", Namespace="http://schemas.javs.com/master/2010")]
		public string Suffix { get; set; }
		
		[BsonElement("externalIdentifier")]
		[XmlElement(ElementName="ExternalIdentifier", Namespace="http://schemas.javs.com/master/2010")]
		public string ExternalIdentifier { get; set; }
		
		[BsonElement("birthDate")]
		[XmlElement(ElementName="BirthDate", Namespace="http://schemas.javs.com/master/2010")]
		public string BirthDate { get; set; }
	}
	[XmlRoot(ElementName="Medias", Namespace="http://schemas.javs.com/master/2010")]
	public class Medias {
		[BsonElement("media")]
		[XmlElement(ElementName="Media", Namespace="http://schemas.javs.com/master/2010")]
		public Media Media { get; set; }
	}
	[XmlRoot(ElementName="Media", Namespace="http://schemas.javs.com/master/2010")]
	public class Media {
		[BsonElement("deviceId")]
		[XmlElement(ElementName="DeviceId", Namespace="http://schemas.javs.com/master/2010")]
		public string DeviceId { get; set; }
		
		[BsonElement("height")]
		[XmlElement(ElementName="Height", Namespace="http://schemas.javs.com/master/2010")]
		public string Height { get; set; }
		
		[BsonElement("incomplete")]
		[XmlElement(ElementName="Incomplete", Namespace="http://schemas.javs.com/master/2010")]
		public string Incomplete { get; set; }
		
		[BsonElement("path")]
		[XmlElement(ElementName="Path", Namespace="http://schemas.javs.com/master/2010")]
		public string Path { get; set; }
		
		[BsonElement("width")]
		[XmlElement(ElementName="Width", Namespace="http://schemas.javs.com/master/2010")]
		public string Width { get; set; }
		
		[BsonElement("mediaSegments")]
		[XmlElement(ElementName="MediaSegments", Namespace="http://schemas.javs.com/master/2010")]
		public string MediaSegments { get; set; }
	}

	[XmlRoot(ElementName="Exhibits", Namespace="http://schemas.javs.com/master/2010")]
	public class Exhibits {
		[BsonElement("exhibit")]
		[XmlElement(ElementName="Exhibit", Namespace="http://schemas.javs.com/master/2010")]
		public List<Exhibit> Exhibit { get; set; }
	}
	[XmlRoot(ElementName="Exhibit", Namespace="http://schemas.javs.com/master/2010")]
	public class Exhibit {
		[BsonElement("description")]
		[XmlElement(ElementName="Description", Namespace="http://schemas.javs.com/master/2010")]
		public string Description { get; set; }
		
		[BsonElement("exhibitId")]
		[XmlElement(ElementName="ExhibitId", Namespace="http://schemas.javs.com/master/2010")]
		public string ExhibitId { get; set; }
		
		[BsonElement("fileName")]
		[XmlElement(ElementName="FileName", Namespace="http://schemas.javs.com/master/2010")]
		public string FileName { get; set; }
		
		[BsonElement("localFilePath")]
		[XmlElement(ElementName="LocalFilePath", Namespace="http://schemas.javs.com/master/2010")]
		public string LocalFilePath { get; set; }
		
		[BsonElement("name")]
		[XmlElement(ElementName="Name", Namespace="http://schemas.javs.com/master/2010")]
		public string Name { get; set; }
	}
}