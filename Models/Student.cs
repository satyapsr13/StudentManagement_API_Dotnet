﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace StudentManagement_API_Dotnet.Models
{
    [BsonIgnoreExtraElements]
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;


        [BsonElement("name")]
        public string Name { get; set; } = String.Empty;

        [BsonElement("graduated")]
        public bool isGraduated { get; set; }


        [BsonElement("courses")]
        public string[]? Courses { get; set; }


        [BsonElement("gender")]
        public string Gender { get; set; } = String.Empty;


        [BsonElement("age")]
        public int Age { get; set; }
    }
}
