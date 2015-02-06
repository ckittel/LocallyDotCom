using System;

namespace LocallyDotCom.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Position { get; set; }
        public int? ParentId { get; set; }
        public int Depth { get; set; }
        public string Path { get; set; }
        public string PathName { get; set; }
        public string HasChildren { get; set; }
        public string AltNames { get; set; }
        public string Slug { get; set; }
    }
}