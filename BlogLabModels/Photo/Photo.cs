using System;
using System.Collections.Generic;
using System.Text;

namespace BlogLabModels.Photo
{
    public class Photo : PhotoCreate
    {
        public int PhotoId { get; set; }

        public int ApplicatioUserId { get; set; }

        public DateTime PublishDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
