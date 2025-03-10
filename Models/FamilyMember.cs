using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using FtbApi.Models;

namespace FtbApi.Models
{
    public class FamilyMember
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public required ObjectId Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Gender { get; set; }
        public string? Notes { get; set; }
        public string? Source { get; set; }
        public List<FamilyEvent>? Events { get; set; }
        public List<Parent>? Parents { get; set; }
        public List<Spouse>? Spouses { get; set; }
        public List<Child>? Children { get; set; }

        public static string GetFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
    }
}