using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme_design.Model
{
    public class ItemImages
    {
        public long id { get; set; }
        public string imageName { get; set; }
        public byte[] picture { get; set; }
        public ItemImages() {}

        public ItemImages(string imageName, byte[] picture)
        {
            this.imageName = imageName;
            this.picture = picture;
        }

        public ItemImages(long id, string imageName, byte[] picture)
        {
            this.id = id;
            this.imageName = imageName;
            this.picture = picture;
        }
    }
}
