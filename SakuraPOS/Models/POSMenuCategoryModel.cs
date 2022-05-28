using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakuraPOS.Models
{
    internal record POSMenuCategoryModel
    {
        [BsonElement("_id")]
        public ObjectId Id { get; set; }

        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("isActive")]
        public bool IsActive { get; set; }

        [BsonElement("position")]
        public int Position { get; set; }
    }
}
