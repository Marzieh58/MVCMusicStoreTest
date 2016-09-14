using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MvxMusicStore.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string Title { get; set; }
        public Artist Artist { get; set; }
        public int ReviewID { get; set; }
        public virtual List<Review> Review { get; set; }
    }
}
