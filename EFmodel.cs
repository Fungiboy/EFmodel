using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entity_Framework;

public class EFmodel
{
}
/*
// Check if a blog with the same Id already exists in the context
var existingBlog = db.Blogs.Find(blogId);

    if (existingBlog != null)
    {
        // Update the existing blog
        existingBlog.Url = url;
        existingBlog.Name = name;
        existingBlog.PostId = postid;
    }
    else
{
    // Add a new blog
    db.Blogs.Add(new Blog { Id = blogId, Url = url, Name = name, PostId = postid });
}
}
*/