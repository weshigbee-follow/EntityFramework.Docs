﻿using Microsoft.EntityFrameworkCore;

namespace EFModeling.Conventions.Samples.InheritanceDbSets
{
    class MyContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<RssBlog> RssBlogs { get; set; }
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
    }

    public class RssBlog : Blog
    {
        public string RssUrl { get; set; }
    }
}
